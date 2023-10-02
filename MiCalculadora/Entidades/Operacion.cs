using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase con capacidad de operar dos numeros.
    /// </summary>
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        /// <summary>
        /// Propiedad get y set del primer operando.
        /// </summary>
        public Numeracion PrimerOperando
        {
            get{ return this.primerOperando;  }
            set{ this.primerOperando = value; }
        }

        /// <summary>
        /// Propiedad get y set del segundo operando.
        /// </summary>
        public Numeracion SegundoOperando
        {
            get{ return this.segundoOperando;  }
            set{ this.segundoOperando = value; }
        }

        /// <summary>
        /// Metodo capaz de operar la operacion aritmetica elegida.
        /// </summary>
        public Numeracion Operar(char operando)
        {
            Numeracion operar;

            switch(operando)
            {
                case '+': operar = primerOperando + segundoOperando; break;
                case '-': operar = primerOperando - segundoOperando; break;
                case '*': operar = primerOperando * segundoOperando; break;
                case '/': operar = primerOperando / segundoOperando; break;
                default:  operar = primerOperando + segundoOperando; break;
            }
            return operar;
        }
    }
}