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
    public partial class FrmCompararRespuestas : Form
    {
        public FrmCompararRespuestas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmCorreccionEx frmCorreccionEx = new FrmCorreccionEx();
            frmCorreccionEx.ShowDialog();
        }

        private void FrmCompararRespuestas_Load(object sender, EventArgs e)
        {

        }
    }
}