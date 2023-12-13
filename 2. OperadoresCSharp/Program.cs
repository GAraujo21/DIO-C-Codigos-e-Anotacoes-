//  --- OPERADORES BÁSICOS --- 

// int a = 1;
// int b = 2;

// int c = a +b;

// //c = c + 5; // 3 + 5
// c += 5; //msm coisa que em cima

// c -= 5; 

// c /= 5; // divisão

// c *= 5; //multiplicação

// Console.WriteLine(c);



//  --- CAST - CASTING ---

//int a = Convert.ToInt32("5"); // Convert é uma classe, usando o método 'ToInt32' que converte a string "5" para int;
// vale salientar que usasse o ToInt32 e não o 64, pq o 64 é para long.

// int a = int.Parse("5"); // se põe o int.Parse("5c") da erro pois misturou numero com char.

// Console.WriteLine(a);

// Quando usar o Parse x Convert ? 
// A diferença está no tratamento de exeções. O convert não da erro quando se depara com o nulo, e converte ele para 0. Exemplo: int a = Convert.ToInt32(null) --> isso resultara em 0

// Fazendo isso com Parse, exemplo: int a = int.Parse(null) --> vai dar erro, pois o Parse NÃO PODE ser nulo!



//  --- CAST - CASTING ---
//          ToString 

// int inteiro = 5;
// string a = inteiro.ToString(); // isto é o mesmo que Convert.ToString(inteiro);

// Console.WriteLine(a);



//  --- CAST - CASTING ---
//        Implícito --> conversão que não precisa 'mostrar' diretamente

// int a = 5;
// double b = a; // aqui está ocorrendo um CASTNG implícito!

// int a = 5;
// long b = a; // o inverso não poderia ser convertido, como de long para int. Nesse caso, precisaria do casting direto

// long a = 5;
// int b = Convert.ToInt32(a); 

// long a = long.MaxValue;
// int b = Convert.ToInt32(a); // esse jeito da errado pois o volume máximo do long é mt grande para 'caber' no int.

//Console.WriteLine(b);



// --- CASTING DE FORMA SEGURA ---

// string a = "15";

// int b = Convert.ToInt32(a); 

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!"); // dessa forma da certo e aparesse esta mensagem!

// string a = "15-";

// int b = Convert.ToInt32(a); 

// Console.WriteLine(b); // aqui da erro, não é possivel converter 15- para int. logo, não aparece a msg abaixo.
// Console.WriteLine("Conversão realizada com sucesso!");

// uma forma segura de, se der erro o programa avisar ao usuario sobre o erro e não interromper o programa: 

// string a = "15";

// int b = 0;

// int.TryParse(a, out b); // ele vai pegar o a e tentar converter em int, se não conseguir ele mandará o b

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");





// ----------------------------------------------------------------------------------------------------------------------






// --- OPERADORES CONDICIONAIS --- 
//         IF - IF aninhado

// int quantidadeEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda: {possivelVenda}");

// if (quantidadeCompra == 0){

//     Console.WriteLine("Venda inválida");
// }else if(possivelVenda){

//     Console.WriteLine("Venda realizada");
// }else{

//     Console.WriteLine("Não temos a quantidade desejada em estoque");
// }



// --- OPERADORES CONDICIONAIS --- 
//       SWITCH CASE

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }

// outra forma de fazer com o if
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u"){
//     Console.WriteLine("Vogal");
// }else{
//     Console.WriteLine("Não é uma vogal");
// }


// Essa seria uma forma de fazer com o if
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");   
// }
// else if (letra == "b"){
//     Console.WriteLine("Vogal");
// }
// else{
//     Console.WriteLine("Não é uma vogal");
// }



// --------------------------------------------------------------------------------------------------



// --- OPERADORES LÓGICOS --- 
//       || (OR) / && (AND) / ! (NOT)

// using System.IO.Compression;

// int a = 1;
// int b = 2;

// if(a + b == 3 || a+b > 5){
//     Console.WriteLine("Q lindo");
// }

// if (a == 1 && b == 3){
//     Console.WriteLine("A = 1 e B = 3");
// }

// if (b != 3){
//     Console.WriteLine("B não é 3");
// }

// bool choveu = true;
// bool estaTarde = false;

// if(!choveu && !estaTarde){
//     Console.WriteLine("vou pedalar!");
// }