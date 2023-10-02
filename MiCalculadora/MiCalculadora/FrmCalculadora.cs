using Entidades;
using System;
using System.ComponentModel.DataAnnotations;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private ESistema sistema;

        bool flag = false;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento capaz de cargar la calculadora.
        /// </summary>
        private void FrmCalculadora_Load_1(object sender, EventArgs e)
        {
            this.rdbDecimal.Checked = true;
            this.cmbOperacion.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento que ocurre al hacer clic en el boton 'Operar'.
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {

            if (txtPrimerOperando is not null && txtSegundoOperando is not null)
            {
                char operador = char.Parse(cmbOperacion.SelectedItem.ToString()!);
                if (Numeracion.NoEsDivisionPorCero(operador, txtSegundoOperando.Text))
                {
                    calculadora = new Operacion(primerOperando, segundoOperando);
                    resultado = calculadora.Operar(operador);
                    SetResult();
                }
                else
                    lblMostrar.Text = "No se puede dividir por 0";
            }
            else
            {
                MessageBox.Show("Operación no válida. \nCompletar operandos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que ocurre al hacer clic en el boton 'Limpiar'.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperando.Text = "";
            txtSegundoOperando.Text = "";
            lblMostrar.Text = "";
        }

        /// <summary>
        /// Evento que ocurre al hacer clic en el boton 'Cerrar'.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = true;
                this.Close();
            }
        }

        /// <summary>
        /// Metodo capaz de mostrar el resultado de la operacion aritmetica.
        /// </summary>
        private void SetResult()
        {
            if (resultado is not null)
                if (sistema == ESistema.Binario)
                    lblMostrar.Text = "No hay binarios negativos.";
                else
                    lblMostrar.Text = resultado.ConvertirA(sistema);
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario escribe en el 1er operando.
        /// </summary>
        private void txtPrimerOperando_TextChanged(object sender, EventArgs e)
        {
            primerOperando = new Numeracion(txtPrimerOperando.Text, sistema);

        }

        /// <summary>
        /// Evento que ocurre cuando el usuario escribe en el 1er operando.
        /// </summary>
        private void txtSegundoOperando_TextChanged(object sender, EventArgs e)
        {
            segundoOperando = new Numeracion(txtSegundoOperando.Text, sistema);
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario cambia la seleccion a 'Decimal'.
        /// </summary>
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
                sistema = ESistema.Decimal;
            SetResult();
        }

        /// <summary>
        /// Evento que ocurre cuando el usuario cambia la seleccion a 'Binario'.
        /// </summary>
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
                sistema = ESistema.Binario;
            SetResult();
        }
    }
}