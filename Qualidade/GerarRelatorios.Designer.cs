namespace Qualidade
{
    partial class GerarRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarRelatorios));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Modelos = new System.Windows.Forms.ComboBox();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Subtransacao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // cmb_Modelos
            // 
            this.cmb_Modelos.FormattingEnabled = true;
            this.cmb_Modelos.Location = new System.Drawing.Point(32, 28);
            this.cmb_Modelos.Name = "cmb_Modelos";
            this.cmb_Modelos.Size = new System.Drawing.Size(202, 21);
            this.cmb_Modelos.TabIndex = 1;
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.Location = new System.Drawing.Point(159, 116);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gerar.TabIndex = 2;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = true;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subtransação:";
            // 
            // txt_Subtransacao
            // 
            this.txt_Subtransacao.Location = new System.Drawing.Point(32, 78);
            this.txt_Subtransacao.Name = "txt_Subtransacao";
            this.txt_Subtransacao.Size = new System.Drawing.Size(202, 20);
            this.txt_Subtransacao.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmb_Modelos);
            this.panel1.Controls.Add(this.btn_Gerar);
            this.panel1.Controls.Add(this.txt_Subtransacao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 158);
            this.panel1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(452, 262);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // GerarRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Qualidade.Properties.Resources.backgroundsystem;
            this.ClientSize = new System.Drawing.Size(739, 284);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "GerarRelatorios";
            this.Text = "GerarRelatorios";
            this.Load += new System.EventHandler(this.GerarRelatorios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Modelos;
        private System.Windows.Forms.Button btn_Gerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Subtransacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}