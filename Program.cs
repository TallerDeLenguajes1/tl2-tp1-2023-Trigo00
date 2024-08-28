

Cadeteria miCadeteria = new Cadeteria();
miCadeteria = LecturaCsv.TraerDatosDeCsv(@"C:\Users\Nico\Desktop\Taller2\tl2-tp1-2023-Trigo00\Cadete.csv", @"C:\Users\Nico\Desktop\Taller2\tl2-tp1-2023-Trigo00\Cadeteria.csv", miCadeteria);

GestionPedidos gestion = new GestionPedidos(miCadeteria);
gestion.MostrarMenu();