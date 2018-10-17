namespace Qualidade
{
    partial class NovoEstudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoEstudo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_CarregarModelo = new System.Windows.Forms.ComboBox();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.btn_GerarEstudo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_CarregarModelo);
            this.panel1.Controls.Add(this.lbl_Modelo);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 36);
            this.panel1.TabIndex = 0;
            // 
            // cmb_CarregarModelo
            // 
            this.cmb_CarregarModelo.FormattingEnabled = true;
            this.cmb_CarregarModelo.Location = new System.Drawing.Point(54, 4);
            this.cmb_CarregarModelo.Name = "cmb_CarregarModelo";
            this.cmb_CarregarModelo.Size = new System.Drawing.Size(143, 21);
            this.cmb_CarregarModelo.TabIndex = 1;
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(7, 11);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_Modelo.TabIndex = 0;
            this.lbl_Modelo.Text = "Modelo:";
            // 
            // btn_GerarEstudo
            // 
            this.btn_GerarEstudo.Location = new System.Drawing.Point(249, 12);
            this.btn_GerarEstudo.Name = "btn_GerarEstudo";
            this.btn_GerarEstudo.Size = new System.Drawing.Size(113, 36);
            this.btn_GerarEstudo.TabIndex = 1;
            this.btn_GerarEstudo.Text = "Gerar Estudo";
            this.btn_GerarEstudo.UseVisualStyleBackColor = true;
            this.btn_GerarEstudo.Click += new System.EventHandler(this.btn_GerarEstudo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 279);
            this.panel2.TabIndex = 2;
            // 
            // NovoEstudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_GerarEstudo);
            this.Controls.Add(this.panel1);
            this.Name = "NovoEstudo";
            this.Text = "NovoEstudo";
            this.Load += new System.EventHandler(this.NovoEstudo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_CarregarModelo;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Button btn_GerarEstudo;
        private System.Windows.Forms.Panel panel2;
    }
}