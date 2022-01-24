using CursoWindowsForms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        private bool messageBoxIsEnable = false;

        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Resultado.Text = string.Empty;
                msk_CPF.Text = string.Empty;
            }
            catch (Exception er)
            {

                throw er;
            }
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {

            string vConteudo;
            vConteudo = msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim().Replace(" ", "0");
            if (vConteudo == "")
            {
                if (!messageBoxIsEnable)
                {
                    lbl_Resultado.Text = "Você deve digitar um CPF!";
                }
                else
                {
                    MessageBox.Show("Você deve digitar um CPF!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (vConteudo.Length != 11)
            {
                if (!messageBoxIsEnable)
                {
                    lbl_Resultado.Text = "CPF deve ter 11 digitos!";
                }
                else
                {
                    MessageBox.Show("CPF deve ter 11 digitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("Você Deseja Realmente validar o CPF?",
                               "Mensagem de Validação",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bool validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
                        if (validaCPF)
                        {
                            if (!messageBoxIsEnable)
                            {
                                lbl_Resultado.Text = "CPF VÁLIDO";
                                lbl_Resultado.ForeColor = Color.Green;
                            }
                            else
                            {
                                MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (!messageBoxIsEnable)
                            {
                                lbl_Resultado.Text = "CPF INVÁLIDO";
                                lbl_Resultado.ForeColor = Color.Red;
                            }
                            else
                            {
                                MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception er)
                    {

                        throw er;
                    }
                }
            }
        }

        private void chk_EnableAlert_CheckedChanged(object sender, EventArgs e)
        {
            messageBoxIsEnable = ((System.Windows.Forms.CheckBox)sender).Checked;
        }
    }
}
