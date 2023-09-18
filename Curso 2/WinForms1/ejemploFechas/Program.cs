
Console.WriteLine("sobre fechas");

// DateTime fecha = new DateTime(2004, 4, 1);

DateTime fecha = DateTime.Now;

// Console.WriteLine("La fecha es: " + fecha.ToString());

Console.WriteLine("La fecha es: " + fecha.AddDays(5));

Console.WriteLine("La fecha es: " + fecha.ToShortDateString());

Console.WriteLine("La fecha es: " + fecha.ToString("dddd MM/yyyy"));


Console.ReadKey();

