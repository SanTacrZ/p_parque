using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_parque.Clases
{
    internal class Parque
    {
        private string nombre;
        private List<Atraccion> l_atraciones;
        private List<Taquilla> l_taquillas;
        private List<Registro> l_registros;
        private List<Manilla> l_manillas;
        //vlr = valor
        internal static uint vlr_entada = 4000;
        internal static uint vlr_min_carga = 20000;
        internal static uint vlr_punto = 500;
        internal const ushort cant_manillas_entregadas_en_la_taquilla = 100;
        internal const ushort cant_manillas_parque= 1000;
        private const byte cant_atracciones = 10;
        private const byte cant_taquillas = 3;
        internal static TimeSpan min_min_atra = new TimeSpan(0, 1, 0);
        internal static TimeSpan max_min_atra = new TimeSpan(0,5,0);

        

        public Parque(string nombre, List<Atraccion> l_atraciones)
        {
            this.Nombre = nombre;
            this.L_atraciones = l_atraciones;//OK
            //la lista de registro vacia
            l_registros = new List<Registro>();//cree una lista de registros vacia
            //crear la lista de manillas 1000
            l_manillas = Generar_Manillas();


            //creacion de taquillas
            l_taquillas = new List<Taquilla>();
            for(byte i =1;i<=cant_taquillas;i++)
            {
               l_taquillas.Add( Crear_taquilla(i));
            }
        }
        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Atraccion> L_atraciones { get => l_atraciones;
            set {
                if (value.Count == cant_atracciones)
                    l_atraciones = value;
                else
                    throw new Exception("La lista debe contener exactamente " + cant_atracciones + " atracciones");
            } 
        }

        private List<Manilla> Generar_Manillas()
        {
            try
            {
                List<Manilla> l_manillas_ret = new List<Manilla>();
                for(int i = 1; i <= cant_manillas_parque;i++)
                {
                    l_manillas_ret.Add(new Manilla());
                }
                return l_manillas_ret;
            } 
            catch (Exception ex)
            { 
                throw new Exception("Error al generar manillas\n"+ex); 
            }
        }


        private Taquilla Crear_taquilla(byte id)
        {
            try
            {
                List<Manilla> l_manillas_taq= new List<Manilla>();
                
                for(byte i = 1; i < cant_manillas_entregadas_en_la_taquilla; i++)
                {
                    l_manillas_taq.Add(l_manillas.ElementAt(0));
                    l_manillas_taq.RemoveAt(0);
                }
                return new Taquilla(id, l_manillas_taq);
                
            }
            catch (Exception ex) { throw new Exception("Error al crear la taquilla"); }
        }
    }
}
