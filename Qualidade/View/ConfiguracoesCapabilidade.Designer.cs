namespace Qualidade.View
{
    partial class ConfiguracoesCapabilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracoesCapabilidade));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RemoverCaracteristica = new System.Windows.Forms.Button();
            this.btn_SalvarCaracteristicaChave = new System.Windows.Forms.Button();
            this.txt_CaracteristicaChave = new System.Windows.Forms.TextBox();
            this.lst_CaracteristicaChave = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SalvarMaquina = new System.Windows.Forms.Button();
            this.btn_RemoverMaquina = new System.Windows.Forms.Button();
            this.txt_Maquina = new System.Windows.Forms.TextBox();
            this.lst_MaquinaFabricacao = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_RemoverFerramenta = new System.Windows.Forms.Button();
            this.btn_SalvarFerramenta = new System.Windows.Forms.Button();
            this.txt_Ferramenta = new System.Windows.Forms.TextBox();
            this.lst_FerramentadeMedicao = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_RemoverCaracteristica);
            this.panel1.Controls.Add(this.btn_SalvarCaracteristicaChave);
            this.panel1.Controls.Add(this.txt_CaracteristicaChave);
            this.panel1.Controls.Add(this.lst_CaracteristicaChave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 125);
            this.panel1.TabIndex = 0;
            // 
            // btn_RemoverCaracteristica
            // 
            this.btn_RemoverCaracteristica.Location = new System.Drawing.Point(91, 54);
            this.btn_RemoverCaracteristica.Name = "btn_RemoverCaracteristica";
            this.btn_RemoverCaracteristica.Size = new System.Drawing.Size(61, 25);
            this.btn_RemoverCaracteristica.TabIndex = 4;
            this.btn_RemoverCaracteristica.Text = "Remover";
            this.btn_RemoverCaracteristica.UseVisualStyleBackColor = true;
            this.btn_RemoverCaracteristica.Click += new System.EventHandler(this.btn_RemoverCaracteristica_Click);
            // 
            // btn_SalvarCaracteristicaChave
            // 
            this.btn_SalvarCaracteristicaChave.Location = new System.Drawing.Point(91, 85);
            this.btn_SalvarCaracteristicaChave.Name = "btn_SalvarCaracteristicaChave";
            this.btn_SalvarCaracteristicaChave.Size = new System.Drawing.Size(61, 25);
            this.btn_SalvarCaracteristicaChave.TabIndex = 3;
            this.btn_SalvarCaracteristicaChave.Text = "Salvar";
            this.btn_SalvarCaracteristicaChave.UseVisualStyleBackColor = true;
            this.btn_SalvarCaracteristicaChave.Click += new System.EventHandler(this.btn_SalvarCaracteristicaChave_Click);
            // 
            // txt_CaracteristicaChave
            // 
            this.txt_CaracteristicaChave.Location = new System.Drawing.Point(15, 28);
            this.txt_CaracteristicaChave.Name = "txt_CaracteristicaChave";
            this.txt_CaracteristicaChave.Size = new System.Drawing.Size(137, 20);
            this.txt_CaracteristicaChave.TabIndex = 2;
            this.txt_CaracteristicaChave.TextChanged += new System.EventHandler(this.txt_CaracteristicaChave_TextChanged);
            // 
            // lst_CaracteristicaChave
            // 
            this.lst_CaracteristicaChave.FormattingEnabled = true;
            this.lst_CaracteristicaChave.Location = new System.Drawing.Point(158, 25);
            this.lst_CaracteristicaChave.Name = "lst_CaracteristicaChave";
            this.lst_CaracteristicaChave.Size = new System.Drawing.Size(178, 95);
            this.lst_CaracteristicaChave.TabIndex = 1;
            this.lst_CaracteristicaChave.SelectedIndexChanged += new System.EventHandler(this.lst_CaracteristicaChave_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caracteristica Chave:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_SalvarMaquina);
            this.panel2.Controls.Add(this.btn_RemoverMaquina);
            this.panel2.Controls.Add(this.txt_Maquina);
            this.panel2.Controls.Add(this.lst_MaquinaFabricacao);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(35, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 121);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_SalvarMaquina
            // 
            this.btn_SalvarMaquina.Location = new System.Drawing.Point(91, 79);
            this.btn_SalvarMaquina.Name = "btn_SalvarMaquina";
            this.btn_SalvarMaquina.Size = new System.Drawing.Size(61, 25);
            this.btn_SalvarMaquina.TabIndex = 5;
            this.btn_SalvarMaquina.Text = "Salvar";
            this.btn_SalvarMaquina.UseVisualStyleBackColor = true;
            this.btn_SalvarMaquina.Click += new System.EventHandler(this.btn_SalvarMaquina_Click);
            // 
            // btn_RemoverMaquina
            // 
            this.btn_RemoverMaquina.Location = new System.Drawing.Point(91, 48);
            this.btn_RemoverMaquina.Name = "btn_RemoverMaquina";
            this.btn_RemoverMaquina.Size = new System.Drawing.Size(61, 25);
            this.btn_RemoverMaquina.TabIndex = 5;
            this.btn_RemoverMaquina.Text = "Remover";
            this.btn_RemoverMaquina.UseVisualStyleBackColor = true;
            this.btn_RemoverMaquina.Click += new System.EventHandler(this.btn_RemoverMaquina_Click);
            // 
            // txt_Maquina
            // 
            this.txt_Maquina.Location = new System.Drawing.Point(15, 22);
            this.txt_Maquina.Name = "txt_Maquina";
            this.txt_Maquina.Size = new System.Drawing.Size(137, 20);
            this.txt_Maquina.TabIndex = 3;
            this.txt_Maquina.TextChanged += new System.EventHandler(this.txt_Maquina_TextChanged);
            // 
            // lst_MaquinaFabricacao
            // 
            this.lst_MaquinaFabricacao.FormattingEnabled = true;
            this.lst_MaquinaFabricacao.Location = new System.Drawing.Point(158, 19);
            this.lst_MaquinaFabricacao.Name = "lst_MaquinaFabricacao";
            this.lst_MaquinaFabricacao.Size = new System.Drawing.Size(178, 95);
            this.lst_MaquinaFabricacao.TabIndex = 2;
            this.lst_MaquinaFabricacao.SelectedIndexChanged += new System.EventHandler(this.lst_MaquinaFabricacao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maquina de Fabricação:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btn_RemoverFerramenta);
            this.panel3.Controls.Add(this.btn_SalvarFerramenta);
            this.panel3.Controls.Add(this.txt_Ferramenta);
            this.panel3.Controls.Add(this.lst_FerramentadeMedicao);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(35, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 119);
            this.panel3.TabIndex = 1;
            // 
            // btn_RemoverFerramenta
            // 
            this.btn_RemoverFerramenta.Location = new System.Drawing.Point(91, 57);
            this.btn_RemoverFerramenta.Name = "btn_RemoverFerramenta";
            this.btn_RemoverFerramenta.Size = new System.Drawing.Size(61, 25);
            this.btn_RemoverFerramenta.TabIndex = 7;
            this.btn_RemoverFerramenta.Text = "Remover";
            this.btn_RemoverFerramenta.UseVisualStyleBackColor = true;
            this.btn_RemoverFerramenta.Click += new System.EventHandler(this.btn_RemoverFerramenta_Click);
            // 
            // btn_SalvarFerramenta
            // 
            this.btn_SalvarFerramenta.Location = new System.Drawing.Point(91, 88);
            this.btn_SalvarFerramenta.Name = "btn_SalvarFerramenta";
            this.btn_SalvarFerramenta.Size = new System.Drawing.Size(61, 25);
            this.btn_SalvarFerramenta.TabIndex = 6;
            this.btn_SalvarFerramenta.Text = "Salvar";
            this.btn_SalvarFerramenta.UseVisualStyleBackColor = true;
            this.btn_SalvarFerramenta.Click += new System.EventHandler(this.btn_SalvarFerramenta_Click);
            // 
            // txt_Ferramenta
            // 
            this.txt_Ferramenta.Location = new System.Drawing.Point(15, 22);
            this.txt_Ferramenta.Name = "txt_Ferramenta";
            this.txt_Ferramenta.Size = new System.Drawing.Size(137, 20);
            this.txt_Ferramenta.TabIndex = 4;
            // 
            // lst_FerramentadeMedicao
            // 
            this.lst_FerramentadeMedicao.FormattingEnabled = true;
            this.lst_FerramentadeMedicao.Location = new System.Drawing.Point(158, 19);
            this.lst_FerramentadeMedicao.Name = "lst_FerramentadeMedicao";
            this.lst_FerramentadeMedicao.Size = new System.Drawing.Size(178, 95);
            this.lst_FerramentadeMedicao.TabIndex = 3;
            this.lst_FerramentadeMedicao.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ferramenta de Medição:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConfiguracoesCapabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 395);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfiguracoesCapabilidade";
            this.Text = "ConfiguracoesCapabilidade";
            this.Load += new System.EventHandler(this.ConfiguracoesCapabilidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lst_CaracteristicaChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lst_MaquinaFabricacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lst_FerramentadeMedicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SalvarCaracteristicaChave;
        private System.Windows.Forms.TextBox txt_CaracteristicaChave;
        private System.Windows.Forms.TextBox txt_Maquina;
        private System.Windows.Forms.TextBox txt_Ferramenta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_RemoverCaracteristica;
        private System.Windows.Forms.Button btn_SalvarMaquina;
        private System.Windows.Forms.Button btn_RemoverMaquina;
        private System.Windows.Forms.Button btn_SalvarFerramenta;
        private System.Windows.Forms.Button btn_RemoverFerramenta;
    }
}