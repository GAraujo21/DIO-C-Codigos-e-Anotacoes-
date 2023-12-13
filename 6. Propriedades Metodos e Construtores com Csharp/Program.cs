using _6._Propriedades_Metodos_e_Construtores_com_Csharp.Models;


//Pessoa p1 = new Pessoa(nome: "Bernardo", sobrenome: "Silva"); // é a mesma coisa que embaixo
//Pessoa p2 = new Pessoa("Maria", "Luisa");
//Pessoa p3 = new Pessoa("Antonieta", "Costa");


//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.AdicionarAluno(p3);
//cursoDeIngles.ListarAlunos();







// --------------------------------------------------------------------------------------------


// CONCATENAÇÃO DE VALORES

//string numero1 = "10";
//string numero2 = "30";

//string resultado = numero1 + numero2; // resultado vai ser 1030

//int numero1 = 10;
//int numero2 = 30;

//int resultado = numero1 + numero2;

//string numero1 = "10";
//int numero2 = 30;

//string resultado = numero1 + numero2; // resultado vai ser 1030

//Console.WriteLine(resultado);







// --------------------------------------------------------------------------------------------


// FORMATANDO VALORES

// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // aqui formatamos parao modelo do EUA

// decimal valorMonetario = 1582.40M; // preciso por o M no final do valor quando for DECIMAL.

// Console.WriteLine($"{valorMonetario:C}"); // o :C estou formatando o "valorMonetario" no tipo C, que é a ideia de moeda.
// assim, ele já põe o modelo da localização do sistema. Em meu caso, o sistema se localiza no BR, configurado como BR.
// para alterar essa localização, utilizar o "using System.Globalization"

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // outra forma de modificar

// Console.WriteLine(valorMonetario.ToString("C2")); // Modificando de maneira especifica. C é a moeda, 2 são as casas decimais
// Console.WriteLine(valorMonetario.ToString("N2")); // Modificando de maneira especifica. N é de número, então não aparece mais o R$.

// REPRESENTANDO PORCENTAGEM

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P")); // P representa porcentagem

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));








// --------------------------------------------------------------------------------------------


// FORMATANDO DATETIME


// DateTime data = DateTime.Now;

// Console.WriteLine(data); // aqui vem o formato padrão, completo

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // aqui, formatei de uma forma especifica. Importante notar o que vem em maiusculo e o que é minusculo: mês é M (maiusculo) e os minutos é m (minusculo)

// Console.WriteLine(data.ToShortDateString()); // mosta só a data

// Console.WriteLine(data.ToShortTimeString()); // mosta só a hora

// DateTime data2 = DateTime.Parse("17/04/2022 18:00"); // estou dizendo qual data quero. mas o PARSE identifica se é uma data invalida, o próprio programa fala do erro.

// Console.WriteLine(data2);

// // para verificar se tem erro, e NAO parar o programa, usar o TryParse.

// string  dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);

// if(sucesso){
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }else{
//     Console.WriteLine($"{dataString} não é uma data válida");
// }






// --------------------------------------------------------------------------------------------


//      EXEÇÕES E COLEÇÕES, usando a pasta ARQUIVOS
//      APRENDENDO O TRY CATCH - FINALLY

// string[] linhasTeste = File.ReadAllLines("Arquivos/arquivoooLeitura.txt");

// Console.WriteLine("Executou até aqui");


// try{ // sem o try catch, se passassemos o nome do arquivo errado ou o local, o programa pararia e mandaria uma mensagem
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }catch(FileNotFoundException ex){
//     Console.WriteLine($"Ocorreu uma erro na leiturta do arquivo. Arquivo não encontrado. {ex.Message}");

// }catch(DirectoryNotFoundException ex){
//     Console.WriteLine($"Ocorreu uma erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");

// }catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

// }finally{
//     Console.WriteLine("Chegou até aqui");
// }







// --------------------------------------------------------------------------------------------


//      EXEÇÕES E COLEÇÕES --> usando nova classe ExemploExcecao
//      APRENDENDO O THROW

//new ExemploExcecao().Metodo1();








// --------------------------------------------------------------------------------------------

// FILA - QUEUE --> obdessem a ordem FIFO (first in first out), o primeiro a entrar é o primeiro a sair. 

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2); // adiciona um elemento no fim da Queue
// fila.Enqueue(4); 
// fila.Enqueue(6); 
// fila.Enqueue(8); 

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("Removendo o elemento: " + fila.Dequeue()); // o Dequeue vc não passa um elemnto para ele tirar, ele SEMPRE tira o PRIMEIRO
// fila.Enqueue(10); // aqui esse elemnto irá para o FINAL da fila. 

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }








// --------------------------------------------------------------------------------------------

// PILHAS (ideia de pilhando "elementos" em cima de elemento) - STACK --> obdessem a ordem LIFO (last in first out), o últio que entrou, é o primeiro a sair 

Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item); // a ordem fica inversa a ordem escrita!
// }

// Console.WriteLine($"Removendo o elemnto do topo: {pilha.Pop()}"); // igual ao Enqueue, não se passa parametro. Remove o elemento do TOPO

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item); // a ordem fica inversa a ordem escrita!
// }









// --------------------------------------------------------------------------------------------

// DICTIONARY <CHAVE/KEY, VALOR/VALUE> 

// Dictionary<string, string> estados = new Dictionary<string, string>(); // a chave (primeiro elemento"" dentro <> pode ser qualquer tipo e o segundo tbm)

// estados.Add("PE", "Pernambuco");
// estados.Add("PB", "Paraiba");
// estados.Add("BA", "Bahia");

// foreach (KeyValuePair<string, string> item in estados) // pode substituir o keyValuePair<> por var que ele identifica sozinho.
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine($"*---------------------------------*");

// estados.Remove("BA"); // o remove só precisa utilizar a chave
// estados["SP"] = "São Paulo - valor alterado"; // estamos modificando o valor, usando a chave como parametro

// foreach (KeyValuePair<string, string> item in estados) // pode substituir o keyValuePair<> por var que ele identifica sozinho.
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"Valor existente: {chave}");

// }else{
//     Console.WriteLine($"Não existe, é seguro adicionar a chave: {chave}");
// }