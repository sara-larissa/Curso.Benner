





// Console.WriteLine("Digite seu nome:");
// string nome = Console.ReadLine(); //forma de fazer com o que seja escritono console seja impresso no nome, para várias pessoas conseguirem usar; 

// Console.WriteLine("Digite sua idade:");
// int idade = int.Parse(Console.ReadLine());


// // string nome = "Sara";
// // int idade = 24;

// Console.WriteLine("Seja bem-vinda " + nome + " você tem " + idade + " anos");

//___________________________________________________________________________________________//

// Console.WriteLine("Digite a sua idade:");
// int idade = int.Parse(Console.ReadLine()); // int.Parse pois é idade e precisava passar para inteiro

// if(idade >= 18)
// {
//     Console.WriteLine("Voto obrigatório");

// }else if (idade == 16 || idade == 17)
// {
//     Console.WriteLine("Voto facultativo");
// }else {
//      Console.WriteLine("Voto NÃO ALTORIZADO");
// }



// bool eMaiorDeIdade = true;

//while
//for
// Do-while

//-----------------------------------
//for:
// Console.WriteLine("Digite um número:");

// int numero = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 70; i++)
// {
//     Console.WriteLine($"{numero} X {i} = {numero * i}");
// }

// Console.WriteLine($"2 X 1 = {2*1}");
// Console.WriteLine($"2 X 2 = {2*2}");
// Console.WriteLine($"2 X 3 = {2*3}");
// Console.WriteLine($"2 X 4 = {2*4}");
// Console.WriteLine($"2 X 5 = {2*5}");
// Console.WriteLine($"2 X 6 = {2*6}");

//*-------------------------------------------*
//WHILE

// int acumulador = 0;
// int numero = 1;

// while (numero !=0) //vai pedindo um monte de número até vc colocar o n° "acumulador" 0; que vai peidr a soma 
// {
//     numero = Convert.ToInt32(Console.ReadLine());
//     acumulador = acumulador + numero;
// }

// Console.WriteLine($"A soma dos números é: {acumulador}");

//*----------------------------------------------*

//OR || -aula 4

// bool ehMaiorDeIdade = false;
// bool PossuiAutorização = false;

// //se os 2 forem falsos ele cai na entrada não permitida, pois se tem altorização entra e se é maior de idade também

// if (ehMaiorDeIdade || PossuiAutorização)
// {
//     Console.WriteLine("Entrada liberada");
// }else{
//     Console.WriteLine("Entrada não permitida");
// }


//AND (&&) E - Aula 05 part 02.

// bool PossuiPresencaMin = true;
// double media = 7.5; //double pois ele aceita casas decimais . Se a média for 6.5 é reprovado

// if (PossuiPresencaMin && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }else{
//     Console.WriteLine("Reprovado");
// }



//NOT (!)  - Aula 05 part 03.

// bool choveu = false; //quando usa o true ele entende que choveu e está tarde então ele não vai pedalar, pois o if pede que não tenha chovido e nem tarde, se estiver false ele vai!
// bool tarde = false;

// if (!choveu && !tarde) //! o resultado oposto
// {
//     Console.WriteLine("Vou pedalar"); //! para inverter a lógica, pois estava choveu e está tarde, vou pedalar e era não choveu e não está tarde vou pedalar
// }else{
//     Console.WriteLine("Não vou pedalar");
// }




/////FOR

// Console.WriteLine("Digite um número");
// int numero = int.Parse(Console.ReadLine());

// for (int contador = 0; contador <=10; contador ++)
// {
//     Console.WriteLine(numero + " X " + contador + " = " + numero*contador);
// }

/////WHILE

// int numero = 0;
// int soma = 0;

// Console.WriteLine("Digite uma sequencia de números e aperte ENTER (0 para SAIR)");
// numero = int.Parse(Console.ReadLine());

// while(numero != 0)

// {   Console.WriteLine("Executando novamente");
//     soma = soma + numero;
//     numero = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("A soma dos números é: " + soma);

//********************************************************//

/// DO WHILE - Sempre executa independente da condição 


int numero = 0;
int soma = 0;
Console.WriteLine("Digite uma sequencia de números e aperte ENTER (0 para SAIR)");
numero = int.Parse(Console.ReadLine());

do{
    Console.WriteLine("Executando novamente");
    numero = int.Parse(Console.ReadLine()); //tem que inverter e colocar essa parte em cima do "numero"
    soma = soma + numero;

}while(numero != 0);

Console.WriteLine("A soma dos números é: " + soma);
