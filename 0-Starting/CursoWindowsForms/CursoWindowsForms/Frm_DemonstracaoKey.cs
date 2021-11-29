using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText($"{Environment.NewLine}" +
                $"Pressionei uma tecla: {e.KeyCode}" +
                $"{Environment.NewLine}");

            Txt_Msg.AppendText($"\t" +
                $"Código da Tecla: {((int)e.KeyCode)}" +
                $"{Environment.NewLine}");
            Txt_Msg.AppendText($"\t" +
                $"Nome da Tecla: {e.KeyData}" +
                $"{Environment.NewLine}");

            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = string.Empty;
            Txt_Input.Text = string.Empty;
            Lbl_Lower.Text = string.Empty;
            Lbl_Upper.Text = string.Empty;
        }
    }
}
