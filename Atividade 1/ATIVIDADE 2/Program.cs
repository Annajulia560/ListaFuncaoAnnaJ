// See https://aka.ms/new-console-template for more information
//Exercício 1 
string dificuldade = "";
Console.WriteLine("Qual dificuldade você escolhe?" +
    "\n1 - Fácil" +
    "\n2 - Normal" +
    "\n3 - Dificíl");
dificuldade = Console.ReadLine();
switch (dificuldade)
{
    case "Fácil":
        Console.WriteLine("Você escolheu a modalidade 'Fácil'");
        break;
    case "Normal":
        Console.WriteLine("Você escolheu a modalidade 'Normal'");
        break;
    case "Difícil":
        Console.WriteLine("Você escolheu a modalidade 'Difícil'");
        break;

}

//Exercício 2
string resposta;
string resposta1;

Console.WriteLine("É a sua primeira vez jogando?");
resposta = Console.ReadLine();
Console.WriteLine("Deseja ver o tutorial?");
resposta1 = Console.ReadLine();

if (resposta == "sim" && resposta1 == "sim")
{
    Console.WriteLine("Seu tutorial...");
}
else
{
    Console.WriteLine("Ok!");
}


//Exercício 3
Console.WriteLine("Você está escondido?");
string escondido = Console.ReadLine();
Console.WriteLine("O inimigo está olhando na sua direção?");
string inimigo = Console.ReadLine();
Console.WriteLine("Qual seu nivel de barulho");
int barulho = int.Parse(Console.ReadLine());
if (escondido == "não" && inimigo == "sim" || barulho > 70)
{
    Console.WriteLine("você foi detectado");
}
else
{
    Console.WriteLine("você passou despercebido");
}


//Exercício 4
Console.WriteLine("Qual sua quantidade de madeira?");
int madeira = int.Parse(Console.ReadLine());
Console.WriteLine("Qual sua quantidade de pedra?");
int pedra = int.Parse(Console.ReadLine());
Console.WriteLine("Você tem a receita?\nsim\nnão");
string receita = Console.ReadLine();
if (receita == "sim" && madeira >= 3 && pedra >= 2)
{
    Console.WriteLine("Lança criada com sucesso");
}
else
{
    Console.WriteLine("Você não possui os itens necessarios");
}


//Exercício 5 
Console.WriteLine("Gostaria de possuir qual clima nesta fase? ");
Console.ReadLine();
string clima = "";
Console.WriteLine("Gostaria de possuir qual clima nesta fase? " +
    "\nOpção 1: Sol" +
    "\nOpção 2: Chuva" +
    "\nopção 3: Neve" +
    "\nOpção 4: Tempestade");
clima = Console.ReadLine();
switch (clima)
{
    case "Sol":
        Console.WriteLine("Velocidade normal");
        break;
    case "Chuva":
        Console.WriteLine("jogador escorrega");
        break;
    case "Neve":
        Console.WriteLine("velocidade reduzida");
        break;
    case "Tempestade":
        Console.WriteLine("visão reduzida");
        break;
    default:
        Console.WriteLine("clima inválido");
        break;
}


//Exercício 6 
Console.WriteLine("Qual seu nível de reputação?");
int nível = int.Parse(Console.ReadLine());
Console.WriteLine("Entregou o presente ao NPC?");
string presente = Console.ReadLine();
if (presente == "sim" || nível > 50)
{
    Console.WriteLine("O NPC revelou uma informação secreta1");
}
else
{
    Console.WriteLine("O NPC não confia em você ainda");
}

//Exercício 7 
string símbolo;
Console.WriteLine("Escolha seu símbolo!" +
    "\n Opção 1: Lua" +
    "\n Opção 2: Sol" +
    "\n Opção 3: Estrela" +
    "\n Opção 4: Chama");
símbolo = Console.ReadLine();
switch (símbolo)
{
    case "Lua":
        Console.WriteLine("Uma ponte aparece");
        break;
    case "Sol":
        Console.WriteLine("A sala fica iluminada");
        break;
    case "Estrela":
        Console.WriteLine("Um item secreto surge");
        break;
    case "Chama":
        Console.WriteLine("Uma armadilha é ativada");
        break;
    default:
        Console.WriteLine("Nada aconteceu");
        break;
}


//Exercício 8
Console.WriteLine("informe a bateria da camera:");
int camera = int.Parse(Console.ReadLine());
Console.WriteLine("existem monstros na tela?\nsim\nnão");
string monstro = Console.ReadLine();
Console.WriteLine("apertar botão de ligar?\nsim\nnão");
string ligar = Console.ReadLine();
if (camera > 0 && ligar == "sim" && monstro == "sim")
{
    Console.WriteLine("cema assustadora gravada");
}
else if (monstro == "não")
{
    Console.WriteLine("você gravou mas nada de interessante apareceu");
}
else if (camera == 0)
{
    Console.WriteLine("a camera está sem bateria");
}


//Exercício 9 
string ataque = "";
Console.WriteLine("escolha o seu ataque:" +
    "\nataque leve " +
    "\nataque pesado" +
    "\nespecial" +
    "\nesquivar");
ataque = Console.ReadLine();
Console.WriteLine("informe sua energia:");
int energia = int.Parse(Console.ReadLine());
switch (ataque)
{
    case "ataque leve":
        Console.WriteLine("realizada");
        break;
    case "ataque pesado":
        if (energia >= 15)
        {
            Console.WriteLine("realizada");
        }
        else
        {
            Console.WriteLine("energia insuficiente");
        }
        break;

    case "especial":

        if (energia >= 30)
        {
            Console.WriteLine("realizada");
        }
        else
        {
            Console.WriteLine("energia insuficiente");
        }
        break;
    case "esquivar":
        if (energia >= 10)
        {
            Console.WriteLine("realizada");
        }
        else
        {
            Console.WriteLine("energia insuficiente");
        }
        break;
    default:
        Console.WriteLine("nada aconteceu");
        break;
}


//Exercício 10
string area = "";
Console.WriteLine("escolha o tipo de area:" +
    "\nfloresta " +
    "\nruinas" +
    "\nlaboratorio" +
    "\npraia");
area = Console.ReadLine();
Console.WriteLine("insira seu nivel");
int nivel = int.Parse(Console.ReadLine());
Console.WriteLine("você possui item especial?\nsim\nNão");
string item = Console.ReadLine();
Console.WriteLine("você está acompanhado de um aliado?\nsim\nNão");
string aliado = Console.ReadLine();
switch (area)
{
    case "floresta":
        Console.WriteLine("animal selvagem apareceu");
        break;
    case "ruinas":
        Console.WriteLine("armadilha antiga foi ativada");
        break;
    case "laboratorio":
        Console.WriteLine("robo descontrolado apareceu");
        break;
    case "praia":
        Console.WriteLine("tempesdade repentina apareceu");
        break;
    default:
        Console.WriteLine("nada aconteceu");
        break;
}

if (aliado == "sim" || item == "sim" && nivel >= 5)
{
    Console.WriteLine("você resolveu o evento com sucesso");
}
else
{
    Console.WriteLine("você não estava preparado para este evento");
}