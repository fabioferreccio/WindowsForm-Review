
namespace CursoWindowsForms
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_DemonstracaoKey = new System.Windows.Forms.Button();
            this.Btn_HelloWorld = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DemonstracaoKey
            // 
            this.Btn_DemonstracaoKey.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DemonstracaoKey.Image")));
            this.Btn_DemonstracaoKey.Location = new System.Drawing.Point(16, 18);
            this.Btn_DemonstracaoKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_DemonstracaoKey.Name = "Btn_DemonstracaoKey";
            this.Btn_DemonstracaoKey.Size = new System.Drawing.Size(152, 74);
            this.Btn_DemonstracaoKey.TabIndex = 0;
            this.Btn_DemonstracaoKey.Text = "Demonstração Key";
            this.Btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            this.Btn_DemonstracaoKey.Click += new System.EventHandler(this.Btn_DemonstracaoKey_Click);
            // 
            // Btn_HelloWorld
            // 
            this.Btn_HelloWorld.Image = ((System.Drawing.Image)(resources.GetObject("Btn_HelloWorld.Image")));
            this.Btn_HelloWorld.Location = new System.Drawing.Point(176, 18);
            this.Btn_HelloWorld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_HelloWorld.Name = "Btn_HelloWorld";
            this.Btn_HelloWorld.Size = new System.Drawing.Size(152, 74);
            this.Btn_HelloWorld.TabIndex = 1;
            this.Btn_HelloWorld.Text = "Hello World";
            this.Btn_HelloWorld.UseVisualStyleBackColor = true;
            this.Btn_HelloWorld.Click += new System.EventHandler(this.Btn_HelloWorld_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Mascara.Image")));
            this.Btn_Mascara.Location = new System.Drawing.Point(336, 18);
            this.Btn_Mascara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(152, 74);
            this.Btn_Mascara.TabIndex = 2;
            this.Btn_Mascara.Text = "Máscara";
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click);
            // 
            // Btn_ValidaCPF
            // 
            this.Btn_ValidaCPF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaCPF.Image")));
            this.Btn_ValidaCPF.Location = new System.Drawing.Point(16, 102);
            this.Btn_ValidaCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            this.Btn_ValidaCPF.Size = new System.Drawing.Size(152, 74);
            this.Btn_ValidaCPF.TabIndex = 3;
            this.Btn_ValidaCPF.Text = "Valida CPF";
            this.Btn_ValidaCPF.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF.Click += new System.EventHandler(this.Btn_ValidaCPF_Click);
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValidaSenha.Image")));
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(176, 102);
            this.Btn_ValidaSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(152, 74);
            this.Btn_ValidaSenha.TabIndex = 5;
            this.Btn_ValidaSenha.Text = "Valida Senha";
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.Btn_ValidaSenha.Click += new System.EventHandler(this.Btn_ValidaSenha_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 194);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.Btn_ValidaCPF);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_HelloWorld);
            this.Controls.Add(this.Btn_DemonstracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DemonstracaoKey;
        private System.Windows.Forms.Button Btn_HelloWorld;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_ValidaCPF;
        private System.Windows.Forms.Button Btn_ValidaSenha;
    }
}