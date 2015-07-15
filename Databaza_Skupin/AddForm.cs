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
    public partial class AddForm : Form
    {
        public string nazov
        {
            get { return textBox_nazov.Text; }
        }

        public int rok_vzniku
        {
            get { return Convert.ToInt32(numericUpDown_rok.Value); }
        }

        public AddForm()
        {
            InitializeComponent();
            numericUpDown_rok.Maximum = System.DateTime.Now.Year;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
