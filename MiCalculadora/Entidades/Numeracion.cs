namespace Entidades
{
    public enum ESistema { Decimal, Binario }
    /// <summary>
    /// Clase que representa una numeración, con capacidad de conversión entre sistemas numéricos.
    /// </summary>
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        /// <summary>
        /// Propiedad getter que devuelve sistema el sistema correspondiente, decimal o binario.
        /// </summary>
        public ESistema Sistema
        {
            get{ return this.sistema; }
        }
        /// <summary>
        /// Propiedad getter que devuelve el valor numerico en string.
        /// </summary>
        public string ValorNumerico
        {
            get{ return this.valorNumerico.ToString(); }
        }
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="valor">Valor numerico.</param>
        /// <param name="sistema">Sistema numerico de valor.</param>
        public Numeracion(double valor, ESistema sistema) : this(valor.ToString(), sistema)
        {
            this.sistema = sistema;
        }
        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="valor">Valor numerico.</param>
        /// <param name="sistema">Sistema numerico de valor.</param>
        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        /// <summary>
        /// Metodo capaz de convertir un numero binario a decimal
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        /// <returns>Valor convertido</returns>
        public static double BinarioADecimal(string valor)
        {
            double numero = 0;
            if (valor is not null && valor != "" && EsBinario(valor))
            { 
                double exponente = valor.Length - 1;
                for (int i = 0; i < valor.Length; i++)
                {
                    //Obtengo cada digito del string con valor[i], luego paso el valor Unicode numerico a un numero para luego multiplicar por las potencias de 2
                    numero = numero + Char.GetNumericValue(valor[i]) * (Math.Pow(2, exponente));
                    exponente--;
                }
            }
            return (int)numero;
        }

        /// <summary>
        /// Metodo capaz de convertir un valor en el sistema elegido.
        /// </summary>
        /// <param name="sistema">Sistema numerico seleccionado</param>
        /// <returns>Valor convertido</returns>
        public string ConvertirA(ESistema sistema)
        {
            string resultado = "";

            switch (sistema)
            {
                case ESistema.Binario:
                    resultado = DecimalABinario((int)this.valorNumerico);
                    break;
                case ESistema.Decimal:
                    resultado = this.valorNumerico.ToString();
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Metodo capaz de convertir un numero decimal a binario
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        /// <returns>Valor convertido.</returns>
        public static string DecimalABinario(int valor)
        {
            string resultado = "";
            int cociente = valor;
            int resto = 0;
            while (cociente > 1)
            {
                resto = cociente % 2;
                cociente = cociente / 2;
                resultado = resto + resultado;

            }
            resultado = cociente + resultado;
            return resultado;
        }
        /// <summary>
        /// Metodo capaz de convertir un numero decimal a binario
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        /// <returns>Valor convertido.</returns>
        public static string DecimalABinario(string valor)
        {
            string resultado = "";
            int resto = 0;
            if (int.TryParse(valor, out int cociente))
            {
                while (cociente > 1)
                {
                    resto = cociente % 2;
                    cociente = cociente / 2;
                    resultado = resto + resultado;

                }
            }
            resultado = cociente + resultado;
            return resultado;
        }

        /// <summary>
        /// Metodo capaz de verificar si un valor es binario.
        /// </summary>
        /// <param name="valor"></param>Valor a verificar.
        /// <returns>Verdadero si lo és, falso en caso contrario.</returns>
        private static bool EsBinario(string valor)
        {
            bool resultado = true;
            for (int i = 0; i < valor.Length; i++)
            {
                char item = valor[i];
                if (item != '1' && item != '0')
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Metodo capaz de inializar valores
        /// </summary>
        /// <param name="valor">Valor dado en string</param>
        /// <param name="sistema">Sistema numerico de valor</param>
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (double.TryParse(valor, out double auxValor))
                this.valorNumerico = auxValor;
            else if (sistema == ESistema.Binario && EsBinario(valor))
                this.valorNumerico = BinarioADecimal(valor);
            else
                this.valorNumerico = double.MinValue;
        }

        /// <summary>
        /// Metodo capaz de validar divison por 0
        /// </summary>
        public static bool NoEsDivisionPorCero(char operador, string segundoOperando)
        {
            if(double.TryParse(segundoOperando, out double auxValor))
                if (auxValor == 0 && operador == '/')
                    return false;
            return true;
        }

        /// <summary>
        /// Sobrecarga del operador !=.
        /// </summary>
        /// <param name="sistema">Sistema numerico</param>
        /// <param name="numeracion">Valor a comparar</param>
        /// <returns>Verdadero si valor no corresponde al sistema numerico, falso en caso contrario.</returns>
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        /// <summary>
        /// Sobrecarga del operador de !=.
        /// </summary>
        /// <param name="n1">Valor 1 a comparar.</param>
        /// <param name="n2">Valor 2 a comparar.</param>
        /// <returns>Verdadero si los valores corresponden a sistemas numéricos distintos, falso en caso contrario.</returns>
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        /// <summary>
        /// Sobrecarga del operador +.
        /// </summary>
        /// <param name="n1">Valor 1 a sumar.</param>
        /// <param name="n2">Valor 2 a sumar.</param>
        /// <returns>Suma de ambos valores.</returns>
        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico + n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Sobrecarga del operador de -.
        /// </summary>
        /// <param name="n1">Valor 1 a restar.</param>
        /// <param name="n2">Valor 2 a restar.</param>
        /// <returns>Resta de ambos valores.</returns>
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico - n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Sobrecarga del operador *.
        /// </summary>
        /// <param name="n1">Valor 1 a multiplicar.</param>
        /// <param name="n2">Valor 2 a multiplicar.</param>
        /// <returns>Producto de ambos valores.</returns>
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico * n2.valorNumerico, ESistema.Decimal);
        }

        /// <summary>
        /// Sobrecarga del operador de /.
        /// </summary>
        /// <param name="n1">Dividendo.</param>
        /// <param name="n2">Divisor.</param>
        /// <returns>Cociente</returns>
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            return new Numeracion(n1.valorNumerico / n2.valorNumerico, ESistema.Decimal);
        }
        /// <summary>
        /// Sobrecarga del operador de ==.
        /// </summary>
        /// <param name="sistema">Sistema numerico.</param>
        /// <param name="numeracion">Valor a comparar.</param>
        /// <returns>Verdadero si valor no corresponde al sistema numerico, falso en caso contrario.</returns>
        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }
        /// <summary>
        /// Sobrecarga del operador de igualdad para la clase Numeracion.
        /// </summary>
        /// <param name="n1">Valor 1 a comparar.</param>
        /// <param name="n2">Valor 2 a comparar.</param>
        /// <returns>Verdadero si los valores corresponden a sistemas numéricos distintos, falso en caso contrario.</returns>
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.Sistema == n2.Sistema;
        }
    }
}