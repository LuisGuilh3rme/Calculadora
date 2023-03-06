double num1, num2;
int opcao = 0;

Console.WriteLine("Informe o primeiro número:");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número:");
num2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    switch (opcao = Menu())
    {
        default:
            Console.WriteLine("Opção inválida");
            break;

        case 1:
            Console.WriteLine("{0} + {1} = {2}", num1, num2, Soma());
            break;

        case 2:
            Console.WriteLine("{0} - {1} = {2}", num1, num2, Subtracao());
            break;

        case 3:
            Console.WriteLine("{0} * {1} = {2}", num1, num2, Multiplicacao());
            break;

        case 4:
            Console.WriteLine("{0} / {1} = {2}", num1, num2, Divisao());
            break;

        case 5:
            Console.WriteLine("Até mais!");
            break;
    }
    Console.WriteLine("Aperte enter para continuar:");
    Console.ReadLine();
}

int Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opção: ");
    return int.Parse(Console.ReadLine());
}

double Soma()
{
    return num1 + num2;
}

double Subtracao()
{
    return num1 - num2;
}

double Multiplicacao()
{
    return num1 * num2;
}

double Divisao()
{
    return num1 / num2;
}