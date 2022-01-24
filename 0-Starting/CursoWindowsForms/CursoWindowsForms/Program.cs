using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 0. Hello World
            //Application.Run(new frm_HelloWorld());

            // 1. Key Info
            //Application.Run(new Frm_DemonstracaoKey());

            // 2. Valida Senha
            //Application.Run(new Frm_ValidaSenha());

            // 3. Mascaras
            //Application.Run(new Frm_Mascara());

            // 4. Valida CPF com Mascara
            //Application.Run(new Frm_ValidaCPF());

            // 5. Programa Principal
            Application.Run(new Frm_Principal());
        }
    }
}
