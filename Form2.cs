﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_
{
    public partial class FrmBancoDePreguntas : Form
    {
        public FrmBancoDePreguntas()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAltaPregunta ventana = new FrmAltaPregunta();
            ventana.Visible = true;
        }
    }
}