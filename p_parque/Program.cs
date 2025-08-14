using p_parque.Clases;

namespace p_parque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Atraccion> l_atracciones = new List<Atraccion>();
            List<Atraccion> l_manillas_vendidas = new List<Atraccion>();
            l_atracciones.Add(new Atraccion("HULK", 30, new TimeSpan(0, 1, 50)));
            l_atracciones.Add(new Atraccion("CAPITAN AMERICA", 30, new TimeSpan(0, 1, 20)));
            l_atracciones.Add(new Atraccion("KARTS sencillos", 20, new TimeSpan(0, 5, 0)));
            l_atracciones.Add(new Atraccion("Montaña Acuatica", 25, new TimeSpan(0, 3, 0)));
            l_atracciones.Add(new Atraccion("Ciclon", 15, new TimeSpan(0, 2, 0)));
            

            Parque parque_norte = new Parque("Parque norte",l_atracciones);
        }
    }
}