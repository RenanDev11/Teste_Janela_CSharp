﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class JanelaTeste : Form
    {
        public JanelaTeste()
        { 
        

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você Clicou no Botão!");
            lblMensagem.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Feito por Renan");
        }
    }
}
