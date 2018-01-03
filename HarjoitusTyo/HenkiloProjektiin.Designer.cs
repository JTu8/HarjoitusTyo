namespace HarjoitusTyo
{
    partial class HenkiloProjektiin
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
            this.cbHenkilot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProjektit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbHenkilot = new System.Windows.Forms.TextBox();
            this.tbProjektit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarkasteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbHenkilot
            // 
            this.cbHenkilot.FormattingEnabled = true;
            this.cbHenkilot.Location = new System.Drawing.Point(57, 85);
            this.cbHenkilot.Name = "cbHenkilot";
            this.cbHenkilot.Size = new System.Drawing.Size(121, 21);
            this.cbHenkilot.TabIndex = 0;
            this.cbHenkilot.SelectedIndexChanged += new System.EventHandler(this.cbHenkilot_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Henkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lisää henkilö projektiin";
            // 
            // cbProjektit
            // 
            this.cbProjektit.FormattingEnabled = true;
            this.cbProjektit.Location = new System.Drawing.Point(318, 85);
            this.cbProjektit.Name = "cbProjektit";
            this.cbProjektit.Size = new System.Drawing.Size(121, 21);
            this.cbProjektit.TabIndex = 3;
            this.cbProjektit.SelectedIndexChanged += new System.EventHandler(this.cbProjektit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projektit";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(193, 150);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(101, 44);
            this.btnLisaa.TabIndex = 5;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbHenkilot
            // 
            this.tbHenkilot.Location = new System.Drawing.Point(57, 128);
            this.tbHenkilot.Name = "tbHenkilot";
            this.tbHenkilot.Size = new System.Drawing.Size(121, 20);
            this.tbHenkilot.TabIndex = 6;
            // 
            // tbProjektit
            // 
            this.tbProjektit.Location = new System.Drawing.Point(318, 128);
            this.tbProjektit.Name = "tbProjektit";
            this.tbProjektit.Size = new System.Drawing.Size(121, 20);
            this.tbProjektit.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarkasteleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarkasteleToolStripMenuItem
            // 
            this.tarkasteleToolStripMenuItem.Name = "tarkasteleToolStripMenuItem";
            this.tarkasteleToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tarkasteleToolStripMenuItem.Text = "Tarkastele";
            this.tarkasteleToolStripMenuItem.Click += new System.EventHandler(this.tarkasteleToolStripMenuItem_Click);
            // 
            // HenkiloProjektiin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 364);
            this.Controls.Add(this.tbProjektit);
            this.Controls.Add(this.tbHenkilot);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProjektit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHenkilot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HenkiloProjektiin";
            this.Text = "HenkiloProjektiin";
            this.Load += new System.EventHandler(this.HenkiloProjektiin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbHenkilot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProjektit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbHenkilot;
        private System.Windows.Forms.TextBox tbProjektit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarkasteleToolStripMenuItem;
    }
}