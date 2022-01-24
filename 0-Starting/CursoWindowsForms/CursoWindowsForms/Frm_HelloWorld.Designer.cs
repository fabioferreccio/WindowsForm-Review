
namespace CursoWindowsForms
{
    partial class frm_HelloWorld
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HelloWorld));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.txt_ConteudoTitulo = new System.Windows.Forms.TextBox();
            this.btn_ModificaTitulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(15, 15);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(255, 24);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .Net Version";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(150, 515);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(100, 30);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // txt_ConteudoTitulo
            // 
            this.txt_ConteudoTitulo.Location = new System.Drawing.Point(15, 61);
            this.txt_ConteudoTitulo.Name = "txt_ConteudoTitulo";
            this.txt_ConteudoTitulo.Size = new System.Drawing.Size(255, 27);
            this.txt_ConteudoTitulo.TabIndex = 2;
            // 
            // btn_ModificaTitulo
            // 
            this.btn_ModificaTitulo.Location = new System.Drawing.Point(276, 61);
            this.btn_ModificaTitulo.Name = "btn_ModificaTitulo";
            this.btn_ModificaTitulo.Size = new System.Drawing.Size(94, 29);
            this.btn_ModificaTitulo.TabIndex = 3;
            this.btn_ModificaTitulo.Text = "Trocar";
            this.btn_ModificaTitulo.UseVisualStyleBackColor = true;
            this.btn_ModificaTitulo.Click += new System.EventHandler(this.btn_ModificaTitulo_Click);
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.btn_ModificaTitulo);
            this.Controls.Add(this.txt_ConteudoTitulo);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TextBox txt_ConteudoTitulo;
        private System.Windows.Forms.Button btn_ModificaTitulo;
    }
}

