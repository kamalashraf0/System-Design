using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SD_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               
        }

        private void foundBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.foundBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAndFoundDataSet);
        }

        private void user1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lostAndFoundDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lostAndFoundDataSet.Found' table. You can move, or remove it, as needed.
            this.foundTableAdapter.Fill(this.lostAndFoundDataSet.Found);
            // TODO: This line of code loads data into the 'lostAndFoundDataSet.User1' table. You can move, or remove it, as needed.
            this.user1TableAdapter.Fill(this.lostAndFoundDataSet.User1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            addressTextBox.PasswordChar = '*';
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
