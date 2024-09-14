// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Digite a palavra a ser usada");
string palavra = Console.ReadLine();
int contador = 0;

foreach (var letra in palavra)
{
    if(letra.Equals('a') || letra.Equals('A'))
        contador++;

}
Console.WriteLine($"A palavra tem: {contador} letras 'A'");