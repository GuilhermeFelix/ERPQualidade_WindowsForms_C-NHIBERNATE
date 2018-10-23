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
            this.configestudosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configcapabilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configdiretoriorelatorioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteristicaChaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinaFabricaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaDeMediçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capabilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDeAmostragemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAmostragemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarEstudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configestudosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // configestudosToolStripMenuItem
            // 
            this.configestudosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configcapabilidadeToolStripMenuItem});
            this.configestudosToolStripMenuItem.Name = "configestudosToolStripMenuItem";
            this.configestudosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.configestudosToolStripMenuItem.Text = "Estudos";
            this.configestudosToolStripMenuItem.Click += new System.EventHandler(this.diretóriosToolStripMenuItem_Click);
            // 
            // configcapabilidadeToolStripMenuItem
            // 
            this.configcapabilidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configdiretoriorelatorioToolStripMenuItem1,
            this.caracteristicaChaveToolStripMenuItem,
            this.maquinaFabricaçãoToolStripMenuItem,
            this.ferramentaDeMediçãoToolStripMenuItem});
            this.configcapabilidadeToolStripMenuItem.Name = "configcapabilidadeToolStripMenuItem";
            this.configcapabilidadeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.configcapabilidadeToolStripMenuItem.Text = "Capabilidade";
            // 
            // configdiretoriorelatorioToolStripMenuItem1
            // 
            this.configdiretoriorelatorioToolStripMenuItem1.Name = "configdiretoriorelatorioToolStripMenuItem1";
            this.configdiretoriorelatorioToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.configdiretoriorelatorioToolStripMenuItem1.Text = "Diretorio dos Relatorios";
            this.configdiretoriorelatorioToolStripMenuItem1.Click += new System.EventHandler(this.capabilidadeToolStripMenuItem1_Click);
            // 
            // caracteristicaChaveToolStripMenuItem
            // 
            this.caracteristicaChaveToolStripMenuItem.Name = "caracteristicaChaveToolStripMenuItem";
            this.caracteristicaChaveToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.caracteristicaChaveToolStripMenuItem.Text = "Caracteristica Chave";
            // 
            // maquinaFabricaçãoToolStripMenuItem
            // 
            this.maquinaFabricaçãoToolStripMenuItem.Name = "maquinaFabricaçãoToolStripMenuItem";
            this.maquinaFabricaçãoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.maquinaFabricaçãoToolStripMenuItem.Text = "Maquina Fabricação";
            // 
            // ferramentaDeMediçãoToolStripMenuItem
            // 
            this.ferramentaDeMediçãoToolStripMenuItem.Name = "ferramentaDeMediçãoToolStripMenuItem";
            this.ferramentaDeMediçãoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ferramentaDeMediçãoToolStripMenuItem.Text = "Ferramenta de Medição";
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
            this.adicionarAmostragemToolStripMenuItem,
            this.gerarEstudoToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
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
            // gerarEstudoToolStripMenuItem
            // 
            this.gerarEstudoToolStripMenuItem.Name = "gerarEstudoToolStripMenuItem";
            this.gerarEstudoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gerarEstudoToolStripMenuItem.Text = "Gerar Estudo";
            this.gerarEstudoToolStripMenuItem.Click += new System.EventHandler(this.gerarEstudoToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorio1ToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // relatorio1ToolStripMenuItem
            // 
            this.relatorio1ToolStripMenuItem.Name = "relatorio1ToolStripMenuItem";
            this.relatorio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatorio1ToolStripMenuItem.Text = "Relatorio 1";
            this.relatorio1ToolStripMenuItem.Click += new System.EventHandler(this.relatorio1ToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem gerarEstudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configestudosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configcapabilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configdiretoriorelatorioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caracteristicaChaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinaFabricaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaDeMediçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorio1ToolStripMenuItem;
    }
}

