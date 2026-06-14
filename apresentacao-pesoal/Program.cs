//exercicio 1

using System.Runtime.CompilerServices;

var nome = "Felipe Dias";
int idade = 32;
string cidade = "Rio de Janeiro";
var profissao = "Desenvolvedor full stack";

Console.WriteLine("======= Exercicio 01 =======");
Console.WriteLine("");

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cidade: {cidade}");
Console.WriteLine($"Profissão dos sonhos: {profissao}");
Console.WriteLine("======= Fim =======");
Console.WriteLine("");

//exercicio 2 
Console.WriteLine("======= Exercicio 02 =======");
Console.WriteLine("");
var nomeProduto = "mouse";
double preco = 140.99;
int quantidadeEstoque =  30;

Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço: R$ {preco}");
Console.WriteLine($"Quantidade: {quantidadeEstoque}");
Console.WriteLine("======= Fim =======");
Console.WriteLine("");

//exercicio 3
Console.WriteLine("======= Exercicio 03 =======");
Console.WriteLine("");

int numero3 = 3;
int numero4 = 4;

var soma = numero3 + numero4;
var subtracao = numero3 - numero4;
var multiplicacao = numero3 * numero4;
var divisao = numero3 / numero4;
Console.WriteLine($"Resultado da soma:{soma}");
Console.WriteLine($"Resultado da subtração:{subtracao}");
Console.WriteLine($"Resultado da multiplicacao:{multiplicacao}");
Console.WriteLine($"Resultado da divisão:{divisao}");
Console.WriteLine("======= Fim =======");
Console.WriteLine("");

Console.WriteLine("======= Exercicio 04 =======");
Console.WriteLine("");

//exercicio 4
string menorOuMaior = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine($"{nome} é {menorOuMaior}");
Console.WriteLine("======= Fim =======");
Console.WriteLine("");

//exercicio 5
Console.WriteLine("======= Exercicio 05 =======");
Console.WriteLine("");

string exibirMensagem()
{
    return "Estou aprendendo C# e criando minhas primeiras funções!";
}
Console.WriteLine(exibirMensagem());
Console.WriteLine("======= Fim =======");
Console.WriteLine("");

Console.WriteLine("======= Desafio Extra =======");
Console.WriteLine("Insira o valor de x");
var x = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor de y");
var y = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor de z");
var z = int.Parse(Console.ReadLine());

int  CalcularMedia( int x, int y, int z){
    return (x + y + z) / 3;
}
Console.WriteLine($"A média dos números é: {CalcularMedia(x, y, z)}");