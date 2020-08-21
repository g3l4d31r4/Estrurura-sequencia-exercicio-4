using System;

class MainClass {
  public static void Main (string[] args) {
        Console.Write("Informe a primeira nota: ");
        float nota1 = float.Parse(Console.ReadLine());
        Console.Write("Informe a segunda nota: ");
        float nota2 = float.Parse(Console.ReadLine());
        Console.Write("Informe a terceira nota: ");
        float nota3 = float.Parse(Console.ReadLine());
        Console.Write("Informe a quarta nota: ");
        float nota4 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("A média é " + media);
    }
}