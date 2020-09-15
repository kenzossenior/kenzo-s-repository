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
            this.Roll = new System.Windows.Forms.Button();
            this.pbx_board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_board)).BeginInit();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(45, 418);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(400, 51);
            this.Roll.TabIndex = 1;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pbx_board
            // 
            this.pbx_board.Location = new System.Drawing.Point(45, 12);
            this.pbx_board.Name = "pbx_board";
            this.pbx_board.Size = new System.Drawing.Size(400, 400);
            this.pbx_board.TabIndex = 2;
            this.pbx_board.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 471);
            this.Controls.Add(this.pbx_board);
            this.Controls.Add(this.Roll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.PictureBox pbx_board;
    }
}

