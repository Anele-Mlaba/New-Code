using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mla_218063413
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblClothingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblClothingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TblClothing' table. You can move, or remove it, as needed.
            this.tblClothingTableAdapter.Fill(this.dataSet1.TblClothing);
            textBox2.Text = "Men";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tblClothingBindingSource.MoveLast();
            
            int keys = int.Parse(clothId.Text)+1;
            clothId.Text = keys+"";
            MessageBox.Show(clothId.Text);
            this.tblClothingBindingSource.AddNew();
            this.tblClothingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void clothId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataTable1TableAdapter.Fill(dataSet1.DataTable1, textBox2.Text);
        }
    }
}
