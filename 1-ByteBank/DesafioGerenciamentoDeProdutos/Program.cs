using DesafioGerenciamentoDeProdutos;

Produto produto1 = new(){
    nome = "Arroz Prato Fino Integral 2kg",
    fabricante = " Prato Fino",
    codigoDeBarra = "45645XDR",
    valorUnitario = 6.45,
    valorDeCompra = 7.90,
    quantidadeEmEstoque = 136,
};



Console.WriteLine("Nome: " + produto1.nome);
Console.WriteLine("Fabricante: " + produto1.fabricante);
Console.WriteLine("Codigo de barras: " + produto1.codigoDeBarra);
Console.WriteLine("Valor unitário: " + produto1.valorUnitario);
Console.WriteLine("Valor de compra: " + produto1.valorDeCompra);
Console.WriteLine("Quantidade em estoque: " + produto1.quantidadeEmEstoque);

Console.ReadKey();

