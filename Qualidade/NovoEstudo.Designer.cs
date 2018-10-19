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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_CarregarModelo = new System.Windows.Forms.ComboBox();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.btn_GerarEstudo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Caminho = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_CarregarModelo);
            this.panel1.Controls.Add(this.lbl_Modelo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 181);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empresa Requisitante:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail Requisitante:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionario Requisitante:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_CarregarModelo
            // 
            this.cmb_CarregarModelo.FormattingEnabled = true;
            this.cmb_CarregarModelo.Location = new System.Drawing.Point(10, 26);
            this.cmb_CarregarModelo.Name = "cmb_CarregarModelo";
            this.cmb_CarregarModelo.Size = new System.Drawing.Size(194, 21);
            this.cmb_CarregarModelo.TabIndex = 1;
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(3, 11);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_Modelo.TabIndex = 0;
            this.lbl_Modelo.Text = "Modelo:";
            // 
            // btn_GerarEstudo
            // 
            this.btn_GerarEstudo.Location = new System.Drawing.Point(336, 157);
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
            this.panel2.Controls.Add(this.lbl_Caminho);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(222, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 126);
            this.panel2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Requisição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Atenção:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "O estudo sera salvo com a data de hoje em";
            // 
            // lbl_Caminho
            // 
            this.lbl_Caminho.AutoSize = true;
            this.lbl_Caminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caminho.Location = new System.Drawing.Point(3, 106);
            this.lbl_Caminho.Name = "lbl_Caminho";
            this.lbl_Caminho.Size = new System.Drawing.Size(0, 16);
            this.lbl_Caminho.TabIndex = 8;
            // 
            // NovoEstudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(457, 197);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_GerarEstudo);
            this.Controls.Add(this.panel1);
            this.Name = "NovoEstudo";
            this.Text = "NovoEstudo";
            this.Load += new System.EventHandler(this.NovoEstudo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_CarregarModelo;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Button btn_GerarEstudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Caminho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}