
/*Exercício 1 
int posição = 0;
while (posição < 10)
{
    Console.WriteLine("O personagem andou um passo. Passos atuais:" + posição);
    posição ++;
}
Console.WriteLine("Você chegou ao seu destino");


//Exercício 2 
Random sorteio = new Random();
int dado = sorteio.Next(1, 7);
while (dado != 6)
{
    Console.WriteLine("Você tirou; " + dado);
    dado = sorteio.Next(1, 7);
}
Console.WriteLine("Você tirou 6! Fim da rolagem");

//Exercício 3 
Random sorteio1  = new Random();
int numero = sorteio1.Next(1, 6);
while (numero != 5)
{
    Console.WriteLine("A porta continua fechada");
    numero = sorteio1.Next(1, 6);
}
Console.WriteLine("A porta se abriu");

//Exercício 4 
Random sorteio3 = new Random();
int numero1 = sorteio3.Next(1, 11);
int tentativa = 1;
while (numero1 != 10)
{
    tentativa++;
    numero1 = sorteio1.Next(1, 11);
}
Console.WriteLine("Você encontrou o item raro! Tentativas:" + tentativa);

 Exercício 5

Random sorteio = new Random();
int najulia = sorteio.Next(1, 21);
Console.WriteLine("Qual o numero que o damaceno ta pensando?");
int numero = int.Parse(Console.ReadLine());
while (najulia != numero)
{
    if (najulia > numero)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    if (najulia < numero)
    {
        Console.WriteLine("O número secreto é menor.");
    }
    if (najulia != numero)
    {
        Console.WriteLine("Você acertou!");
    }
}

//Exercício 6 
Random sorteio = new Random();
int cristais  = 0;
while (cristais < 5)
{
    int evento = sorteio.Next(1, 4);
    if (evento == 1)
    {
        cristais++;
        Console.WriteLine("Você perdeu um cristal. Cristais:" + cristais);
    }
    else if (evento == 2)
    {
        Console.WriteLine("Você não encontrou nada.");
    }
    else
    {
        if (cristais > 0)
        {
            cristais--;
            Console.WriteLine("Você perdeu um cristal. Cristais: " + cristais);
        }
        else
        {
            Console.WriteLine("Você não tinha cristais para perder.");
        }
    }
}
Console.WriteLine("Você coletou os 5 cristais!");


//Exercício 7
Random sorteio = new Random();
int energia = 100;
while (energia > 0)
{
    int gasto = sorteio.Next(5, 21);
    energia -= gasto;
    Console.WriteLine("A lanterna gastou" + gasto + "de energia. Energia atual:" + energia);
}
Console.WriteLine("A lanterna apagou");

//Exerxicio 8
Random sorteio = new Random();
int opção  = 0;
while (opção != 2)
{
    Console.WriteLine("1 - Explorar");
    Console.WriteLine("2 - Sair");
    opção = Convert.ToInt32(Console.ReadLine());
    if (opção == 1)
    {
        int evento = sorteio.Next(1,5);
        switch (evento)
        {
            case 1:
                Console.WriteLine("Você encontrou moedas")
                    ; break;
             case 2:
                Console.WriteLine("Você encontrou uma pista");
                break;
                case 3:
                Console.WriteLine("Você encontrou um obstáculo")
                    ; break;
            case 4:
                Console.WriteLine("Nada aconteceu.");
                break;
        }
    }
}
Console.WriteLine("Fim da exploração.");


//Exercício 9
Random sorteio = new Random();
int pontos = 0;
while (pontos < 50)
{
    int ganho = sorteio.Next(5, 16);
    pontos += ganho;
    Console.WriteLine("Você ganhou " + ganho + " pontos. Pontuação atual: " + pontos);
}
Console.WriteLine("Objetivo concluído!");

*///Exercício 10
Random sorteio = new Random();
int vida = 100;
int rodadas = 0;
while (vida > 0 && rodadas < 10)
{
    rodadas++;
    int evento = sorteio.Next(1, 5);
    switch (evento)
    {
        case 1:
            vida += 10;
            Console.WriteLine("Encontrou suprimentos.");
            break;

        case 2:
            vida -= 20;
            Console.WriteLine("Caiu em armadilha.");
            break;

        case 3:
            vida += 5;
            Console.WriteLine("Descansou.");
            break;

        case 4:
            int dano = sorteio.Next(5, 26);
            vida -= dano;
            Console.WriteLine("Enfrentou perigo e perdeu " + dano + " de vida.");
            break;
    }
    Console.WriteLine("Vida atual: " + vida);
}
if (vida > 0)
{
    Console.WriteLine("Você sobreviveu aos eventos!");
}
else
{
    Console.WriteLine("Você não conseguiu sobreviver.");
}