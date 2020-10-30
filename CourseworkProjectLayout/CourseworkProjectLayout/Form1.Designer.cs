namespace CourseworkProjectLayout
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.OxygenRemaining = new System.Windows.Forms.ProgressBar();
            this.OxygenLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.South_btn = new System.Windows.Forms.Button();
            this.west_btn = new System.Windows.Forms.Button();
            this.East_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 0;
            // 
            // inventory_btn
            // 
            this.inventory_btn.Location = new System.Drawing.Point(571, 324);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(149, 47);
            this.inventory_btn.TabIndex = 1;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = true;
            this.inventory_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OxygenRemaining
            // 
            this.OxygenRemaining.Location = new System.Drawing.Point(490, 403);
            this.OxygenRemaining.Name = "OxygenRemaining";
            this.OxygenRemaining.Size = new System.Drawing.Size(314, 61);
            this.OxygenRemaining.TabIndex = 3;
            this.OxygenRemaining.Value = 100;
            // 
            // OxygenLabel
            // 
            this.OxygenLabel.AutoSize = true;
            this.OxygenLabel.BackColor = System.Drawing.Color.Transparent;
            this.OxygenLabel.ForeColor = System.Drawing.Color.Black;
            this.OxygenLabel.Location = new System.Drawing.Point(578, 425);
            this.OxygenLabel.Name = "OxygenLabel";
            this.OxygenLabel.Size = new System.Drawing.Size(142, 20);
            this.OxygenLabel.TabIndex = 5;
            this.OxygenLabel.Text = "Oxygen Remaining";
            this.OxygenLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(490, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 286);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(304, 345);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(94, 26);
            this.enter_btn.TabIndex = 7;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "North ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // South_btn
            // 
            this.South_btn.Location = new System.Drawing.Point(136, 469);
            this.South_btn.Name = "South_btn";
            this.South_btn.Size = new System.Drawing.Size(63, 39);
            this.South_btn.TabIndex = 14;
            this.South_btn.Text = "South";
            this.South_btn.UseVisualStyleBackColor = true;
            // 
            // west_btn
            // 
            this.west_btn.Location = new System.Drawing.Point(52, 425);
            this.west_btn.Name = "west_btn";
            this.west_btn.Size = new System.Drawing.Size(63, 39);
            this.west_btn.TabIndex = 15;
            this.west_btn.Text = "West";
            this.west_btn.UseVisualStyleBackColor = true;
            this.west_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // East_btn
            // 
            this.East_btn.Location = new System.Drawing.Point(215, 425);
            this.East_btn.Name = "East_btn";
            this.East_btn.Size = new System.Drawing.Size(63, 39);
            this.East_btn.TabIndex = 16;
            this.East_btn.Text = "East";
            this.East_btn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(398, 313);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 520);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.East_btn);
            this.Controls.Add(this.west_btn);
            this.Controls.Add(this.South_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OxygenLabel);
            this.Controls.Add(this.OxygenRemaining);
            this.Controls.Add(this.inventory_btn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.ProgressBar OxygenRemaining;
        private System.Windows.Forms.Label OxygenLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button South_btn;
        private System.Windows.Forms.Button west_btn;
        private System.Windows.Forms.Button East_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

