namespace Qualidade
{
    partial class ConfiguracaoDiretorioEstudoCapabilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracaoDiretorioEstudoCapabilidade));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Caminho = new System.Windows.Forms.TextBox();
            this.lbl_SalvarEstudoCapabilidade = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Caminho);
            this.panel1.Controls.Add(this.lbl_SalvarEstudoCapabilidade);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho:";
            // 
            // txt_Caminho
            // 
            this.txt_Caminho.Location = new System.Drawing.Point(147, 41);
            this.txt_Caminho.Name = "txt_Caminho";
            this.txt_Caminho.Size = new System.Drawing.Size(235, 20);
            this.txt_Caminho.TabIndex = 1;
            this.txt_Caminho.TextChanged += new System.EventHandler(this.txt_Caminho_TextChanged);
            // 
            // lbl_SalvarEstudoCapabilidade
            // 
            this.lbl_SalvarEstudoCapabilidade.AutoSize = true;
            this.lbl_SalvarEstudoCapabilidade.Location = new System.Drawing.Point(4, 4);
            this.lbl_SalvarEstudoCapabilidade.Name = "lbl_SalvarEstudoCapabilidade";
            this.lbl_SalvarEstudoCapabilidade.Size = new System.Drawing.Size(137, 13);
            this.lbl_SalvarEstudoCapabilidade.TabIndex = 0;
            this.lbl_SalvarEstudoCapabilidade.Text = "Salvar Estudo Capabilidade";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(351, 98);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // ConfiguracaoDiretorioEstudoCapabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 132);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.panel1);
            this.Name = "ConfiguracaoDiretorioEstudoCapabilidade";
            this.Text = "Configuracao de Diretorio";
            this.Load += new System.EventHandler(this.ConfiguracaoDiretorioEstudoCapabilidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Caminho;
        private System.Windows.Forms.Label lbl_SalvarEstudoCapabilidade;
        private System.Windows.Forms.Button btn_Salvar;
    }
}