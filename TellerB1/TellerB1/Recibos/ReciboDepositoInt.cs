using Microsoft.Reporting.WinForms;
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
    public partial class ReciboDepositoInt : Form
    {
        public ReciboDepositoInt()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            DateTime recibo = DateTime.Now;

            byte[] bytes = reporte.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            //DONDE ESTA RECIBO + PDF VA EL PATH 
            using (FileStream fs = new FileStream(recibo + ".pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            //Fecha y hora del recibo
            fecha.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
