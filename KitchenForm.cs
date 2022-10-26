using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmeraldRestaurant
{
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
        }
        Kitchen  kitchen = new Kitchen();
        bool verif()
        {
            if(txtBoxID.Text.Trim()==""||txtBoxName.Text.Trim()==""||txtBoxQuantity.Text.Trim()=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridViewListIngredient.DataSource = kitchen.showIngredient();
            txtBoxID.Clear();
            txtBoxName.Clear();
            txtBoxQuantity.Clear();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string id = txtBoxID.Text.Trim();
            string name = txtBoxName.Text.Trim();
            
            if (!verif())
            {
                MessageBox.Show("Please fill in all the information!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (kitchen.checkID(id))
            {
                MessageBox.Show("Ingredient ID does not exist!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int quantity = Convert.ToInt32(txtBoxQuantity.Text.Trim());
                    if (kitchen.updateIngredient(id, name, quantity))
                    {
                        MessageBox.Show("Successfully edited ingredients!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Editing ingredients failed!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string id = txtBoxID.Text.Trim();
            string name = txtBoxName.Text.Trim();
            
            if (!verif())
            {
                MessageBox.Show("Please fill in all the information!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!kitchen.checkID(id))
            {
                MessageBox.Show("Ingredient ID Existed!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!kitchen.checkName(name))
            {
                MessageBox.Show("Duplicate ingredients!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int quantity = Convert.ToInt32(txtBoxQuantity.Text.Trim());
                    if (kitchen.insertIngredient(id, name, quantity))
                    {
                        MessageBox.Show("Successfully added new ingredients!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Adding new ingredients failed!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string id = txtBoxID.Text.Trim();
            if (txtBoxID.Text.Trim()=="")
            {
                MessageBox.Show("Please fill in all the information!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (kitchen.checkID(id))
            {
                MessageBox.Show("Ingredient ID does not exist!!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (kitchen.deleteIngredient(id))
                    {
                        MessageBox.Show("Successfully deleted ingredients!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Deleting ingredients failed!", "Manage Ingredient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewListIngredient_Click(object sender, EventArgs e)
        {
            txtBoxID.Text = dataGridViewListIngredient.CurrentRow.Cells[0].Value.ToString().Trim();
            txtBoxName.Text = dataGridViewListIngredient.CurrentRow.Cells[1].Value.ToString().Trim();
            txtBoxQuantity.Text = dataGridViewListIngredient.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
