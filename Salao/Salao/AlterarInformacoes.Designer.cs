namespace Salao
{
    partial class AlterarInformacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarInformacoes));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterarEmail = new System.Windows.Forms.Button();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnAlterarTelefone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 30);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterarEmail
            // 
            this.btnAlterarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEmail.Image")));
            this.btnAlterarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEmail.Location = new System.Drawing.Point(134, 77);
            this.btnAlterarEmail.Name = "btnAlterarEmail";
            this.btnAlterarEmail.Size = new System.Drawing.Size(496, 77);
            this.btnAlterarEmail.TabIndex = 1;
            this.btnAlterarEmail.Text = "Clique aqui para mudar o seu E-mail";
            this.btnAlterarEmail.UseVisualStyleBackColor = true;
            this.btnAlterarEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarSenha.Image")));
            this.btnAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenha.Location = new System.Drawing.Point(134, 160);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(496, 75);
            this.btnAlterarSenha.TabIndex = 2;
            this.btnAlterarSenha.Text = "Clique aqui para mudar a sua senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // btnAlterarTelefone
            // 
            this.btnAlterarTelefone.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarTelefone.Image")));
            this.btnAlterarTelefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarTelefone.Location = new System.Drawing.Point(134, 242);
            this.btnAlterarTelefone.Name = "btnAlterarTelefone";
            this.btnAlterarTelefone.Size = new System.Drawing.Size(496, 68);
            this.btnAlterarTelefone.TabIndex = 3;
            this.btnAlterarTelefone.Text = "   Clique aqui para mudar o seu telefone";
            this.btnAlterarTelefone.UseVisualStyleBackColor = true;
            this.btnAlterarTelefone.Click += new System.EventHandler(this.btnAlterarTelefone_Click);
            // 
            // AlterarInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 385);
            this.Controls.Add(this.btnAlterarTelefone);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.btnAlterarEmail);
            this.Controls.Add(this.btnVoltar);
            this.Name = "AlterarInformacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarInformacoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterarEmail;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Button btnAlterarTelefone;
    }
}