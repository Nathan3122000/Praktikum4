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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable infopribadi = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            infopribadi.Columns.Add("Nama");
            infopribadi.Columns.Add("Alamat");
            infopribadi.Columns.Add("Telp");
        }

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            infopribadi.Rows.Add(textBoxNama.Text, textBoxAlamat.Text, textBoxTelp.Text);
        }
    }
}
