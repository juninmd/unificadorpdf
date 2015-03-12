using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnificadorPdf
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstLista.Clear();
            RunBarry.Zerar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = fileDialog;
            p.ShowDialog();
            var x = p.FileNames;

            foreach (var item in from item in x let extensao = System.IO.Path.GetExtension(item) where !String.IsNullOrEmpty(item) && extensao == ".pdf" select item)
            {
                lstLista.Items.Add(item);
                RunBarry.AddFile(item);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var x = saveFile;
            x.ShowDialog();
            RunBarry.destinationfile = x.FileName;
            RunBarry.Execute();
        }
    }
}
