//exercicio 1

var nome = "Felipe Dias";
int idade = 32;
string cidade = "Rio de Janeiro";
var profissao = "Desenvolvedor full stack";

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Cidade: {cidade}");
Console.WriteLine($"Profissão dos sonhos: {profissao}");

//exercicio 2 

var nomeProduto = "mouse";
double preco = 140.99;
int quantidadeEstoque =  30;

Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço: R$ {preco}");
Console.WriteLine($"Quantidade: {quantidadeEstoque}");


//exercicio 3

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


//exercicio 4
string menorOuMaior = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine($"{nome} é {menorOuMaior}");

//exercicio 5
string exibirMensagem()
{
    return "Estou aprendendo C# e criando minhas primeiras funções!";
}

Console.WriteLine(exibirMensagem());