﻿using System;
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
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ModificaTitulo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ConteudoTitulo.Text))
            {
                lbl_Titulo.Text = txt_ConteudoTitulo.Text;
            }
            else
            {
                MessageBox.Show("Favor inserir texto para prosseguir.");
            }
        }
    }
}