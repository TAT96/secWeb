namespace secWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textUtil = new System.Windows.Forms.TextBox();
            this.texMdp = new System.Windows.Forms.TextBox();
            this.labUtil = new System.Windows.Forms.Label();
            this.labMdp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUtil
            // 
            this.textUtil.Location = new System.Drawing.Point(133, 50);
            this.textUtil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUtil.Name = "textUtil";
            this.textUtil.Size = new System.Drawing.Size(345, 22);
            this.textUtil.TabIndex = 0;
            // 
            // texMdp
            // 
            this.texMdp.Location = new System.Drawing.Point(133, 95);
            this.texMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texMdp.Name = "texMdp";
            this.texMdp.Size = new System.Drawing.Size(345, 22);
            this.texMdp.TabIndex = 1;
            this.texMdp.TextChanged += new System.EventHandler(this.texMdp_TextChanged);
            // 
            // labUtil
            // 
            this.labUtil.AutoSize = true;
            this.labUtil.Location = new System.Drawing.Point(16, 54);
            this.labUtil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUtil.Name = "labUtil";
            this.labUtil.Size = new System.Drawing.Size(110, 17);
            this.labUtil.TabIndex = 2;
            this.labUtil.Text = "Nom d\'utlisateur";
            // 
            // labMdp
            // 
            this.labMdp.AutoSize = true;
            this.labMdp.Location = new System.Drawing.Point(33, 98);
            this.labMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMdp.Name = "labMdp";
            this.labMdp.Size = new System.Drawing.Size(72, 17);
            this.labMdp.TabIndex = 3;
            this.labMdp.Text = "Passworld";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLogin);
            // 
            // btnRegistre
            // 
            this.btnRegistre.Location = new System.Drawing.Point(184, 156);
            this.btnRegistre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistre.Name = "btnRegistre";
            this.btnRegistre.Size = new System.Drawing.Size(100, 28);
            this.btnRegistre.TabIndex = 5;
            this.btnRegistre.Text = "Inscription";
            this.btnRegistre.UseVisualStyleBackColor = true;
            this.btnRegistre.Click += new System.EventHandler(this.btnRegistre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 199);
            this.Controls.Add(this.btnRegistre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labMdp);
            this.Controls.Add(this.labUtil);
            this.Controls.Add(this.texMdp);
            this.Controls.Add(this.textUtil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUtil;
        private System.Windows.Forms.TextBox texMdp;
        private System.Windows.Forms.Label labUtil;
        private System.Windows.Forms.Label labMdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistre;
    }
}

