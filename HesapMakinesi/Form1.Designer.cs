namespace HesapMakinesi
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDisplay.Location = new System.Drawing.Point(13, 13);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(449, 45);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnEsittir
            // 
            this.btnEsittir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsittir.Location = new System.Drawing.Point(357, 343);
            this.btnEsittir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(107, 62);
            this.btnEsittir.TabIndex = 0;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = false;
            this.btnEsittir.Click += new System.EventHandler(this.btnIslem);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(357, 274);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(107, 62);
            this.button18.TabIndex = 38;
            this.button18.Text = "÷";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.btnIslem);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(357, 205);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(107, 62);
            this.button17.TabIndex = 37;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnIslem);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(357, 136);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(107, 62);
            this.button16.TabIndex = 36;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnIslem);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(357, 67);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(107, 62);
            this.button15.TabIndex = 35;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnIslem);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(242, 67);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 62);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(128, 67);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(107, 62);
            this.btnC.TabIndex = 33;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCE.Location = new System.Drawing.Point(13, 67);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(107, 62);
            this.btnCE.TabIndex = 32;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(242, 343);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 62);
            this.button11.TabIndex = 31;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(13, 343);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(221, 62);
            this.button12.TabIndex = 30;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(13, 274);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 62);
            this.button7.TabIndex = 29;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(128, 274);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 62);
            this.button8.TabIndex = 28;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(242, 274);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 62);
            this.button9.TabIndex = 27;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(13, 205);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 62);
            this.button4.TabIndex = 26;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(128, 205);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 62);
            this.button5.TabIndex = 25;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(242, 205);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 62);
            this.button6.TabIndex = 24;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(13, 136);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 62);
            this.button3.TabIndex = 23;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(128, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 62);
            this.button2.TabIndex = 22;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnNumPad);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(242, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 62);
            this.button1.TabIndex = 20;
            this.button1.Text = "9";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnNumPad);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEsittir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 416);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KlavyedenBasilan);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

