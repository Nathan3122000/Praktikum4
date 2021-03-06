using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
            textBoxNama.Text = textBoxNama.SelectedText.ToString();
        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {
            textBoxAlamat.Text = textBoxAlamat.SelectedText.ToString();
        }

        private void textBoxTelp_TextChanged(object sender, EventArgs e)
        {
            textBoxTelp.Text = textBoxTelp.SelectedText.ToString();
        }
    }
}
