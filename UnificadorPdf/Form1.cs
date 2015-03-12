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
            CheckBotao();

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
            CheckBotao();

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (lstLista.Items.Count == 0)
                return;

            saveFile.ShowDialog();

        }

        private void CheckBotao()
        {
            btnGerar.Enabled = lstLista.Items.Count > 0;
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            var x = saveFile;

            if (String.IsNullOrEmpty(x.FileName))
                return;

            RunBarry.destinationfile = x.FileName;
            RunBarry.Execute();

            MessageBox.Show("Arquivos Convertidos com Sucesso", "Desenvolvido por Antonio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lstLista.Clear();
            RunBarry.Zerar();
            CheckBotao();
        }
    }
}
