bool desejo = true;
while (desejo == true)
{
    Console.WriteLine("Digite a quantidade de notas a ser calculada: ");
    int quantidade = int.Parse(Console.ReadLine());
    float notasTotal = 0;

    for (int i = 1; i <= quantidade; i++)
    {
        Console.WriteLine("Digite a " + i + "ª nota:");
        int notas = int.Parse(Console.ReadLine());
        notasTotal = notasTotal + notas;
    }
    double mediaNota = notasTotal / quantidade;
    Console.WriteLine("A média do aluno foi de " + mediaNota);
    if (mediaNota >= 6)
    {
        Console.WriteLine("Parabéns, você passou!");
        
    }
    else
    {
        Console.WriteLine("Tente novamente, media menor que 6.");
        
    }
    Console.WriteLine("Deseja calcular outra média? ");
    Console.WriteLine("Digite 1 para sim ou 2 para sair");
    int outra = int.Parse(Console.ReadLine());
    if ( outra ==1){
        desejo = true;
    } else{
        desejo = false;
        break;
    }

}
