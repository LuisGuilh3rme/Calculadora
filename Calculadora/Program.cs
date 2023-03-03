double num1, num2;
int opcao = 0;

Console.WriteLine("Informe o primeiro número:");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número:");
num2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    Menu();
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        default:
            Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;

        case 1:
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.ReadKey();
            break;

        case 2:
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.ReadKey();
            break;

        case 4:
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.ReadKey();
            break;

        case 5:
            Console.WriteLine("Até mais!");
            break;
    }
}