namespace FastFoodOrderSystem
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_chickenB = new System.Windows.Forms.RadioButton();
            this.rb_cheeseB = new System.Windows.Forms.RadioButton();
            this.rb_megaB = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_strawberry = new System.Windows.Forms.RadioButton();
            this.rb_blueberry = new System.Windows.Forms.RadioButton();
            this.rb_nutella = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.btn_addorder = new System.Windows.Forms.Button();
            this.btn_setprice = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_printorder = new System.Windows.Forms.Button();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fastFoodDataSet = new FastFoodOrderSystem.FastFoodDataSet();
            this.fastFoodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_total = new System.Windows.Forms.Label();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_large = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastFoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastFoodDataSetBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 887);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(411, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 47);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a Burger";
            // 
            // rb_chickenB
            // 
            this.rb_chickenB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_chickenB.Location = new System.Drawing.Point(318, 128);
            this.rb_chickenB.Name = "rb_chickenB";
            this.rb_chickenB.Size = new System.Drawing.Size(208, 46);
            this.rb_chickenB.TabIndex = 2;
            this.rb_chickenB.TabStop = true;
            this.rb_chickenB.Text = "Chicken Burger";
            this.rb_chickenB.UseVisualStyleBackColor = true;
            // 
            // rb_cheeseB
            // 
            this.rb_cheeseB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_cheeseB.Location = new System.Drawing.Point(318, 69);
            this.rb_cheeseB.Name = "rb_cheeseB";
            this.rb_cheeseB.Size = new System.Drawing.Size(208, 41);
            this.rb_cheeseB.TabIndex = 1;
            this.rb_cheeseB.TabStop = true;
            this.rb_cheeseB.Text = "Cheese Burger";
            this.rb_cheeseB.UseVisualStyleBackColor = true;
            // 
            // rb_megaB
            // 
            this.rb_megaB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_megaB.Location = new System.Drawing.Point(318, 11);
            this.rb_megaB.Name = "rb_megaB";
            this.rb_megaB.Size = new System.Drawing.Size(208, 45);
            this.rb_megaB.TabIndex = 0;
            this.rb_megaB.TabStop = true;
            this.rb_megaB.Text = "Mega Burger";
            this.rb_megaB.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LimeGreen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(738, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 47);
            this.panel6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(35, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select a Pancake";
            // 
            // rb_strawberry
            // 
            this.rb_strawberry.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_strawberry.Location = new System.Drawing.Point(645, 128);
            this.rb_strawberry.Name = "rb_strawberry";
            this.rb_strawberry.Size = new System.Drawing.Size(222, 46);
            this.rb_strawberry.TabIndex = 2;
            this.rb_strawberry.TabStop = true;
            this.rb_strawberry.Text = "Strawberry Pancake";
            this.rb_strawberry.UseVisualStyleBackColor = true;
            // 
            // rb_blueberry
            // 
            this.rb_blueberry.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_blueberry.Location = new System.Drawing.Point(645, 77);
            this.rb_blueberry.Name = "rb_blueberry";
            this.rb_blueberry.Size = new System.Drawing.Size(222, 33);
            this.rb_blueberry.TabIndex = 1;
            this.rb_blueberry.TabStop = true;
            this.rb_blueberry.Text = "Blueberry Pancake";
            this.rb_blueberry.UseVisualStyleBackColor = true;
            // 
            // rb_nutella
            // 
            this.rb_nutella.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_nutella.Location = new System.Drawing.Point(645, 16);
            this.rb_nutella.Name = "rb_nutella";
            this.rb_nutella.Size = new System.Drawing.Size(222, 35);
            this.rb_nutella.TabIndex = 0;
            this.rb_nutella.TabStop = true;
            this.rb_nutella.Text = "Nutella Pancake";
            this.rb_nutella.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(471, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // tb_quantity
            // 
            this.tb_quantity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tb_quantity.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_quantity.Location = new System.Drawing.Point(471, 368);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(153, 39);
            this.tb_quantity.TabIndex = 8;
            // 
            // btn_addorder
            // 
            this.btn_addorder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_addorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addorder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addorder.Location = new System.Drawing.Point(452, 443);
            this.btn_addorder.Name = "btn_addorder";
            this.btn_addorder.Size = new System.Drawing.Size(196, 38);
            this.btn_addorder.TabIndex = 9;
            this.btn_addorder.Text = "Add to order";
            this.btn_addorder.UseVisualStyleBackColor = false;
            this.btn_addorder.Click += new System.EventHandler(this.btn_addorder_Click);
            // 
            // btn_setprice
            // 
            this.btn_setprice.BackColor = System.Drawing.Color.Gold;
            this.btn_setprice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setprice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_setprice.Location = new System.Drawing.Point(108, 804);
            this.btn_setprice.Name = "btn_setprice";
            this.btn_setprice.Size = new System.Drawing.Size(198, 39);
            this.btn_setprice.TabIndex = 10;
            this.btn_setprice.Text = "Set the prices";
            this.btn_setprice.UseVisualStyleBackColor = false;
            this.btn_setprice.Click += new System.EventHandler(this.btn_setprice_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.LightBlue;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_logout.Location = new System.Drawing.Point(353, 804);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(143, 39);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_printorder
            // 
            this.btn_printorder.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_printorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printorder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_printorder.Location = new System.Drawing.Point(917, 791);
            this.btn_printorder.Name = "btn_printorder";
            this.btn_printorder.Size = new System.Drawing.Size(211, 52);
            this.btn_printorder.TabIndex = 12;
            this.btn_printorder.Text = "Print the order";
            this.btn_printorder.UseVisualStyleBackColor = false;
            this.btn_printorder.Click += new System.EventHandler(this.btn_printorder_Click);
            // 
            // dgv_order
            // 
            this.dgv_order.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_order.Location = new System.Drawing.Point(138, 516);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.RowHeadersWidth = 51;
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.Size = new System.Drawing.Size(902, 221);
            this.dgv_order.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // fastFoodDataSet
            // 
            this.fastFoodDataSet.DataSetName = "FastFoodDataSet";
            this.fastFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fastFoodDataSetBindingSource
            // 
            this.fastFoodDataSetBindingSource.DataSource = this.fastFoodDataSet;
            this.fastFoodDataSetBindingSource.Position = 0;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(912, 753);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(199, 23);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "SUM: \r\n";
            // 
            // rb_small
            // 
            this.rb_small.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_small.Location = new System.Drawing.Point(29, 21);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(104, 24);
            this.rb_small.TabIndex = 0;
            this.rb_small.Text = "Small";
            this.rb_small.UseVisualStyleBackColor = true;
            // 
            // rb_medium
            // 
            this.rb_medium.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_medium.Location = new System.Drawing.Point(29, 77);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(104, 24);
            this.rb_medium.TabIndex = 1;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            // 
            // rb_large
            // 
            this.rb_large.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb_large.Location = new System.Drawing.Point(29, 136);
            this.rb_large.Name = "rb_large";
            this.rb_large.Size = new System.Drawing.Size(104, 30);
            this.rb_large.TabIndex = 2;
            this.rb_large.Text = "Large";
            this.rb_large.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Pizza";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(107, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 47);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.rb_strawberry);
            this.panel7.Controls.Add(this.rb_blueberry);
            this.panel7.Controls.Add(this.rb_nutella);
            this.panel7.Controls.Add(this.rb_small);
            this.panel7.Controls.Add(this.rb_medium);
            this.panel7.Controls.Add(this.rb_large);
            this.panel7.Controls.Add(this.rb_chickenB);
            this.panel7.Controls.Add(this.rb_cheeseB);
            this.panel7.Controls.Add(this.rb_megaB);
            this.panel7.Location = new System.Drawing.Point(108, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(885, 188);
            this.panel7.TabIndex = 6;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 873);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_order);
            this.Controls.Add(this.btn_printorder);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_setprice);
            this.Controls.Add(this.btn_addorder);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastFoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastFoodDataSetBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_chickenB;
        private System.Windows.Forms.RadioButton rb_cheeseB;
        private System.Windows.Forms.RadioButton rb_megaB;
        private System.Windows.Forms.RadioButton rb_strawberry;
        private System.Windows.Forms.RadioButton rb_blueberry;
        private System.Windows.Forms.RadioButton rb_nutella;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Button btn_addorder;
        private System.Windows.Forms.Button btn_setprice;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_printorder;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.BindingSource fastFoodDataSetBindingSource;
        private FastFoodDataSet fastFoodDataSet;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_large;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}