namespace Aula8dez
{
    partial class form2
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
            this.imput1 = new System.Windows.Forms.TextBox();
            this.imput2 = new System.Windows.Forms.TextBox();
            this.botaolimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imput1
            // 
            this.imput1.Location = new System.Drawing.Point(28, 12);
            this.imput1.Multiline = true;
            this.imput1.Name = "imput1";
            this.imput1.Size = new System.Drawing.Size(264, 24);
            this.imput1.TabIndex = 0;
            this.imput1.TextChanged += new System.EventHandler(this.imput1_TextChanged);
            this.imput1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // imput2
            // 
            this.imput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imput2.Location = new System.Drawing.Point(28, 58);
            this.imput2.Multiline = true;
            this.imput2.Name = "imput2";
            this.imput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.imput2.Size = new System.Drawing.Size(696, 416);
            this.imput2.TabIndex = 1;
            this.imput2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // botaolimpar
            // 
            this.botaolimpar.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaolimpar.Location = new System.Drawing.Point(750, 27);
            this.botaolimpar.Name = "botaolimpar";
            this.botaolimpar.Size = new System.Drawing.Size(196, 118);
            this.botaolimpar.TabIndex = 2;
            this.botaolimpar.Text = "LIMPAR";
            this.botaolimpar.UseVisualStyleBackColor = true;
            this.botaolimpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 498);
            this.Controls.Add(this.botaolimpar);
            this.Controls.Add(this.imput2);
            this.Controls.Add(this.imput1);
            this.Name = "form2";
            this.Text = "Aula8dezParte2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imput1;
        private System.Windows.Forms.TextBox imput2;
        private System.Windows.Forms.Button botaolimpar;
    }
}