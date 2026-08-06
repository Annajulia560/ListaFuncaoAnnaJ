// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ronaldo!");

Console.WriteLine("\né lindo!");

// Variáveis (algo que varia) 
//Variável de texto (tipo, nome, valor)

string najulia = "ronaldo";

Console.WriteLine(najulia);

najulia = "sexy";

Console.WriteLine(najulia);

Console.WriteLine(100);

najulia = "billie eilish";

// Variável do número 

Console.WriteLine(20 + 20 + 20 + 5);

Console.WriteLine("20 + 20 + 20 + 7");

int numero = 20;

// int é pra números inteiros

float numero2 = 30.345f;

// float é pra númerows quebrados, grande!

double numero3 = 69.69;

// double tem limite de decimal pequeno;

int dobro = numero + numero;

// Variáveis que usamos pouco (variaveis de booleanas e caracteres)

// variável de verdadeiro ou falso ou booleana (true or false)

bool envenenado = false;

// Variaveis de caracter unico ( variavel que recebe apenas um caractere)

char valor_unico = 'b';

//2ª Atividade experimental durante a aula.
 
string nome = "";

int idade = 0;

Console.WriteLine("Qual é o seu nome?");

nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade");

idade = int.Parse(Console.ReadLine());

if (nome == "davi" && idade >= 18)

{

    Console.WriteLine(nome + " pode ser preso");

}

else

{

    Console.WriteLine(nome + " não pode ser preso");

}

if (nome == "heitor" || idade >= 18)

{

    Console.WriteLine(nome + " pode ser preso");

}

else

{

    Console.WriteLine(nome + " não pode ser preso");

}

//switch 

string casa_Hp = "";

Console.WriteLine("Qual casa do harry potter gostaria de participar?" +

    "\nOpção 1: Grifinória" +

    "\nOpção 2: Sonserina" +

    "\nopção 3: Lufalufa" +

    "\nOpção 4: Corvinal");

casa_Hp = Console.ReadLine();

switch (casa_Hp)

{

    case "Grifinória":

        Console.WriteLine("Você ta na casa do Harry potter");

        break;

    case "Sonserina":

        Console.WriteLine("Você ta na casa do Draco Malfoy <3");

        break;

    case "Lufalufa":

        Console.WriteLine("Você ta na casa do siminino");

        break;

    case "Corvinal":

        Console.WriteLine("Você ta na casa da Luna");

        break;

    default:

        Console.WriteLine("Você entendeu oq eu quis dizer? Tenta de novo");

        break;

}


