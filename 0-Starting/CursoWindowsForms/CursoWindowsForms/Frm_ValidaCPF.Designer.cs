
namespace CursoWindowsForms
{
    partial class Frm_ValidaCPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaCPF));
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Valida = new System.Windows.Forms.Button();
            this.chk_EnableAlert = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(16, 69);
            this.msk_CPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msk_CPF.Mask = "000,000,000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(289, 27);
            this.msk_CPF.TabIndex = 0;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.Location = new System.Drawing.Point(16, 138);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.lbl_Resultado.TabIndex = 1;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(327, 65);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(148, 35);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Valida
            // 
            this.btn_Valida.Location = new System.Drawing.Point(327, 109);
            this.btn_Valida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Valida.Name = "btn_Valida";
            this.btn_Valida.Size = new System.Drawing.Size(148, 35);
            this.btn_Valida.TabIndex = 3;
            this.btn_Valida.Text = "Valida";
            this.btn_Valida.UseVisualStyleBackColor = true;
            this.btn_Valida.Click += new System.EventHandler(this.btn_Valida_Click);
            // 
            // chk_EnableAlert
            // 
            this.chk_EnableAlert.AutoSize = true;
            this.chk_EnableAlert.Location = new System.Drawing.Point(16, 109);
            this.chk_EnableAlert.Name = "chk_EnableAlert";
            this.chk_EnableAlert.Size = new System.Drawing.Size(171, 24);
            this.chk_EnableAlert.TabIndex = 4;
            this.chk_EnableAlert.Text = "Habilita MessageBox";
            this.chk_EnableAlert.UseVisualStyleBackColor = true;
            this.chk_EnableAlert.CheckedChanged += new System.EventHandler(this.chk_EnableAlert_CheckedChanged);
            // 
            // Frm_ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 238);
            this.Controls.Add(this.chk_EnableAlert);
            this.Controls.Add(this.btn_Valida);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.msk_CPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_ValidaCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Valida;
        private System.Windows.Forms.CheckBox chk_EnableAlert;
    }
}