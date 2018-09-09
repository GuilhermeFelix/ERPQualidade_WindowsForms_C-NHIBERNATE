namespace Qualidade
{
    partial class ModeloAmostragem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeloAmostragem));
            this.lst_Modelos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CaracteristicasChave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtt_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtt_Fim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_MaquinaFabricacao = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_FerramentaCaracteristica5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_FerramentaCaracteristica4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_FerramentaCaracteristica3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_FerramentaCaracteristica2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_FerramentaCaracteristica1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Lscr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Lscx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Licx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Lse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Lie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_EspecificacaoNominal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IdModelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Modelos
            // 
            this.lst_Modelos.FormattingEnabled = true;
            this.lst_Modelos.Items.AddRange(new object[] {
            "Novo Modelo"});
            this.lst_Modelos.Location = new System.Drawing.Point(14, 26);
            this.lst_Modelos.Name = "lst_Modelos";
            this.lst_Modelos.Size = new System.Drawing.Size(237, 264);
            this.lst_Modelos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caracteristica Chave:";
            // 
            // cmb_CaracteristicasChave
            // 
            this.cmb_CaracteristicasChave.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_CaracteristicasChave.FormattingEnabled = true;
            this.cmb_CaracteristicasChave.Items.AddRange(new object[] {
            "Diâmetro",
            "Dimensão",
            "Raio",
            "Batimento"});
            this.cmb_CaracteristicasChave.Location = new System.Drawing.Point(260, 79);
            this.cmb_CaracteristicasChave.Name = "cmb_CaracteristicasChave";
            this.cmb_CaracteristicasChave.Size = new System.Drawing.Size(236, 21);
            this.cmb_CaracteristicasChave.TabIndex = 4;
            this.cmb_CaracteristicasChave.Tag = "Usuário deve escolher qual é o tipo de caracteristica chave que predomina na peça" +
    " de estudo.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtt_Inicio
            // 
            this.dtt_Inicio.Location = new System.Drawing.Point(260, 25);
            this.dtt_Inicio.Name = "dtt_Inicio";
            this.dtt_Inicio.Size = new System.Drawing.Size(236, 20);
            this.dtt_Inicio.TabIndex = 6;
            this.dtt_Inicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtt_Fim
            // 
            this.dtt_Fim.Location = new System.Drawing.Point(510, 25);
            this.dtt_Fim.Name = "dtt_Fim";
            this.dtt_Fim.Size = new System.Drawing.Size(236, 20);
            this.dtt_Fim.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maquina para Fabricação:";
            // 
            // cmb_MaquinaFabricacao
            // 
            this.cmb_MaquinaFabricacao.FormattingEnabled = true;
            this.cmb_MaquinaFabricacao.Items.AddRange(new object[] {
            "Furadeira"});
            this.cmb_MaquinaFabricacao.Location = new System.Drawing.Point(510, 79);
            this.cmb_MaquinaFabricacao.Name = "cmb_MaquinaFabricacao";
            this.cmb_MaquinaFabricacao.Size = new System.Drawing.Size(236, 21);
            this.cmb_MaquinaFabricacao.TabIndex = 10;
            this.cmb_MaquinaFabricacao.Tag = "Usuário deve escolher qual é o tipo de caracteristica chave que predomina na peça" +
    " de estudo.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lst_Modelos);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_IdModelo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtt_Fim);
            this.panel1.Controls.Add(this.cmb_MaquinaFabricacao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtt_Inicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_CaracteristicasChave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(131, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 517);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txt_FerramentaCaracteristica5);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txt_FerramentaCaracteristica4);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txt_FerramentaCaracteristica3);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txt_FerramentaCaracteristica2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txt_FerramentaCaracteristica1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(485, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 181);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 28);
            this.panel4.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Ferramenta de Medição";
            // 
            // txt_FerramentaCaracteristica5
            // 
            this.txt_FerramentaCaracteristica5.Location = new System.Drawing.Point(107, 155);
            this.txt_FerramentaCaracteristica5.Name = "txt_FerramentaCaracteristica5";
            this.txt_FerramentaCaracteristica5.Size = new System.Drawing.Size(100, 20);
            this.txt_FerramentaCaracteristica5.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Caracteristica 1:";
            // 
            // txt_FerramentaCaracteristica4
            // 
            this.txt_FerramentaCaracteristica4.Location = new System.Drawing.Point(107, 127);
            this.txt_FerramentaCaracteristica4.Name = "txt_FerramentaCaracteristica4";
            this.txt_FerramentaCaracteristica4.Size = new System.Drawing.Size(100, 20);
            this.txt_FerramentaCaracteristica4.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Caracteristica 2:";
            // 
            // txt_FerramentaCaracteristica3
            // 
            this.txt_FerramentaCaracteristica3.Location = new System.Drawing.Point(107, 98);
            this.txt_FerramentaCaracteristica3.Name = "txt_FerramentaCaracteristica3";
            this.txt_FerramentaCaracteristica3.Size = new System.Drawing.Size(100, 20);
            this.txt_FerramentaCaracteristica3.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Caracteristica 3:";
            // 
            // txt_FerramentaCaracteristica2
            // 
            this.txt_FerramentaCaracteristica2.Location = new System.Drawing.Point(107, 67);
            this.txt_FerramentaCaracteristica2.Name = "txt_FerramentaCaracteristica2";
            this.txt_FerramentaCaracteristica2.Size = new System.Drawing.Size(100, 20);
            this.txt_FerramentaCaracteristica2.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Caracteristica 4:";
            // 
            // txt_FerramentaCaracteristica1
            // 
            this.txt_FerramentaCaracteristica1.Location = new System.Drawing.Point(107, 36);
            this.txt_FerramentaCaracteristica1.Name = "txt_FerramentaCaracteristica1";
            this.txt_FerramentaCaracteristica1.Size = new System.Drawing.Size(100, 20);
            this.txt_FerramentaCaracteristica1.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Caracteristica 5:";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(678, 491);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 12;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txt_Lscr);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_Lscx);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_Licx);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_Lse);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_Lie);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_EspecificacaoNominal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(292, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 153);
            this.panel2.TabIndex = 13;
            // 
            // txt_Lscr
            // 
            this.txt_Lscr.Location = new System.Drawing.Point(228, 121);
            this.txt_Lscr.Name = "txt_Lscr";
            this.txt_Lscr.Size = new System.Drawing.Size(183, 20);
            this.txt_Lscr.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Praticado LSCr:";
            // 
            // txt_Lscx
            // 
            this.txt_Lscx.Location = new System.Drawing.Point(228, 74);
            this.txt_Lscx.Name = "txt_Lscx";
            this.txt_Lscx.Size = new System.Drawing.Size(183, 20);
            this.txt_Lscx.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Praticado LSCx:";
            // 
            // txt_Licx
            // 
            this.txt_Licx.Location = new System.Drawing.Point(228, 26);
            this.txt_Licx.Name = "txt_Licx";
            this.txt_Licx.Size = new System.Drawing.Size(183, 20);
            this.txt_Licx.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Praticado LICx:";
            // 
            // txt_Lse
            // 
            this.txt_Lse.Location = new System.Drawing.Point(6, 121);
            this.txt_Lse.Name = "txt_Lse";
            this.txt_Lse.Size = new System.Drawing.Size(183, 20);
            this.txt_Lse.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "LSE:";
            // 
            // txt_Lie
            // 
            this.txt_Lie.Location = new System.Drawing.Point(6, 74);
            this.txt_Lie.Name = "txt_Lie";
            this.txt_Lie.Size = new System.Drawing.Size(183, 20);
            this.txt_Lie.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "LIE:";
            // 
            // txt_EspecificacaoNominal
            // 
            this.txt_EspecificacaoNominal.Location = new System.Drawing.Point(6, 26);
            this.txt_EspecificacaoNominal.Name = "txt_EspecificacaoNominal";
            this.txt_EspecificacaoNominal.Size = new System.Drawing.Size(183, 20);
            this.txt_EspecificacaoNominal.TabIndex = 14;
            this.txt_EspecificacaoNominal.TextChanged += new System.EventHandler(this.txt_EspecificacaoNominal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Especificação Nominal:";
            // 
            // txt_IdModelo
            // 
            this.txt_IdModelo.Location = new System.Drawing.Point(68, 300);
            this.txt_IdModelo.Name = "txt_IdModelo";
            this.txt_IdModelo.Size = new System.Drawing.Size(183, 20);
            this.txt_IdModelo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id Modelo:";
            // 
            // ModeloAmostragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 666);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1015, 705);
            this.Name = "ModeloAmostragem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referêncial Amostral do Universo Estatístico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModeloAmostragem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Modelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_CaracteristicasChave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtt_Inicio;
        private System.Windows.Forms.DateTimePicker dtt_Fim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_MaquinaFabricacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_IdModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox txt_Lscr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Lscx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Licx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Lse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Lie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_EspecificacaoNominal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_FerramentaCaracteristica5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_FerramentaCaracteristica4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_FerramentaCaracteristica3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_FerramentaCaracteristica2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_FerramentaCaracteristica1;
        private System.Windows.Forms.Label label13;
    }
}