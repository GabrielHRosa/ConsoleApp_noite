// See https://aka.ms/new-console-template for more information
using ConsoleApp_noite;
using ConsoleApp_noite.Heranca;
using ConsoleApp_noite.ExercicioLista;


Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao() + " " + p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja Skol 1 litrão");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco endereco = new Endereco(
    "Rua Mario Miziara",
    "91",
    "Sobral",
    "15906304",
    "Taquaritinga",
    "SP"
    );

Endereco endereco2 = new Endereco(
    "Rua dos bobo",
    "952",
    "Sobral",
    "15906304",
    "Taquaritinga",
    "SP"
    );

Cliente c1 = new Cliente(1, "Gabriele", "991340447",endereco);
Cliente c2 = new Cliente(2, "Gabriele", "991340447", endereco);
Cliente c3 = new Cliente(3, "Gabriele", "991340447", endereco);
Cliente c4 = new Cliente(4, "Gabriele", "991340447", endereco);
Cliente c5 = new Cliente(5, "Gabriele", "991340447", endereco);

Console.WriteLine(c2.getEndereco().getRua() + "" + c2.getEndereco().getNumero()); // (.) é utilizado para acessar o conteúdo do objto

c2.getEndereco().setNumero("136");

Console.WriteLine(c2.getEndereco().getRua() + "" + c2.getEndereco().getNumero());

c2.setEndereco(endereco2);

Console.WriteLine(c2.getEndereco().getRua() + "" + c2.getEndereco().getNumero());

Console.WriteLine(c2.getEndereco().EnderecoCompleto());

Carro gol = new Carro();
gol.temMotor = true;
gol.numeroPortas = 4;
gol.numeroAssento = 5;

Bike caloi = new Bike();

caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssento = 1;

gol.fabricante = "VW";
gol.cintoSeguranca = true;
gol.arCondicionado = false;

Carro Saveiro = new Carro();
Carro Palio = new Carro();
Carro Uno = new Carro();

Saveiro.fabricante = "VW";
Palio.fabricante = "Fiat";
Uno.fabricante = "Fiat";

Bike speed = new Bike();
speed.temMotor = true;
speed.numeroPortas = 0;

Console.WriteLine(speed.ExibirDados());
Console.WriteLine(gol.ExibirDados());

Console.WriteLine("-------------------------------------------------------");

List<Carro> listaCarros = new List<Carro>();
listaCarros.Add(gol);
listaCarros.Add(Palio);
listaCarros.Add(Uno);
listaCarros.Add(Saveiro);

Console.WriteLine(listaCarros[0].fabricante);
listaCarros.Remove(Palio);

//1ª forma de percorrer a lista

for (int i = 1; i < listaCarros.Count; i++)//qtd de itens da lista (.Count)
{
    Console.WriteLine(listaCarros[i].ExibirDados());
}

//2ªforma para lista

foreach (var item in listaCarros)
{
    Console.WriteLine(item.ExibirMarca());
}

Console.WriteLine("-------------------------------------------------------");
//--------------------------------------------------------------------------------------------------
// Imprima na tela todos os clientes desse contexto;
//Dica crie uma lista para eles
Console.WriteLine("-------------------------------------------------------");

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);
listaCliente.Add(c5);

foreach (var item in listaCliente)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("-------------------------------------------------------");
//------------------------------------------------------------------------------------------------
// Crie uma lista com 560 produtos
//Imprima na tela

List<Produto> listaProduto = new List<Produto>();

for (int i = 0; i <= 560; i++)
{

    Produto p = new Produto(i, i * 3, "Produto " + i);

    listaProduto.Add(p);
}

foreach (var item in listaProduto)
{
    Console.WriteLine(item.ExibirDados());
}
Console.WriteLine("-------------------------------------------------------");
//-------------------------------------------------------------------------------------------------
//crie uma lista que aceite qualquer tipo de veiculo
//imprima na tela");

List<Veiculo> listaVeiculo = new List<Veiculo>();
listaVeiculo.Add(gol);
listaVeiculo.Add(Saveiro);
listaVeiculo.Add(Palio);
listaVeiculo.Add(Uno);
listaVeiculo.Add(speed);
listaVeiculo.Add(caloi);

foreach (var item in listaVeiculo)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("-------------------------------------------------------");

//-------------------------------------------------------------------------------------------------
/*
Client v1 = new Client();
v1.Nome = "Robson ";
v1.Telefone = "16987562568";
v1.Endereco = "Rua 1 de Agosto";
v1.IdVenda = 1;
v1.DataVenda = "10/02/2023";
v1.Preco = 150;
v1.Descricao = "Mouse Razer";

Client v2 = new Client();
v2.Nome = "Claudio ";
v2.Telefone = "16999562587";
v2.Endereco = "Rua Margarida";
v2.IdVenda = 2;
v2.DataVenda = "10/03/2023";
v2.Preco = 45;
v2.Descricao = "Caixa de Som";

Client v3 = new Client();
v3.Nome = "Silas ";
v3.Telefone = "1633427070";
v3.Endereco = "Av. Nações Unidas";
v3.IdVenda = 3;
v3.DataVenda = "10/09/2022";
v3.Preco = 50;
v3.Descricao = "Teclado";

List<Client> listaClient = new List<Client>();
listaClient.Add(v1);
listaClient.Add(v2);
listaClient.Add(v3);

foreach (var item in listaClient)
{
    Console.WriteLine(item.ExibirVenda());
}
*/




