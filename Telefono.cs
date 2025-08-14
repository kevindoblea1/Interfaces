using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Telefono : IDispositivoElectronico
{
    public string Marca;
    public string Modelo;
    public bool EstaEncendido;

    public void Encender()
    {
        EstaEncendido = true;
        Console.WriteLine("Teléfono encendido");
    }

    public void Apagar()
    {
        EstaEncendido = false;
        Console.WriteLine("Teléfono apagado");
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Marca: " + Marca + ", Modelo: " + Modelo + ", Encendido: " + EstaEncendido);
    }
}