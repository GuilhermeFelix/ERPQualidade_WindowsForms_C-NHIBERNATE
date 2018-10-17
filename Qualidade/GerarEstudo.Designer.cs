namespace Qualidade
{
    partial class GerarEstudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarEstudo));
            this.btn_GerarEstudo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_Historico = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Historico)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GerarEstudo
            // 
            this.btn_GerarEstudo.Location = new System.Drawing.Point(828, 10);
            this.btn_GerarEstudo.Name = "btn_GerarEstudo";
            this.btn_GerarEstudo.Size = new System.Drawing.Size(137, 53);
            this.btn_GerarEstudo.TabIndex = 0;
            this.btn_GerarEstudo.Text = "Gerar  Novo Estudo";
            this.btn_GerarEstudo.UseVisualStyleBackColor = true;
            this.btn_GerarEstudo.Click += new System.EventHandler(this.btn_GerarEstudo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_GerarEstudo);
            this.panel1.Location = new System.Drawing.Point(28, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 72);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudos:";
            // 
            // dtg_Historico
            // 
            this.dtg_Historico.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Historico.Location = new System.Drawing.Point(15, 48);
            this.dtg_Historico.Name = "dtg_Historico";
            this.dtg_Historico.Size = new System.Drawing.Size(940, 456);
            this.dtg_Historico.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dtg_Historico);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(28, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 522);
            this.panel2.TabIndex = 2;
            // 
            // GerarEstudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GerarEstudo";
            this.Text = "GerarEstudo";
            this.Load += new System.EventHandler(this.GerarEstudo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Historico)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GerarEstudo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_Historico;
        private System.Windows.Forms.Panel panel2;
    }
}