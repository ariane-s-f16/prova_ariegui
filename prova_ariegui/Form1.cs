using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_ariegui
{
    public partial class Form1 : Form
    {
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_INSERIR_Click(object sender, EventArgs e)
        {
          string produto= (textPRODUTO.Text);
          double qtd = double.Parse(textQTD.Text);
          double unit = double.Parse(textUNIT.Text);
             total += qtd * unit;

            dgv.Rows.Add(textPRODUTO.Text, textQTD.Text, textUNIT.Text);

            textPRODUTO.Clear();
            textQTD.Clear();
            textUNIT.Clear();

            texVENDA.Text = dgv.RowCount.ToString();

            textTOTAL.Text = total.ToString();

        }

        private void BTN_REMOVER_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                
                total -= Convert.ToDouble(dgv.CurrentRow.Cells[1].Value) * Convert.ToDouble(dgv.CurrentRow.Cells[2].Value); 
               

                textTOTAL.Text = total.ToString();
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);

                textQTD.Clear();
                textPRODUTO.Clear();
                textALTERAR.Clear();
                textUNIT.Clear();

                textPRODUTO.Focus();
            }


        }

        private void BTN_ALTERAR_Click(object sender, EventArgs e)
        {
            if (textALTERAR.Text != "") 
            {
                dgv.CurrentRow.Cells[0].Value = textALTERAR.Text;
            }
        }

        private void BTN_GERAR_Click(object sender, EventArgs e)
        {

            MessageBox.Show(("Venda realizada com sucesso com um total de: " + total) , "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
             
            dgv.RowCount = 1;
            texVENDA.Text= dgv.RowCount.ToString() ;
            textTOTAL.Clear();
        }

        private void BTN_FECHAR_Click(object sender, EventArgs e)
        {
               Application.Exit();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.RowCount > 0)
            {
                textALTERAR.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            }
        }

        
    }
}
