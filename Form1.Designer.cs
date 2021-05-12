namespace SIMPLE_CALCULATOR_BY_SAIM_MASOOD_SHAIKH_STUDENT_ID_024_19_113019
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FALCONS = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblScreen = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FALCONS);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblScreen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAIM MASOOD SHAIKH";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FALCONS
            // 
            this.FALCONS.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FALCONS.Location = new System.Drawing.Point(300, 332);
            this.FALCONS.Name = "FALCONS";
            this.FALCONS.Size = new System.Drawing.Size(83, 75);
            this.FALCONS.TabIndex = 17;
            this.FALCONS.Text = "\"SAIM MASOOD SHAIKH\" (CLICK HERE PLEASE)";
            this.FALCONS.UseVisualStyleBackColor = true;
            this.FALCONS.Click += new System.EventHandler(this.FALCONS_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Fuchsia;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(293, 171);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 118);
            this.button16.TabIndex = 16;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.HotPink;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(206, 355);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 40);
            this.button15.TabIndex = 15;
            this.button15.Text = "%";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.getOperator);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.HotPink;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(206, 289);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 40);
            this.button14.TabIndex = 14;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.getOperator);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.HotPink;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(206, 229);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 40);
            this.button13.TabIndex = 13;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.getOperator);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.HotPink;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(206, 167);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(59, 40);
            this.button12.TabIndex = 12;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.getOperator);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.HotPink;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(206, 101);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 40);
            this.button11.TabIndex = 11;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.getOperator);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.GreenYellow;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(91, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 45);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.getDigits);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.GreenYellow;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(19, 350);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 45);
            this.button10.TabIndex = 9;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.getDigits);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.GreenYellow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(91, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.getDigits);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.GreenYellow;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(19, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.getDigits);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.GreenYellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(91, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.getDigits);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.GreenYellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(19, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.getDigits);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GreenYellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(91, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.getDigits);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GreenYellow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(19, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.getDigits);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.getDigits);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.getDigits);
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.Color.White;
            this.lblScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(19, 38);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(365, 35);
            this.lblScreen.TabIndex = 0;
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScreen.Click += new System.EventHandler(this.lblScreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SIMPLE CALCULATOR BY SAIM MASOOD SHAIKH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button FALCONS;
    }
}

