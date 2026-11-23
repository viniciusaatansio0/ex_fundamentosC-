//* Exercício 1 — Calculando uma compra
// Console.Write("Digite o nome do produto: ");
// string NomeProduto = Console.ReadLine();
// Console.Write("Digite a quantidade do produto: ");
// int Quantidade = int.Parse(Console.ReadLine());
// Console.Write("Digite o preço unitario do produto: ");
// decimal PrecoUnitario = decimal.Parse(Console.ReadLine());

// decimal Total = Quantidade * PrecoUnitario;
// Console.WriteLine($"O nome do produto é {NomeProduto}, a Quantidade é {Quantidade} e o preço unitário é {PrecoUnitario:C}. O total da compra é: {Total:C}");


//* Exercício 2 — Classificação de notas
// Console.Write("Digite o nome do(a) aluno(a): ");
// string NomeAluno = Console.ReadLine();
// Console.Write("Digite a nota desse(a) aluno(a): ");
// int NotaAluno = int.Parse(Console.ReadLine());

// if(NotaAluno >= 7 && NotaAluno <= 10)
// {
//     Console.WriteLine($"Parabens!!! o(a) {NomeAluno} está aprovado.");
// }
// else
// if (NotaAluno >= 5 && NotaAluno < 7)
// {
//     Console.WriteLine($"Melhore!!! o(a) {NomeAluno} está de recuperação.");   
// }
// else
// if(NotaAluno < 5 && NotaAluno >= 0)
// {
//     Console.WriteLine($"Não foi dessa vez!!! o(a) {NomeAluno} está reprovado.");
// }
// else
// {
//     Console.WriteLine("Nota invalida, Digite novamente.");
// }


//* Exercício 3 — Adivinhe o número
// int NumeroSecreto = 65;
// int Palpite;
// int TotalPalpite = 0;

// do
// {
//     Console.Write("Tente adivinhar meu numero secreto, qual seu palpite: ");
//     Palpite = int.Parse(Console.ReadLine());
//     TotalPalpite++;

//     if(Palpite < NumeroSecreto)
//     {
//         Console.WriteLine("O numero secreto é maior.");
//     }
//     else if(Palpite > NumeroSecreto)
//     {
//         Console.WriteLine("O numero secreto é menor.");
//     }
//     else
//     {
//         Console.WriteLine($"Parabens! você acertou o numero secreto: {NumeroSecreto}.");
//         Console.WriteLine($"Total de palpites: {TotalPalpite}");
//     }
// } while(Palpite != NumeroSecreto);


//* Exercício 4 — Calculadora com métodos
// Console.Write("Digite o primeiro numero: ");
// double PrimeiroNumero = double.Parse(Console.ReadLine()!);

// Console.Write("Digite o segundo numero: ");
// double SegundoNumero = double.Parse(Console.ReadLine()!);

// Console.WriteLine("""
// O que deseja fazer?
// 1 - somar
// 2 - multiplicar
// """);

// int OpcaoDesejada = int.Parse(Console.ReadLine()!);

// if (OpcaoDesejada == 1)
// {
//     Somar();
// }
// else if (OpcaoDesejada == 2)
// {
//     Multiplicar();
// }
// else
// {
//     Console.WriteLine("Opção inválida.");
// }

// void Somar()
// {
//     double Resultado = PrimeiroNumero + SegundoNumero;
//     Console.WriteLine($"O resultado da soma de {PrimeiroNumero} + {SegundoNumero} = {Resultado}");
// }

// void Multiplicar()
// {
//     double Resultado = PrimeiroNumero * SegundoNumero;
//     Console.WriteLine($"O resultado da multiplicação de {PrimeiroNumero} x {SegundoNumero} = {Resultado}");
// }


//* Exercício 5 — Cadastro de notas em um array
// double[] Notas = new double[3];

// for(int I = 0; I < Notas.Length; I++)
// {
//     Console.Write($"Digite a {I + 1}° nota: ");
//     Notas[I] = double.Parse(Console.ReadLine());
// }

// double Soma = 0;
// foreach (var Nota in Notas)
// {
//     Soma += Nota;
// }

// double Media = Soma / Notas.Length;

// Console.WriteLine($"Media das notas: {Media:F2}");


//* Exercício 6 — Lista de produtos
// List<string> Produtos = new List<string>();

// for (int I = 1; I <= 3; I++)
// {
//     Console.Write($"Digite o nome do {I}º produto: ");
//     string NomeProduto = Console.ReadLine() ?? "";
//     Produtos.Add(NomeProduto);
// }

// Console.WriteLine("--- PRODUTOS CADASTRADOS ---");
// foreach (var Item in Produtos)
// {
//     Console.WriteLine($"- {Item}");
// }

// Console.Write("Digite um produto para buscar na lista: ");
// string ProdutoBusca = Console.ReadLine() ?? "";

// if (Produtos.Contains(ProdutoBusca, StringComparer.OrdinalIgnoreCase))
// {
//     Console.WriteLine($"O produto '{ProdutoBusca}' ESTÁ na lista!");
// }
// else
// {
//     Console.WriteLine($"O produto '{ProdutoBusca}' NÃO foi encontrado na lista.");
// }

// Console.Write("Digite o nome do produto que deseja remover: ");
// string ProdutoRemover = Console.ReadLine() ?? "";

// if (Produtos.Remove(ProdutoRemover))
// {
//     Console.WriteLine($"Produto '{ProdutoRemover}' removido com sucesso!");
// }
// else
// {
//     Console.WriteLine($"Não foi possível remover: '{ProdutoRemover}' não encontrado.");
// }

// Console.WriteLine("--- LISTA ATUALIZADA DE PRODUTOS ---");
// foreach (var Item in Produtos)
// {
//     Console.WriteLine($"- {Item}");
// }