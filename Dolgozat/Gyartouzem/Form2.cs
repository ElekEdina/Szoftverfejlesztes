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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void MegrendelesFejlecBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.megrendelesFejlecBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.attekintoDataset);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attekintoDataset.Tetelsorok' table. You can move, or remove it, as needed.
            this.tetelsorokTableAdapter.Fill(this.attekintoDataset.Tetelsorok);
            // TODO: This line of code loads data into the 'attekintoDataset.MegrendelesFejlec' table. You can move, or remove it, as needed.
            this.megrendelesFejlecTableAdapter.Fill(this.attekintoDataset.MegrendelesFejlec);

        }
    }
}
