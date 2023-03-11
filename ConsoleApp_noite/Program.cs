// See https://aka.ms/new-console-template for more information
using ConsoleApp_noite;


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




