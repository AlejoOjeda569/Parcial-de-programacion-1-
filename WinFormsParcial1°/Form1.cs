using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace WinFormsParcial1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregarfila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void setearfila(DataGridViewRow r, double radio, double altura)
        {
            double Base = Math.Truncate(Math.PI * Math.Pow(radio, 2));
            r.Cells[ColRadio.Index].Value = radio;
            r.Cells[ColAltura.Index].Value = altura;

            r.Cells[ColBase.Index].Value = Base;
            r.Cells[ColArea.Index].Value = CalcualrArea(radio, altura);
            r.Cells[ColVolumen.Index].Value = CalcularVolumen(altura, Base);

        }

        private object CalcularVolumen(double altura, double @base) => Math.Truncate(@base * altura);


        private object CalcualrArea(double radio, double altura) => Math.Truncate(2 * Math.PI * radio * (radio * altura));


        private DataGridViewRow construirfila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicilizarcontroles();
        }

        private void inicilizarcontroles()
        {
            txtAltura.Clear();
            txtRadio.Clear();
            txtRadio.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {      
                var radio = double.Parse(txtRadio.Text);
                   var altura = double.Parse(txtAltura.Text);

                if (radio>0 && altura>0 )
                {
                  
                   DataGridViewRow r = construirfila();
                   setearfila(r, radio, altura);
                   Agregarfila(r);
                   MessageBox.Show("Registro agregado", "mensaje",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("NO se aceptan numeros negativos", "mensaje",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               



            }
            inicilizarcontroles();
        }

        private bool validardatos()
        {
            bool esvalido = true;
            errorProvider1.Clear();
            if (!double.TryParse(txtRadio.Text, out double nro))
            {
                esvalido = false;
                errorProvider1.SetError(txtRadio, "Nro fuera de la linea");
            }
            if (!double.TryParse(txtAltura.Text, out double Nro))
            {
                esvalido = false;
                errorProvider1.SetError(txtRadio, "Nro fuera de la linea");
            }


            return esvalido;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("�Estas seguro?", "Confirmaci�n",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}