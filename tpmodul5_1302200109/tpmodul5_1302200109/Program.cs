// See https://aka.ms/new-console-template for more information
using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = "alfar";
        halo.SapaUser(namaPanggilan);
    }
}

