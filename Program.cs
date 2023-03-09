
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using T16CodBackEnd.Classes;

// metodo construtor
PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica();

//novaPf.nome = "Ana";
//novaPf.cpf = 123456;
//novaPf.dataNasc = new DateTime(1998, 01, 01);
//novaPf.endereco = "Rua Lua, 1";
//novaPf.rendimento = 10000.00f;

//novaPj.rendimento = 20000.00f;

//Console.WriteLine("Nome: " + novaPf.nome);
//Console.WriteLine("CPF: " + novaPf.cpf);
//Console.WriteLine("Data de Nascimento: " + novaPf.dataNasc);
//Console.WriteLine("Endereço: " + novaPf.endereco);
//Console.WriteLine("Rendimento: R$ " + novaPf.rendimento + ",00");


//Console.WriteLine("Nome do Funcionário: " + novaPf.nome);
//Console.WriteLine($"Nome do Funcionário: {novaPf.nome} - CPF: {novaPf.cpf}");

//Console.WriteLine(novaPf.CalcularImposto(novaPf.rendimento));
//Console.WriteLine(novaPj.CalcularImposto(novaPj.rendimento));

float impostoPagar = novaPj.CalcularImposto(10000.5f);
Console.WriteLine($"O imposto a pagar será no valor de: {impostoPagar.ToString("C")}");