using Interfaces;

Telefono miTelefono = new Telefono();
miTelefono.Marca = "Samsung";
miTelefono.Modelo = "Galaxy S23";
miTelefono.EstaEncendido = false;

Laptop miLaptop = new Laptop();
miLaptop.Marca = "Dell";
miLaptop.Modelo = "XPS 15";
miLaptop.EstaEncendida = false;
miLaptop.NivelBateria = 80;

Console.WriteLine("=== Estado inicial ===");
miTelefono.MostrarEstado();
miLaptop.MostrarEstado();

Console.WriteLine("\n=== Encendiendo ===");
miTelefono.Encender();
miLaptop.Encender();

Console.WriteLine("\n=== Estado después de encender ===");
miTelefono.MostrarEstado();
miLaptop.MostrarEstado();

Console.WriteLine("\n=== Apagando ===");
miTelefono.Apagar();
miLaptop.Apagar();

Console.WriteLine("\n=== Estado final ===");
miTelefono.MostrarEstado();
miLaptop.MostrarEstado();