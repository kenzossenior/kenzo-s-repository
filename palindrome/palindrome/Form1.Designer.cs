namespace palindrome
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
            this.Guess_btn = new System.Windows.Forms.Button();
            this.enterGuess_txt = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.higherOrLower_lbl = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guess_btn
            // 
            this.Guess_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Guess_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Guess_btn.Location = new System.Drawing.Point(493, 187);
            this.Guess_btn.Name = "Guess_btn";
            this.Guess_btn.Size = new System.Drawing.Size(239, 25);
            this.Guess_btn.TabIndex = 0;
            this.Guess_btn.Text = "Guess";
            this.Guess_btn.UseVisualStyleBackColor = false;
            this.Guess_btn.Click += new System.EventHandler(this.Guess_btn_Click);
            // 
            // enterGuess_txt
            // 
            this.enterGuess_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterGuess_txt.Location = new System.Drawing.Point(270, 187);
            this.enterGuess_txt.Name = "enterGuess_txt";
            this.enterGuess_txt.Size = new System.Drawing.Size(217, 25);
            this.enterGuess_txt.TabIndex = 2;
            this.enterGuess_txt.TextChanged += new System.EventHandler(this.enterGuess_txt_TextChanged);
            this.enterGuess_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterGuess_txt_KeyDown);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(54, 48);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(558, 32);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "I\'m thinking of number between 1 and 100";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1.Location = new System.Drawing.Point(87, 242);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(68, 24);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Tries:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // higherOrLower_lbl
            // 
            this.higherOrLower_lbl.AutoSize = true;
            this.higherOrLower_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.higherOrLower_lbl.Location = new System.Drawing.Point(87, 302);
            this.higherOrLower_lbl.Name = "higherOrLower_lbl";
            this.higherOrLower_lbl.Size = new System.Drawing.Size(0, 24);
            this.higherOrLower_lbl.TabIndex = 5;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(86, 181);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(158, 28);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Enter guess:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.higherOrLower_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.enterGuess_txt);
            this.Controls.Add(this.Guess_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guess_btn;
        private System.Windows.Forms.TextBox enterGuess_txt;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label higherOrLower_lbl;
        private System.Windows.Forms.Label lbl3;
    }
}

