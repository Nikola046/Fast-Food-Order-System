using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodOrderSystem
{
    public partial class Menu : Form
    {
        Function Con;
        public Menu()
        {
            Con=new Function();
            InitializeComponent();
        }

        private void btn_setprice_Click(object sender, EventArgs e)
        {
            ChangePrice changeprice=new ChangePrice();
            this.Hide();
            changeprice.ShowDialog();
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
            
        }
        int Key;
        int Price = 0;
        private void GetPrice(int Key)
        {
            string Item="";
            if (Key == 1)
            {
                Item = "Small"; 
            }
            else if(Key == 2)
            {
                Item = "Medium";
            }
            else if(Key == 3)
            {
                Item = "Large";
            }
            else if (Key == 4)
            {
                Item = "Mega Burger";
            }
            else if( Key == 5)
            {
                Item = "Cheese Burger";
            }
            else if (Key == 6)
            {
                Item = "Chicken Burger";
            }
            else if (Key == 7)
            {
                Item = "Nutella Pancake";
            }
            else if (Key == 8)
            {
                Item = "Blueberry Pancake";
            }
            else if (Key == 9)
            {
                Item = "Strawberry Pancake";
            }

            string Query = "SELECT * FROM Food WHERE Item='{0}'";
            Query=String.Format(Query, Item);
            Price = Convert.ToInt32(Con.GetData(Query).Rows[0][1].ToString() );
             
        }

        int n = 0;
        string Foods;

        int GrdTotal = 0;
        private void btn_addorder_Click(object sender, EventArgs e)
        {
            if (rb_small.Checked == true)
            {
                Key = 1;
                Foods = "Small";
            } 
            else if(rb_medium.Checked == true)
            {
                Key = 2;
                Foods = "Medium";
            }
            else if(rb_large.Checked == true)
            {
                Key=3;
                Foods = "Large";
            }
            else if(rb_megaB.Checked == true)
            {
                Key = 4;
                Foods = "Mega Burger";
            }
            else if(rb_cheeseB.Checked == true)
            {
                Key = 5;
                Foods = "Cheese Burger";
            }
            else if(rb_chickenB.Checked == true)
            {
                Key = 6;
                Foods = "Chicken Burger";
            }
            else if(rb_nutella.Checked == true)
            {
                Key = 7;
                Foods = "Nutella Pancake";
            }
            else if (rb_blueberry.Checked == true)
            {
                Key = 8;
                Foods = "Blueberry Pancake";
            }
            else if (rb_strawberry.Checked == true)
            {
                Key = 9;
                Foods = "Strawberry Pancake";
            }

            GetPrice(Key);

            int Quantity = Convert.ToInt32(tb_quantity.Text);

            int Total = Quantity*Price;
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgv_order);
            row.Cells[0].Value = n+1;
            row.Cells[1].Value = Foods;
            row.Cells[2].Value = Price;
            row.Cells[3].Value = tb_quantity.Text;
            row.Cells[4].Value = Total;

            dgv_order.Rows.Add(row);
            n++;

            tb_quantity.Clear();

            
            GrdTotal = GrdTotal + Total;
            lbl_total.Text = "SUM: $" +GrdTotal; 
        }

        

        private void btn_printorder_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 320, 600);


            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        int prodId, prodPrice, prodQuantity, Sum, Pos = 70;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The bill wil be printed","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string prodName;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ORDER", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(120));

            e.Graphics.DrawString("ID  PRODUCT  PRICE  QUANTITY  TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(20, 30));

            foreach (DataGridViewRow row in dgv_order.Rows)
            {
                prodId = Convert.ToInt32(row.Cells["Column1"].Value);
                prodName = "" + row.Cells["Column2"].Value;
                prodPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodQuantity = Convert.ToInt32(row.Cells["Column4"].Value);
                Sum = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + prodId, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(20, Pos));
                
                e.Graphics.DrawString("" + prodName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(32, Pos));
                
                e.Graphics.DrawString("" + prodPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(130, Pos));
                
                e.Graphics.DrawString("" + prodQuantity, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, Pos));
                
                e.Graphics.DrawString("" + Sum, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, Pos));
                
                Pos = Pos + 20;
            }

            e.Graphics.DrawString("TOTAL:$ " + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(165, Pos+50 ));
            e.Graphics.DrawString("************  FAST FOOD   *************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.LimeGreen, new Point(10, Pos+120 ));

            dgv_order.Rows.Clear();
            dgv_order.Refresh();
            Pos = 100;
            GrdTotal = 0;
            n = 0;
        }

        
    }
}
