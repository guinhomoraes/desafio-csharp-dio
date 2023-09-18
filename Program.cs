using System;

double precoInicial = 0.00;
double precoHora = 0.00;
int qtdHoras = 0;
double preco = 0.00;
int itemMenu = 0;
List<string> carros = new List<string>();


Console.WriteLine("Informe o preco inicial");
precoInicial = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o preco por hora");

precoHora = Convert.ToDouble(Console.ReadLine());
int continua = 0;
string itemRemovido;

do
{
    Console.WriteLine("Menu");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Listar Carro");
    Console.WriteLine("3 - Remover Carro");

    Console.WriteLine("Infome o item do menu");
    itemMenu = Convert.ToInt16(Console.ReadLine());

    switch (itemMenu)
    {
        case 1:
            Console.WriteLine("Infome a placa do veiculo");
            carros.Add((Console.ReadLine()));
            Console.WriteLine("Veiculo adicionado");
            break;
        case 2:
            int contador=0;
            foreach (var item in carros)
            {
                Console.WriteLine(""+contador+" - "+item+"");
                contador++;
            }
            break;
        case 3:
            Console.WriteLine("Infome a placa do veiculo");
            itemRemovido = Console.ReadLine();
            carros.Remove(itemRemovido);
            Console.WriteLine("Infome a quantidade de horas");
            qtdHoras = Convert.ToInt16(Console.ReadLine());
            preco = precoInicial + (precoHora * qtdHoras);
            Console.WriteLine("Veiculo - "+itemRemovido+" - Valor a pagar R$ "+preco+"");
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }

    Console.WriteLine("Deseja continuar?");
    continua = Convert.ToInt16(Console.ReadLine());

}while(continua == 1);
