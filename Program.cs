using p_parque.Clases;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Taquilla taq1 = new Taquilla(1);

//Manilla manilla_prueba = taq1.VenderManillas(50000);

//Console.WriteLine($"La manilla de prueba quedó con un saldo de: {manilla_prueba.Sdo_puntos}");

try
{
    Random random = new Random();
    List<Atraccion> l_atracc = new List<Atraccion>();

    l_atracc.Add(new Atraccion("Carrusel", 10));
    l_atracc.Add(new Atraccion("carros chocones", 12));
    l_atracc.Add(new Atraccion("tren fantasma", 19));
    l_atracc.Add(new Atraccion("montaña rusa", 21));
    l_atracc.Add(new Atraccion("Montaña acuatica", 24));
    l_atracc.Add(new Atraccion("Rio Rapido", 30));
    l_atracc.Add(new Atraccion("Barco pirata", 28));
    l_atracc.Add(new Atraccion("Casa del terror", 29));
    l_atracc.Add(new Atraccion("Torre caida libre", 15));

    Parque parqueNorte = new Parque("Parque Norte Medellin",l_atracc);
    parqueNorte.L_taquillas.ElementAt(0).abrir();
    parqueNorte.L_taquillas.ElementAt(1).abrir();
    parqueNorte.L_taquillas.ElementAt(2).abrir();

    Manilla man_santacru = parqueNorte.L_taquillas.ElementAt(0).VenderManillas(100000);

    byte nro_atracc;
    for(byte i = 1;i<= 50; i++)
    {
        nro_atracc = (byte)random.Next(0, 9);
        if (parqueNorte.L_atracciones.ElementAt(nro_atracc).RegistrarIngreso(man_santacru))
            Console.WriteLine("Ingreso aceptado a la atraccion");
        parqueNorte.L_atracciones.ElementAt(nro_atracc);
    else

            Console.WriteLine("Ingreso aceptado a la atraccion");
        parqueNorte.L_atracciones.ElementAt(nro_atracc);
    }

    
    Console.WriteLine("Puntos que quedan en la manilla " + man_santacru.Sdo_puntos);


}
catch(Exception ex)
{
    Console.WriteLine("Ocurrio un error\n"+ ex.ToString());
}



//Console.WriteLine($"Manilla prueba pasó por la atracción {reg1.Atraccion.Nombre} en la fecha {reg1.Fecha_hora} y le quedaron {reg1.Manilla.Sdo_puntos}\n\n");

