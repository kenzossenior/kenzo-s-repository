namespace L3_spaceInvader
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
            this.pbx_Spacee = new System.Windows.Forms.PictureBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Spacee)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Spacee
            // 
            this.pbx_Spacee.Location = new System.Drawing.Point(47, 39);
            this.pbx_Spacee.Name = "pbx_Spacee";
            this.pbx_Spacee.Size = new System.Drawing.Size(400, 400);
            this.pbx_Spacee.TabIndex = 0;
            this.pbx_Spacee.TabStop = false;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(149, 454);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(189, 53);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Toggle Alien";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(503, 522);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.pbx_Spacee);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Spacee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Spacee;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Timer timer1;
    }
}

