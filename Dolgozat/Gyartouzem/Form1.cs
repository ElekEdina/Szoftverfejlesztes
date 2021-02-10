using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyartouzem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MegrendelesFejlecBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.megrendelesFejlecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hataridosDataset);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hataridosDataset.MegrendelesFejlec' table. You can move, or remove it, as needed.
            this.megrendelesFejlecTableAdapter.Fill(this.hataridosDataset.MegrendelesFejlec);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 attekinto = new Form2();
            attekinto.Show();
        }
    }
}
