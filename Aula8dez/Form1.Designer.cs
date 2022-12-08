namespace Aula8dez
{
    partial class Form1
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
            this.imput = new System.Windows.Forms.TextBox();
            this.labelDigitar = new System.Windows.Forms.Label();
            this.labelEnviar = new System.Windows.Forms.Button();
            this.labelDigitado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imput
            // 
            this.imput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imput.Location = new System.Drawing.Point(272, 47);
            this.imput.Name = "imput";
            this.imput.Size = new System.Drawing.Size(242, 38);
            this.imput.TabIndex = 0;
            this.imput.TextChanged += new System.EventHandler(this.imput_TextChanged);
            // 
            // labelDigitar
            // 
            this.labelDigitar.AutoSize = true;
            this.labelDigitar.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigitar.Location = new System.Drawing.Point(236, 9);
            this.labelDigitar.Name = "labelDigitar";
            this.labelDigitar.Size = new System.Drawing.Size(320, 35);
            this.labelDigitar.TabIndex = 1;
            this.labelDigitar.Text = "DIGITE UM NOME:";
            this.labelDigitar.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEnviar
            // 
            this.labelEnviar.Location = new System.Drawing.Point(352, 91);
            this.labelEnviar.Name = "labelEnviar";
            this.labelEnviar.Size = new System.Drawing.Size(75, 23);
            this.labelEnviar.TabIndex = 2;
            this.labelEnviar.Text = "Enviar";
            this.labelEnviar.UseVisualStyleBackColor = true;
            this.labelEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDigitado
            // 
            this.labelDigitado.AutoSize = true;
            this.labelDigitado.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigitado.Location = new System.Drawing.Point(188, 117);
            this.labelDigitado.Name = "labelDigitado";
            this.labelDigitado.Size = new System.Drawing.Size(405, 35);
            this.labelDigitado.TabIndex = 3;
            this.labelDigitado.Text = "O NOME DIGITADO FOI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDigitado);
            this.Controls.Add(this.labelEnviar);
            this.Controls.Add(this.labelDigitar);
            this.Controls.Add(this.imput);
            this.Name = "Form1";
            this.Text = "Enviar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imput;
        private System.Windows.Forms.Label labelDigitar;
        private System.Windows.Forms.Button labelEnviar;
        private System.Windows.Forms.Label labelDigitado;
    }
}

