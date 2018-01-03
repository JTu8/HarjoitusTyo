namespace HarjoitusTyo
{
    partial class TehtavaProjektiin
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
            this.cbTehtavat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProjektit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.tbTehtavat = new System.Windows.Forms.TextBox();
            this.tbProjektit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lisää projektiin tehtäviä";
            // 
            // cbTehtavat
            // 
            this.cbTehtavat.FormattingEnabled = true;
            this.cbTehtavat.Location = new System.Drawing.Point(44, 86);
            this.cbTehtavat.Name = "cbTehtavat";
            this.cbTehtavat.Size = new System.Drawing.Size(121, 21);
            this.cbTehtavat.TabIndex = 1;
            this.cbTehtavat.SelectedIndexChanged += new System.EventHandler(this.cbTehtavat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tehtävät";
            // 
            // cbProjektit
            // 
            this.cbProjektit.FormattingEnabled = true;
            this.cbProjektit.Location = new System.Drawing.Point(340, 86);
            this.cbProjektit.Name = "cbProjektit";
            this.cbProjektit.Size = new System.Drawing.Size(121, 21);
            this.cbProjektit.TabIndex = 3;
            this.cbProjektit.SelectedIndexChanged += new System.EventHandler(this.cbProjektit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Projektit";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(200, 161);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(96, 45);
            this.btnLisaa.TabIndex = 5;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // tbTehtavat
            // 
            this.tbTehtavat.Location = new System.Drawing.Point(44, 126);
            this.tbTehtavat.Name = "tbTehtavat";
            this.tbTehtavat.Size = new System.Drawing.Size(121, 20);
            this.tbTehtavat.TabIndex = 6;
            // 
            // tbProjektit
            // 
            this.tbProjektit.Location = new System.Drawing.Point(340, 126);
            this.tbProjektit.Name = "tbProjektit";
            this.tbProjektit.Size = new System.Drawing.Size(121, 20);
            this.tbProjektit.TabIndex = 7;
            // 
            // TehtavaProjektiin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 353);
            this.Controls.Add(this.tbProjektit);
            this.Controls.Add(this.tbTehtavat);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProjektit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTehtavat);
            this.Controls.Add(this.label1);
            this.Name = "TehtavaProjektiin";
            this.Text = "TehtavaProjektiin";
            this.Load += new System.EventHandler(this.TehtavaProjektiin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTehtavat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProjektit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.TextBox tbTehtavat;
        private System.Windows.Forms.TextBox tbProjektit;
    }
}