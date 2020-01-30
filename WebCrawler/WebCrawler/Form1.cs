using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCrawler.INFRA;

namespace WebCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            AdmCrawler oAdmCrawler = new AdmCrawler();

            oAdmCrawler.GetLinks(txtURL.Text).ForEach(l =>
            {
                if (lstLINKS.Items.Count < 30) // Limitando a 30 registros para teste
                {
                    lstLINKS.Items.Add(l);
                    oAdmCrawler.GetLinks(l).ForEach(i =>{ lstLINKS.Items.Add(" - " + i); });
                }
            });

            oAdmCrawler.ProcessPages();
        }
    }
}
