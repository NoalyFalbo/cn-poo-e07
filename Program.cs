using System;

namespace aulaThomaz
{

  class Program
  {

    static void Main(string[] args)
    {

      int codigo = 0;

      Console.Clear();

      Console.WriteLine("Codigo do produto: ");
      Console.WriteLine("1 - Suco");
      Console.WriteLine("2 - Água");
      Console.WriteLine("Digite um codigo: ");

      try
      {
        codigo = int.Parse(Console.ReadLine());
      }
      catch
      {
        Console.WriteLine("Código invalido");
      }

      if (codigo != default)
      {

        if (codigo == 1)
        {
          Console.WriteLine("Você escolheu Suco");
        }
        else if (codigo == 2)
        {
          Console.WriteLine("Você escolheu água");
        }
        else
        {
          Console.WriteLine("Opção invalida");

        }
      }



    }
  }
}