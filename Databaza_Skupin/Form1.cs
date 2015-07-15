using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databaza_Skupin
{
    public partial class Form1 : Form
    {
        private Databaza databaza = new Databaza();
        public Form1()
        {
            InitializeComponent();
            reloadList();
            button_edit.Enabled = false;
            button_del.Enabled = false;
        }

        //Menu toolstrip koooooood
        //Export DB
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Export databázy";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string filename = saveFileDialog.FileName;
                databaza.export(filename);
            }
        }

        //Import DB
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import databázy";
            openFileDialog.Filter = "CSV (*.csv)|*.csv";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                string filename = openFileDialog.FileName;
                databaza.import(filename);
                reloadList();
            }
        }

        //Koniec
        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (AddForm addform = new AddForm())
            {
                if (addform.ShowDialog() == DialogResult.OK)
                {
                    string nazov = addform.nazov;
                    int rok_vzniku = addform.rok_vzniku;
                    //this.listBox_zoznam.Items.Add(nazov); //potom nahradit cez loading listu
                    databaza.pridajSkupinu(nazov, new HudSkupina(nazov, rok_vzniku));
                    reloadList();
                    //databaza.pridajSkupinu(nazov, rok_vzniku);
                }
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            databaza.vymazSkupinu(listBox_zoznam.Items[listBox_zoznam.SelectedIndex].ToString());
            listBox_zoznam.Items.RemoveAt(listBox_zoznam.SelectedIndex);
            treeView_detail.Nodes.Clear();
        }

        private void listBox_zoznam_SelectedIndexChanged(object sender, EventArgs e) //po kliknuti na item
        {
            if (listBox_zoznam.SelectedIndex >= 0) //Ak kliknem do prazdneho pola tak vyhadzuje -1
            {
                loadTreeView(listBox_zoznam.Items[listBox_zoznam.SelectedIndex].ToString());
                button_edit.Enabled = true;
                button_del.Enabled = true;
            }
            else
            {
                button_del.Enabled = false;
                button_edit.Enabled = false;
            }
        }

        private void reloadList()
        {
            listBox_zoznam.Items.Clear();
            foreach (string str in databaza.zoznamSkupin())
            {
                listBox_zoznam.Items.Add(str);
            }
        }

        private void loadTreeView(string nazovSkupiny)
        {
            treeView_detail.Nodes.Clear();
            HudSkupina hudSkupina = databaza.getSkupina(nazovSkupiny);

            TreeNode[] tree_skupina_info = new TreeNode[]
            {
                new TreeNode("Nazov: " + hudSkupina.Nazov),
                new TreeNode("Rok vzniku: " + Convert.ToString(hudSkupina.Rok_vzniku))
            };

            TreeNode[] tree_diskografia = new TreeNode[hudSkupina.getDiskografia().Count];
            for (int i = 0; i < hudSkupina.getDiskografia().Count; i++)
            {
                tree_diskografia[i] = new TreeNode(hudSkupina.getDiskografia().ToArray()[i]);
            }

            treeView_detail.Nodes.Add(new TreeNode("Základne info", tree_skupina_info));
            treeView_detail.Nodes.Add(new TreeNode("Diskografia", tree_diskografia));
            treeView_detail.ExpandAll();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listBox_zoznam.SelectedIndex >= 0) //ak je nieco selectnute
            {
                using (EditForm editform = new EditForm(databaza.getSkupina(listBox_zoznam.Items[listBox_zoznam.SelectedIndex].ToString())))
                {
                    if (editform.ShowDialog() == DialogResult.OK)
                    {
                        //nacitat udaje
                        databaza.vymazSkupinu(listBox_zoznam.Items[listBox_zoznam.SelectedIndex].ToString());
                        HudSkupina hudSkupina = editform.hudSkupina;
                        databaza.pridajSkupinu(hudSkupina.Nazov, hudSkupina);
                        //refreshnut list a treeview
                        reloadList();
                        loadTreeView(hudSkupina.Nazov);
                    }
                }
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                listBox_zoznam.Items.Clear();
                IEnumerable<string> zoznamSkupin = databaza.zoznamSkupin();
                IEnumerable<string> vysledokHladania = from s in zoznamSkupin where s.Contains(textBox_search.Text) select s; //LINQ

                foreach (string str in vysledokHladania)
                {
                    listBox_zoznam.Items.Add(str);
                }
            }
            else
            {
                reloadList();
            }
        }

    }
}
