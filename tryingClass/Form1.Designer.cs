namespace tryingClass
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxw1 = new System.Windows.Forms.TextBox();
            this.textBoxw2 = new System.Windows.Forms.TextBox();
            this.textBoxw3 = new System.Windows.Forms.TextBox();
            this.textBoxw4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 180);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxw1
            // 
            this.textBoxw1.Location = new System.Drawing.Point(187, 14);
            this.textBoxw1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxw1.Name = "textBoxw1";
            this.textBoxw1.Size = new System.Drawing.Size(109, 34);
            this.textBoxw1.TabIndex = 2;
            this.textBoxw1.Text = "0";
            this.textBoxw1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxw2
            // 
            this.textBoxw2.Location = new System.Drawing.Point(187, 58);
            this.textBoxw2.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxw2.Name = "textBoxw2";
            this.textBoxw2.Size = new System.Drawing.Size(109, 34);
            this.textBoxw2.TabIndex = 3;
            this.textBoxw2.Text = "0";
            this.textBoxw2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxw3
            // 
            this.textBoxw3.Location = new System.Drawing.Point(187, 102);
            this.textBoxw3.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxw3.Name = "textBoxw3";
            this.textBoxw3.Size = new System.Drawing.Size(109, 34);
            this.textBoxw3.TabIndex = 4;
            this.textBoxw3.Text = "0";
            this.textBoxw3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxw4
            // 
            this.textBoxw4.Location = new System.Drawing.Point(187, 146);
            this.textBoxw4.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxw4.Name = "textBoxw4";
            this.textBoxw4.Size = new System.Drawing.Size(109, 34);
            this.textBoxw4.TabIndex = 5;
            this.textBoxw4.Text = "0";
            this.textBoxw4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxw4);
            this.Controls.Add(this.textBoxw3);
            this.Controls.Add(this.textBoxw2);
            this.Controls.Add(this.textBoxw1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxw1;
        private System.Windows.Forms.TextBox textBoxw2;
        private System.Windows.Forms.TextBox textBoxw3;
        private System.Windows.Forms.TextBox textBoxw4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}

