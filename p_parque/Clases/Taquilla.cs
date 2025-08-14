using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Taquilla
    {
        private byte id;
        private List<Manilla> l_manillas;
        private ulong saldo_ventas;

        public Taquilla(byte id, List<Manilla> l_manillas)
        {
            this.id = id;
            this.l_manillas = l_manillas;
            saldo_ventas = 0;
        }
        public byte Id
        {
            get => id;
            set
            {
                if (value < 1 || value > 3)
                    throw new Exception("El id en la taquilla ");
                else
                    id = value;
            }
        }
            internal List<Manilla> L.manillas { get => l_manillas; set
            {
                if (value.Count != Parque.cant_manillas_entregadas_en_la_taquilla)
                    throw new Exception("La cantidad de manillas no es válida" + value.Count + "\n");
                else
                    l_manillas = value;
                
                    
                }
            }
        public Manilla Vender_manillas(ulong dinero)
        {
            try
            {

                Manilla manilla_ret;
                //validar: dinero es mayor a la cantidad minima
                //cant_manillas > 0
                //qe la taquilla tengo almenos la cantidad de manillas que estan pidiendo
                if (dinero >= Parque.vlr_min_carga && l_manillas.Count > 0 && dinero%Parque.vlr_punto==0)
                {
                    manilla_ret = l_manillas.ElementAt(0);
                    l_manillas.RemoveAt(0);

                    manilla_ret.Saldo_puntos = (ushort)((dinero - Parque.vlr_entada) / Parque.vlr_punto);

                    return manilla_ret;
                }
                else
                    throw new Exception("Dinero insuficiente, o no hay manillas");
                
                //todo esta bien, saco cada manilla de la lista de manillas de la taquilla
                //y la pongo en la lista de manillas que se va a devolver




            }catch (Exception ex)
            {
                throw new Exception("Ocurrio un error vendiendo manillas\n" + ex);
            }
        }
    }
}
