namespace Dicer_roller
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
            this.count = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Button();
            this.diceCount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Die3 = new System.Windows.Forms.TextBox();
            this.Die2 = new System.Windows.Forms.TextBox();
            this.Die1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(73, 51);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(59, 13);
            this.count.TabIndex = 0;
            this.count.Text = "Dice count";
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(78, 199);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(87, 51);
            this.Roll.TabIndex = 1;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Button1_Click);
            // 
            // diceCount
            // 
            this.diceCount.Location = new System.Drawing.Point(78, 169);
            this.diceCount.Name = "diceCount";
            this.diceCount.Size = new System.Drawing.Size(83, 20);
            this.diceCount.TabIndex = 2;
            this.diceCount.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Die3
            // 
            this.Die3.Location = new System.Drawing.Point(78, 143);
            this.Die3.Name = "Die3";
            this.Die3.Size = new System.Drawing.Size(83, 20);
            this.Die3.TabIndex = 4;
            this.Die3.Text = "Die 3";
            // 
            // Die2
            // 
            this.Die2.Location = new System.Drawing.Point(78, 117);
            this.Die2.Name = "Die2";
            this.Die2.Size = new System.Drawing.Size(83, 20);
            this.Die2.TabIndex = 5;
            this.Die2.Text = "Die 2";
            // 
            // Die1
            // 
            this.Die1.Location = new System.Drawing.Point(78, 91);
            this.Die1.Name = "Die1";
            this.Die1.Size = new System.Drawing.Size(83, 20);
            this.Die1.TabIndex = 6;
            this.Die1.Text = "Die 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Die1);
            this.Controls.Add(this.Die2);
            this.Controls.Add(this.Die3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.diceCount);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.TextBox diceCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Die3;
        private System.Windows.Forms.TextBox Die2;
        private System.Windows.Forms.TextBox Die1;
    }
}

