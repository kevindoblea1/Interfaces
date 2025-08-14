using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Laptop : IDispositivoElectronico
{
    public string Marca;
    public string Modelo;
    public bool EstaEncendida;
    public int NivelBateria;

    public void Encender()
    {
        EstaEncendida = true;
        Console.WriteLine("Laptop encendida");
    }

    public void Apagar()
    {
        EstaEncendida = false;
        Console.WriteLine("Laptop apagada");
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Marca: " + Marca + ", Modelo: " + Modelo + ", Encendida: " + EstaEncendida + ", Batería: " + NivelBateria + "%");
    }
}