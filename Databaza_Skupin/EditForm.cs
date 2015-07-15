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
    public partial class EditForm : Form
    {
        public HudSkupina hudSkupina
        {
            get { return this._hudSkupina; }
        }

        private HudSkupina _hudSkupina;
        public EditForm(HudSkupina skupina)
        {
            InitializeComponent();
            numericUpDown_rok.Maximum = System.DateTime.Now.Year;
            textBox_nazov.Text = skupina.Nazov;
            numericUpDown_rok.Value = skupina.Rok_vzniku;

            _hudSkupina = skupina;

            foreach (string str in _hudSkupina.getDiskografia())
            {
                listBox_albums.Items.Add(str);
            }
            
            this.Text = skupina.Nazov;

        }

        private void button_save_Click(object sender, EventArgs e) //Vsetky udaje sa ulozia az po potvrdeni
        {
            _hudSkupina.Nazov = textBox_nazov.Text;
            _hudSkupina.Rok_vzniku = Convert.ToInt32(numericUpDown_rok.Value);
            
            //Mazem albumy a pridavam ich nanovo
            _hudSkupina.clearAlbums();
            foreach (string str in listBox_albums.Items)
            {
                _hudSkupina.addAlbum(str);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_albumAdd_Click(object sender, EventArgs e)
        {
            if (textBox_albumName.Text != "")
            {
                listBox_albums.Items.Add(textBox_albumName.Text);
                textBox_albumName.Clear();
            }
        }

        private void button_albumRemove_Click(object sender, EventArgs e)
        {
            if (listBox_albums.SelectedIndex >= 0) //ak je nieco selectnute
            {
                listBox_albums.Items.RemoveAt(listBox_albums.SelectedIndex);
            }
        }
    }
}
