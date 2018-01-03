namespace HarjoitusTyo
{
    partial class Aloitus
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnLisaaHenkilo = new System.Windows.Forms.Button();
            this.btnLisaaProjekti = new System.Windows.Forms.Button();
            this.btnLisaaTehtava = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yritys ABC:n projektihallinta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLisaaHenkilo
            // 
            this.btnLisaaHenkilo.Location = new System.Drawing.Point(74, 115);
            this.btnLisaaHenkilo.Name = "btnLisaaHenkilo";
            this.btnLisaaHenkilo.Size = new System.Drawing.Size(130, 45);
            this.btnLisaaHenkilo.TabIndex = 4;
            this.btnLisaaHenkilo.Text = "Lisää henkilö";
            this.btnLisaaHenkilo.UseVisualStyleBackColor = true;
            this.btnLisaaHenkilo.Click += new System.EventHandler(this.btnLisaaHenkilo_Click);
            // 
            // btnLisaaProjekti
            // 
            this.btnLisaaProjekti.Location = new System.Drawing.Point(339, 115);
            this.btnLisaaProjekti.Name = "btnLisaaProjekti";
            this.btnLisaaProjekti.Size = new System.Drawing.Size(125, 45);
            this.btnLisaaProjekti.TabIndex = 5;
            this.btnLisaaProjekti.Text = "Lisää projekti";
            this.btnLisaaProjekti.UseVisualStyleBackColor = true;
            this.btnLisaaProjekti.Click += new System.EventHandler(this.btnLisaaProjekti_Click);
            // 
            // btnLisaaTehtava
            // 
            this.btnLisaaTehtava.Location = new System.Drawing.Point(74, 190);
            this.btnLisaaTehtava.Name = "btnLisaaTehtava";
            this.btnLisaaTehtava.Size = new System.Drawing.Size(130, 45);
            this.btnLisaaTehtava.TabIndex = 6;
            this.btnLisaaTehtava.Text = "Lisää tehtävä";
            this.btnLisaaTehtava.UseVisualStyleBackColor = true;
            this.btnLisaaTehtava.Click += new System.EventHandler(this.btnLisaaTehtava_Click);
            // 
            // Aloitus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 419);
            this.Controls.Add(this.btnLisaaTehtava);
            this.Controls.Add(this.btnLisaaProjekti);
            this.Controls.Add(this.btnLisaaHenkilo);
            this.Controls.Add(this.label1);
            this.Name = "Aloitus";
            this.Text = "Aloitus";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLisaaHenkilo;
        private System.Windows.Forms.Button btnLisaaProjekti;
        private System.Windows.Forms.Button btnLisaaTehtava;
    }
}

