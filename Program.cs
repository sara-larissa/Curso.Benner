// See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// Console.WriteLine("Digite seu nome:");
// string nome = Console.ReadLine(); //forma de fazer com o que seja escritono console seja impresso no nome, para várias pessoas conseguirem usar; 

// Console.WriteLine("Digite sua idade:");
// int idade = int.Parse(Console.ReadLine());


// // string nome = "Sara";
// // int idade = 24;

// Console.WriteLine("Seja bem-vinda " + nome + " você tem " + idade + " anos");


Console.WriteLine("Digite a sua idade:");
int idade = int.Parse(Console.ReadLine()); // int.Parse pois é idade e precisava passar para inteiro

if(idade >= 18)
{
    Console.WriteLine("Voto obrigatório");

}else if (idade == 16 || idade == 17)
{
    Console.WriteLine("Voto facultativo");
}else {
     Console.WriteLine("Voto NÃO ALTORIZADO");
}