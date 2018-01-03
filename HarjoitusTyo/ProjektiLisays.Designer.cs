namespace HarjoitusTyo
{
    partial class ProjektiLisays
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProjektiNimi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.btnLisaaProjekti = new System.Windows.Forms.Button();
            this.btnTarkasteleProjekteja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lisävalikkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektinTehtävätToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projektin lisäys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projektin nimi";
            // 
            // tbProjektiNimi
            // 
            this.tbProjektiNimi.Location = new System.Drawing.Point(152, 79);
            this.tbProjektiNimi.Name = "tbProjektiNimi";
            this.tbProjektiNimi.Size = new System.Drawing.Size(100, 20);
            this.tbProjektiNimi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kuvaus";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(152, 119);
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(100, 20);
            this.tbKuvaus.TabIndex = 8;
            // 
            // btnLisaaProjekti
            // 
            this.btnLisaaProjekti.Location = new System.Drawing.Point(37, 332);
            this.btnLisaaProjekti.Name = "btnLisaaProjekti";
            this.btnLisaaProjekti.Size = new System.Drawing.Size(179, 49);
            this.btnLisaaProjekti.TabIndex = 9;
            this.btnLisaaProjekti.Text = "Lisää projekti";
            this.btnLisaaProjekti.UseVisualStyleBackColor = true;
            this.btnLisaaProjekti.Click += new System.EventHandler(this.btnLisaaProjekti_Click);
            // 
            // btnTarkasteleProjekteja
            // 
            this.btnTarkasteleProjekteja.Location = new System.Drawing.Point(289, 332);
            this.btnTarkasteleProjekteja.Name = "btnTarkasteleProjekteja";
            this.btnTarkasteleProjekteja.Size = new System.Drawing.Size(173, 49);
            this.btnTarkasteleProjekteja.TabIndex = 10;
            this.btnTarkasteleProjekteja.Text = "Tarkastele projekteja";
            this.btnTarkasteleProjekteja.UseVisualStyleBackColor = true;
            this.btnTarkasteleProjekteja.Click += new System.EventHandler(this.btnTarkasteleProjekteja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aloituspäivämäärä";
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "";
            this.selectDate.Location = new System.Drawing.Point(152, 158);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(200, 20);
            this.selectDate.TabIndex = 13;
            this.selectDate.Value = new System.DateTime(2017, 12, 20, 0, 0, 0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisävalikkoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lisävalikkoToolStripMenuItem
            // 
            this.lisävalikkoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektinTehtävätToolStripMenuItem});
            this.lisävalikkoToolStripMenuItem.Name = "lisävalikkoToolStripMenuItem";
            this.lisävalikkoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.lisävalikkoToolStripMenuItem.Text = "Lisävalikko";
            // 
            // projektinTehtävätToolStripMenuItem
            // 
            this.projektinTehtävätToolStripMenuItem.Name = "projektinTehtävätToolStripMenuItem";
            this.projektinTehtävätToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.projektinTehtävätToolStripMenuItem.Text = "Projektin tehtävät";
            this.projektinTehtävätToolStripMenuItem.Click += new System.EventHandler(this.projektinTehtävätToolStripMenuItem_Click);
            // 
            // ProjektiLisays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 446);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTarkasteleProjekteja);
            this.Controls.Add(this.btnLisaaProjekti);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProjektiNimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjektiLisays";
            this.Text = "Projektin lisäys";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProjektiNimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Button btnLisaaProjekti;
        private System.Windows.Forms.Button btnTarkasteleProjekteja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lisävalikkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektinTehtävätToolStripMenuItem;
    }
}