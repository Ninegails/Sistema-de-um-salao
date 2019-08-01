namespace Salao
{
    partial class AlterarTelefone
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtTelefoneAntigo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtNovoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(185, 193);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(147, 45);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o telefone antigo:";
            // 
            // mtxtTelefoneAntigo
            // 
            this.mtxtTelefoneAntigo.Location = new System.Drawing.Point(295, 82);
            this.mtxtTelefoneAntigo.Mask = "(99) 00000-0000";
            this.mtxtTelefoneAntigo.Name = "mtxtTelefoneAntigo";
            this.mtxtTelefoneAntigo.Size = new System.Drawing.Size(138, 26);
            this.mtxtTelefoneAntigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o novo telefone:";
            // 
            // mtxtNovoTelefone
            // 
            this.mtxtNovoTelefone.Location = new System.Drawing.Point(295, 132);
            this.mtxtNovoTelefone.Mask = "(99) 00000-0000";
            this.mtxtNovoTelefone.Name = "mtxtNovoTelefone";
            this.mtxtNovoTelefone.Size = new System.Drawing.Size(138, 26);
            this.mtxtNovoTelefone.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(20, 20);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 35);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // AlterarTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 287);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.mtxtNovoTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtTelefoneAntigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterar);
            this.Name = "AlterarTelefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarTelefone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneAntigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtNovoTelefone;
        private System.Windows.Forms.Button btnVoltar;
    }
}