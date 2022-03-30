using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void user1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAndFoundDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lostAndFoundDataSet.Found' table. You can move, or remove it, as needed.
            this.foundTableAdapter.Fill(this.lostAndFoundDataSet.Found);
            // TODO: This line of code loads data into the 'lostAndFoundDataSet.User1' table. You can move, or remove it, as needed.
            this.user1TableAdapter.Fill(this.lostAndFoundDataSet.User1);

        }
    }
}
