using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Atraccion
    {
        private string nombre;
        private byte puntos;
        private TimeSpan duracion;

        public Atraccion(string nombre, byte puntos, TimeSpan duracion)
        {
            this.Nombre = nombre;
            this.Puntos = puntos;
            this.Duracion = duracion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Puntos { get => puntos; set => puntos = value; }
        public TimeSpan Duracion
        {
            get => duracion;
            set
            {
                if (value >= Parque.min_min_atra && value <= Parque.max_min_atra)
                {
                    duracion = value;
                    
                }else
                    throw new Exception("La duración debe ser entre 1 y 5 minutos");

            }
        }

        public bool Descontar_puntos(Manilla manilla, Parque parque)
        {
            try
            {
                //si los puntos de la manillas es mayor o igual a los puntos de la atraccion,
                //descuento los puntos de la atraccion a la manilla y retorno el true
                if (manilla.Saldo_puntos >= puntos)
                {
                    manilla.Saldo_puntos -= puntos;
                    new Registro(this,manilla);
                    parque.L_registros.Add(new Registro(this, manilla));
                    return true;
                }
                else
                    return false;
                //de lo ocntrario, return false

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error descontando puntos\n" + ex);
            }

        }
        public string Descontar_puntos_S(Manilla manilla)
        {
            try
            {
                //si los puntos de la manillas es mayor o igual a los puntos de la atraccion,
                //descuento los puntos de la atraccion a la manilla y retorno el mensaje con los puntos de la manilla

                //de lo ocntrario, return mensaje saldo insuficiente.
                //
                if (manilla.Saldo_puntos >= this.Puntos)
                {
                    manilla.Saldo_puntos -= this.Puntos;
                    return $"Los puntos de la manilla son: {manilla.Saldo_puntos}";
                }
                else
                {
                    return "Saldo insuficiente";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error descontando puntos sobreCargado\n" + ex);
            }

        }
    }
}
