﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TellerB1
{
    public partial class Cuadre : Form
    {
        public Cuadre()
        {
            InitializeComponent();
        }

        private void Cuadre_Load(object sender, EventArgs e)
        {

            this.reportCuadre.RefreshReport();
            
        }

        private void noCajero_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            DateTime cuadre = DateTime.Now;

            byte[] bytes = reportCuadre.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            //DONDE ESTA RECIBO + PDF VA EL PATH 
            using (FileStream fs = new FileStream(cuadre + ".pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
