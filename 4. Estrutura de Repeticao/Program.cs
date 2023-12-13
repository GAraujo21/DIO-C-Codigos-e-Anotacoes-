// REPETIÇÃO FOR

// int a = 5;

// for (int contador = 0; contador <= 10; contador ++){
//     Console.WriteLine($"{a} x {contador} = {a*contador}");
// }





// REPETIÇÃO WHILE

// int a = 5;
// int contador = 0;

// while(contador <= 10 ){
//     Console.WriteLine($"{a} x {contador} = {a*contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break; // estou paradno a execução quando o contador for igual a 6
//     }
// }






// REPETIÇÃO DO WHILE

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um valor: (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine("A soma dos números digitados é igual a: " + soma);




string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear(); // faz com que limpe a tela.
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1- Cadastrar cliente.");
    Console.WriteLine("2- Buscar cliente.");
    Console.WriteLine("3- Apagar cliente.");
    Console.WriteLine("4- Encerrar.");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar de cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0); // Aqui vc encerra o Programa AQUI, nada q vier dps vai ser executado
            break;

        default: 
            Console.WriteLine("Opção inválida.");
            break;
    }
}

Console.WriteLine("O programa se encerrou");