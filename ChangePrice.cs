using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodOrderSystem
{
    public partial class ChangePrice : Form
    {
        Function Con;
        public ChangePrice()
        {
            InitializeComponent();
            Con = new Function();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {
                
                int Pr = Convert.ToInt32(tb_price.Text);
                
                if (cb_food.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cb_food.SelectedIndex == 0)
                {
                    Key = "Small Pizza";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query,Pr,Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(cb_food.SelectedIndex == 1)
                {
                    Key = "Medium Pizza";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if( cb_food.SelectedIndex == 2)
                {
                    Key = "Large Pizza";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_food.SelectedIndex == 3)
                {
                    Key = "Mega Burger";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_food.SelectedIndex == 4)
                {
                    Key = "Cheese Burger";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_food.SelectedIndex == 5)
                {
                    Key = "Chicken Burger";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_food.SelectedIndex == 6)
                {
                    Key = "Nutella Pancake";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_food.SelectedIndex == 7)
                {
                    Key = "Blueberry Pancake";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_food.SelectedIndex == 8)
                {
                    Key = "Strawberry Pancake";
                    string Query = "UPDATE Food SET Price={0} where Item='{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price is updated", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cb_food.SelectedIndex = -1;
                tb_price.Clear();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
