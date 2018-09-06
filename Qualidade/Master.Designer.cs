namespace Qualidade
{
    partial class Master
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capabilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDeAmostragemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAmostragemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capabilidadeToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cadastroToolStripMenuItem.Text = "Estudos";
            // 
            // capabilidadeToolStripMenuItem
            // 
            this.capabilidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelosDeAmostragemToolStripMenuItem,
            this.adicionarAmostragemToolStripMenuItem});
            this.capabilidadeToolStripMenuItem.Name = "capabilidadeToolStripMenuItem";
            this.capabilidadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capabilidadeToolStripMenuItem.Text = "Capabilidade";
            // 
            // modelosDeAmostragemToolStripMenuItem
            // 
            this.modelosDeAmostragemToolStripMenuItem.Name = "modelosDeAmostragemToolStripMenuItem";
            this.modelosDeAmostragemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.modelosDeAmostragemToolStripMenuItem.Text = "Modelos de Amostragem";
            this.modelosDeAmostragemToolStripMenuItem.Click += new System.EventHandler(this.modelosDeAmostragemToolStripMenuItem_Click);
            // 
            // adicionarAmostragemToolStripMenuItem
            // 
            this.adicionarAmostragemToolStripMenuItem.Name = "adicionarAmostragemToolStripMenuItem";
            this.adicionarAmostragemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.adicionarAmostragemToolStripMenuItem.Text = "Gerenciar Amostragem";
            this.adicionarAmostragemToolStripMenuItem.Click += new System.EventHandler(this.adicionarAmostragemToolStripMenuItem_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 666);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1015, 705);
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP Qualidade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capabilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosDeAmostragemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAmostragemToolStripMenuItem;
    }
}

