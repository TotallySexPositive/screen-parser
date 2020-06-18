namespace ScreenParser
{
    partial class Viewer
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salesgrid = new System.Windows.Forms.DataGridView();
            this.snap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sold_per_day = new System.Windows.Forms.Label();
            this.median_price = new System.Windows.Forms.Label();
            this.max_price = new System.Windows.Forms.Label();
            this.min_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Item";
            // 
            // salesgrid
            // 
            this.salesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesgrid.Location = new System.Drawing.Point(209, 76);
            this.salesgrid.Name = "salesgrid";
            this.salesgrid.Size = new System.Drawing.Size(579, 362);
            this.salesgrid.TabIndex = 7;
            // 
            // snap
            // 
            this.snap.Location = new System.Drawing.Point(209, 22);
            this.snap.Name = "snap";
            this.snap.Size = new System.Drawing.Size(75, 23);
            this.snap.TabIndex = 8;
            this.snap.Text = "Snap!";
            this.snap.UseVisualStyleBackColor = true;
            this.snap.Click += new System.EventHandler(this.snap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select What Item To Snap For";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Min Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Max Price: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sold_per_day);
            this.groupBox1.Controls.Add(this.median_price);
            this.groupBox1.Controls.Add(this.max_price);
            this.groupBox1.Controls.Add(this.min_price);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 156);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // sold_per_day
            // 
            this.sold_per_day.AutoSize = true;
            this.sold_per_day.Location = new System.Drawing.Point(87, 97);
            this.sold_per_day.Name = "sold_per_day";
            this.sold_per_day.Size = new System.Drawing.Size(22, 13);
            this.sold_per_day.TabIndex = 18;
            this.sold_per_day.Text = "0.0";
            this.sold_per_day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // median_price
            // 
            this.median_price.AutoSize = true;
            this.median_price.Location = new System.Drawing.Point(87, 70);
            this.median_price.Name = "median_price";
            this.median_price.Size = new System.Drawing.Size(22, 13);
            this.median_price.TabIndex = 17;
            this.median_price.Text = "0.0";
            this.median_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // max_price
            // 
            this.max_price.AutoSize = true;
            this.max_price.Location = new System.Drawing.Point(87, 43);
            this.max_price.Name = "max_price";
            this.max_price.Size = new System.Drawing.Size(22, 13);
            this.max_price.TabIndex = 16;
            this.max_price.Text = "0.0";
            this.max_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // min_price
            // 
            this.min_price.AutoSize = true;
            this.min_price.Location = new System.Drawing.Point(87, 16);
            this.min_price.Name = "min_price";
            this.min_price.Size = new System.Drawing.Size(22, 13);
            this.min_price.TabIndex = 15;
            this.min_price.Text = "0.0";
            this.min_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Median Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Avg Sold:";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.snap);
            this.Controls.Add(this.salesgrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Viewer";
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.salesgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView salesgrid;
        private System.Windows.Forms.Button snap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sold_per_day;
        private System.Windows.Forms.Label median_price;
        private System.Windows.Forms.Label max_price;
        private System.Windows.Forms.Label min_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}