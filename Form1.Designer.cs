namespace Programa_em_C_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            //
            // TextBox do CNPJ (Config)
            //
            this.txtCnpj.Location = new System.Drawing.Point(20,20);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(200, 20);
            this.txtCnpj.TabIndex = 0;
            //
            // Botão de Buscar (Config)
            //
            this.btnBuscar.Location = new System.Drawing.Point(230, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // Label do Resultado (Config)
            //
            this.lblResultado.Location = new System.Drawing.Point(20, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(350, 400);
            this.lblResultado.TabIndex = 2;
            //
            // Barra de Progresso (Config)
            //
            this.progressBar.Location = new System.Drawing.Point(20, 60);
            this.progressBar.Name = "progressbar";
            this.progressBar.Size = new System.Drawing.Size(285, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            // 
            // Configuração do Form1 (Funcionar tudo q tá em cima kkkk)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Busca de CNPJ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultado;

        private System.Windows.Forms.ProgressBar progressBar;
    }
}
        
namespace Programa_em_C_{}
