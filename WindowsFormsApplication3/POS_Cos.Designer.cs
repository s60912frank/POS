namespace WindowsFormsApplication3
{
    partial class POS_Cos
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.meals = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prepage = new System.Windows.Forms.Button();
            this.npage = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.meals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // meals
            // 
            this.meals.Controls.Add(this.label1);
            this.meals.Controls.Add(this.prepage);
            this.meals.Controls.Add(this.npage);
            this.meals.Controls.Add(this.button9);
            this.meals.Controls.Add(this.button8);
            this.meals.Controls.Add(this.button7);
            this.meals.Controls.Add(this.button10);
            this.meals.Controls.Add(this.button11);
            this.meals.Controls.Add(this.button12);
            this.meals.Controls.Add(this.button13);
            this.meals.Controls.Add(this.button14);
            this.meals.Controls.Add(this.button1);
            this.meals.Controls.Add(this.button2);
            this.meals.Controls.Add(this.button3);
            this.meals.Controls.Add(this.button4);
            this.meals.Controls.Add(this.button5);
            this.meals.Controls.Add(this.button15);
            this.meals.Controls.Add(this.button6);
            this.meals.Location = new System.Drawing.Point(12, 12);
            this.meals.Name = "meals";
            this.meals.Size = new System.Drawing.Size(383, 397);
            this.meals.TabIndex = 0;
            this.meals.TabStop = false;
            this.meals.Text = "Meals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // prepage
            // 
            this.prepage.Enabled = false;
            this.prepage.Location = new System.Drawing.Point(167, 368);
            this.prepage.Name = "prepage";
            this.prepage.Size = new System.Drawing.Size(100, 23);
            this.prepage.TabIndex = 10;
            this.prepage.Text = "Previous Page";
            this.prepage.UseVisualStyleBackColor = true;
            this.prepage.Click += new System.EventHandler(this.prepage_Click);
            // 
            // npage
            // 
            this.npage.Location = new System.Drawing.Point(273, 368);
            this.npage.Name = "npage";
            this.npage.Size = new System.Drawing.Size(100, 23);
            this.npage.TabIndex = 9;
            this.npage.Text = "Next Page";
            this.npage.UseVisualStyleBackColor = true;
            this.npage.Click += new System.EventHandler(this.npage_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(258, 233);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 100);
            this.button9.TabIndex = 8;
            this.button9.Tag = "9";
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(132, 233);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 100);
            this.button8.TabIndex = 7;
            this.button8.Tag = "8";
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 233);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 100);
            this.button7.TabIndex = 6;
            this.button7.Tag = "7";
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 100);
            this.button10.TabIndex = 11;
            this.button10.Tag = "10";
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.AccessibleDescription = "";
            this.button11.Location = new System.Drawing.Point(132, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 100);
            this.button11.TabIndex = 12;
            this.button11.Tag = "11";
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(258, 21);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 100);
            this.button12.TabIndex = 13;
            this.button12.Tag = "12";
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 127);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 100);
            this.button13.TabIndex = 14;
            this.button13.Tag = "13";
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(132, 127);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 100);
            this.button14.TabIndex = 15;
            this.button14.Tag = "14";
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 100);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 100);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 100);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 100);
            this.button4.TabIndex = 3;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 100);
            this.button5.TabIndex = 4;
            this.button5.Tag = "5";
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(258, 127);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 100);
            this.button15.TabIndex = 16;
            this.button15.Tag = "15";
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(258, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 100);
            this.button6.TabIndex = 5;
            this.button6.Tag = "6";
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.uprice,
            this.qty,
            this.stotal});
            this.dgv.Location = new System.Drawing.Point(402, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(443, 333);
            this.dgv.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // uprice
            // 
            this.uprice.HeaderText = "Unit Price";
            this.uprice.Name = "uprice";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quentity";
            this.qty.Name = "qty";
            // 
            // stotal
            // 
            this.stotal.HeaderText = "Subtotal";
            this.stotal.Name = "stotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // POS_Cos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.meals);
            this.Name = "POS_Cos";
            this.Text = "POS-Costomer Side";
            this.meals.ResumeLayout(false);
            this.meals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox meals;
        private System.Windows.Forms.Button prepage;
        private System.Windows.Forms.Button npage;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotal;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

