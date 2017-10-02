namespace secWeb
{
    partial class Regform
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
            this.btnRegistre = new System.Windows.Forms.Button();
            this.labMdp = new System.Windows.Forms.Label();
            this.labUtil = new System.Windows.Forms.Label();
            this.texMdp = new System.Windows.Forms.TextBox();
            this.textUtil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistre
            // 
            this.btnRegistre.Location = new System.Drawing.Point(211, 129);
            this.btnRegistre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistre.Name = "btnRegistre";
            this.btnRegistre.Size = new System.Drawing.Size(100, 28);
            this.btnRegistre.TabIndex = 11;
            this.btnRegistre.Text = "OK";
            this.btnRegistre.UseVisualStyleBackColor = true;
            this.btnRegistre.Click += new System.EventHandler(this.btnRegistre_Click);
            // 
            // labMdp
            // 
            this.labMdp.AutoSize = true;
            this.labMdp.Location = new System.Drawing.Point(48, 97);
            this.labMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMdp.Name = "labMdp";
            this.labMdp.Size = new System.Drawing.Size(38, 17);
            this.labMdp.TabIndex = 9;
            this.labMdp.Text = "MDP";
            this.labMdp.Click += new System.EventHandler(this.labMdp_Click);
            // 
            // labUtil
            // 
            this.labUtil.AutoSize = true;
            this.labUtil.Location = new System.Drawing.Point(12, 58);
            this.labUtil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUtil.Name = "labUtil";
            this.labUtil.Size = new System.Drawing.Size(110, 17);
            this.labUtil.TabIndex = 8;
            this.labUtil.Text = "Nom d\'utlisateur";
            // 
            // texMdp
            // 
            this.texMdp.Location = new System.Drawing.Point(129, 97);
            this.texMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texMdp.Name = "texMdp";
            this.texMdp.Size = new System.Drawing.Size(284, 22);
            this.texMdp.TabIndex = 7;
            // 
            // textUtil
            // 
            this.textUtil.Location = new System.Drawing.Point(129, 54);
            this.textUtil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUtil.Name = "textUtil";
            this.textUtil.Size = new System.Drawing.Size(284, 22);
            this.textUtil.TabIndex = 6;
            // 
            // Regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 176);
            this.Controls.Add(this.btnRegistre);
            this.Controls.Add(this.labMdp);
            this.Controls.Add(this.labUtil);
            this.Controls.Add(this.texMdp);
            this.Controls.Add(this.textUtil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Regform";
            this.Text = "Regform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistre;
        private System.Windows.Forms.Label labMdp;
        private System.Windows.Forms.Label labUtil;
        private System.Windows.Forms.TextBox texMdp;
        private System.Windows.Forms.TextBox textUtil;
    }
}