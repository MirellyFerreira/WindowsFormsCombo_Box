using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCombo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(txtTexto.Text);
            lblQtde.Text = cboLista.Items.Count.ToString();
            txtTexto.Clear();
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                lblQtde.Text = cboLista.Items.Count.ToString();
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                txtConteudo.Text = cboLista.SelectedItem?.ToString();
            }
        }
    }
}

