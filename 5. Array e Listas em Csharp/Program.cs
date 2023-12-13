//  ARRAYS 

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 70;
// arrayInteiros[1] = 40;
// arrayInteiros[2] = 32;


// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length); // observar o que o Copy pede, para entender


//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // serve para redimencionar o tamanho do array


// Percorrendo o array com o FOR
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }



// Percorrendo o array com o FOREACH

// int contadorForEach = 0; --> esses comentarios mostram como fazer o for each ter os mesmos resultados que o for
// foreach (int valor in arrayInteiros)
// {
//     // Console.WriteLine($"Posição Nº {contadorForEach} - {valor}");
//     Console.Write(valor);
//     // contadorForEach++;
// }


// -------------------------------------------------------------------------------------------------------------


// LISTA

using System.Diagnostics.Contracts;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("PE");
listaString.Add("MG");


// Percorrendo a lista com o FOR
for (int contador = 0; contador < listaString.Count; contador++) // Count é o mesmo que o Length
{
    Console.Write($"Posição Nº {contador} - {listaString[contador]}");
}


// Percorrendo a lista com o FOREACH
int contadorForEach = 0;
foreach(string item in listaString){
    Console.Write($"Posição Nº {contadorForEach} - {item}");
    contadorForEach++;
}