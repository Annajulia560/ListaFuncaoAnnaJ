// See https://aka.ms/new-console-template for more information
//Exercício 1: 
int passos = 0;

while (passos <= 10)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O personagem deu mais um passo.");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Passos atuais: " + passos);
    Console.ResetColor();
    Thread.Sleep(1500);

    passos++;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Você chegou ao seu destino.");
Console.ResetColor();



//Exercício 2: 
Random sorteio = new Random();
int dado = sorteio.Next(1, 7);

while (dado != 6)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("O dado caiu em: " + dado);
    Console.ResetColor();

    Thread.Sleep(1500);

    dado = sorteio.Next(1, 7);
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Você tirou 6! Fim da rolagem.");
Console.ResetColor();



//Exercício 3:
Random sorteio8 = new Random();
int abrirPorta = sorteio.Next(1, 6);

while (abrirPorta != 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A porta continua fechada...");
    Console.ResetColor();

    Thread.Sleep(1500);

    abrirPorta = sorteio.Next(1, 6);
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("A porta se abriu!");
Console.ResetColor();



//Exercício 4: 
Random sorteio7 = new Random();
int itemRaro = (sorteio.Next(1, 11));
int tentativas = 0;

while (itemRaro != 10)
{
    itemRaro = sorteio.Next(1, 11);
    tentativas++;

    if (itemRaro != 10)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você não encontrou o item raro.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Você encontrou o item raro!");
Console.ResetColor();

Thread.Sleep(1000);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Tentativas: " + tentativas);
Console.ResetColor();



//Exercício 5: 
int tentativa = 0;

Random sorteio6 = new Random();
int númeroSecreto = sorteio.Next(1, 21);

while (tentativa != númeroSecreto)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Digite um número entre 1 e 20:");
    Console.ResetColor();

    tentativa = int.Parse(Console.ReadLine());

    if (tentativa < númeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("O número secreto é maior.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
    else if (tentativa > númeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("O número secreto é menor.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
    else if (tentativa == númeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parabéns! Você acertou o número secreto.");
        Console.ResetColor();

        Thread.Sleep(1500);
    }
}



//Exercício 6:
Random sorteio5 = new Random();
int cristal = sorteio.Next(1, 4);
int quantidadeCristais = 0;

while (quantidadeCristais < 5)
{
    cristal = sorteio.Next(1, 4);

    if (cristal == 1)
    {
        quantidadeCristais++;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Você encontrou um cristal!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Quantidade de cristais: " + quantidadeCristais);
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (cristal == 2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Você não encontrou nada.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Quantidade de cristais: " + quantidadeCristais);
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (cristal == 3)
    {
        if (quantidadeCristais > 0)
        {
            quantidadeCristais--;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você perdeu um cristal!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Quantidade de cristais: " + quantidadeCristais);
        Console.ResetColor();
        Thread.Sleep(1500);
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Parabéns! Você coletou 5 cristais!");
Console.ResetColor();



//Exercício 7:
int energia = 100;

Random sorteio4 = new Random();
int gastoEnergia = sorteio.Next(5, 21);

while (energia > 0)
{
    gastoEnergia = sorteio.Next(5, 21);
    energia = energia - gastoEnergia;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("A lanterna gastou " + gastoEnergia + " de energia");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Energia atual: " + energia);
    Console.ResetColor();
    Thread.Sleep(1500);
}

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("A lanterna apagou.");
Console.ResetColor();



//Exercício 8:
int escolha;
Random sorteio1 = new Random();
int evento = sorteio.Next(1, 5);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("O que você deseja fazer?");
Console.WriteLine("1 - Explorar");
Console.WriteLine("2 - Sair");
Console.ResetColor();

escolha = int.Parse(Console.ReadLine());

while (escolha != 2)
{
    evento = sorteio.Next(1, 5);

    if (evento == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Você encontrou moedas.");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (evento == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Você encontrou uma pista.");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (evento == 3)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você encontrou um obstáculo");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    else if (evento == 4)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Nada aconteceu.");
        Console.ResetColor();
        Thread.Sleep(1500);
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Sair");
    Console.ResetColor();

    escolha = int.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Você saiu do jogo.");
Console.ResetColor();



//Exercício 9:
int pontuação = 0;
Random sorteio2 = new Random();
int pontosSorteados = sorteio.Next(5, 16);

while (pontuação < 50)
{
    pontosSorteados = sorteio.Next(5, 16);
    pontuação = pontosSorteados + pontuação;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você ganhou " + pontosSorteados + " pontos!");
    Console.ResetColor();
    Thread.Sleep(1000);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Pontuação atual: " + pontuação);
    Console.ResetColor();
    Thread.Sleep(1500);
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Objetivo concluído!");
Console.ResetColor();



//Exercício 10: 
int vida = 100;
int rodadas = 0;
Random sorteio3 = new Random();
int evento3 = sorteio.Next(1, 5);
Random aleatório = new Random();
int perdeuVidaPerigo = aleatório.Next(5, 25);

while (vida > 0 && rodadas < 10)
{
    evento = sorteio.Next(1, 5);
    rodadas++;

    if (evento == 1)
    {
        vida = vida + 10;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Você encontrou suprimentos!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
    else if (evento == 2)
    {
        vida = vida - 20;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você caiu em uma armadilha.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Perdeu 20 pontos de vida.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
    else if (evento == 3)
    {
        vida = vida + 5;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Você descansou.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
    else if (evento == 4)
    {
        perdeuVidaPerigo = aleatório.Next(5, 25);
        vida = vida - perdeuVidaPerigo;

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Você enfrentou um perigo!");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Perdeu " + perdeuVidaPerigo + " de vida.");
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Número da rodada: " + rodadas);
        Console.ResetColor();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Vida atual: " + vida);
        Console.ResetColor();
        Thread.Sleep(2000);
    }
}

if (vida > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Você sobreviveu aos eventos!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você não conseguiu sobreviver.");
}

Console.ResetColor();
