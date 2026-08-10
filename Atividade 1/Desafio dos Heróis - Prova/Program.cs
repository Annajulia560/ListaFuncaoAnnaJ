// See https://aka.ms/new-console-template for more information

Random random = new Random();
string nomejogador;
string[] heróis =
{
    " Guerreiro -",
    " Mago -",
    " Arqueiro -",
    " Paladino -",
    " Ladino -"
};
int[] força =
{
    15,
    12,
    14,
    17,
    13
};
string[] desafios =
{
    "- Dragão",
    "- Monstro",
    "- Gigante",
    "- Feiticeiro",
    "- Zumbi"
};
int[] dificuldade =
{
    14,
    16,
    18,
    20,
    22
};
int vitória = 0;
int derrota = 0;
int pontuação = 0;


Console.WriteLine("=====Bem-vindo ao Desafio dos Heróis!=====");
Console.WriteLine("Você pode começar escrevendo o seu nome:");
nomejogador = Console.ReadLine();
for (int rodada = 1;  rodada <=3; rodada++)
{
    Console.WriteLine("===== Desafio - " + rodada + "=====");
    int desafioEscolhido = random.Next(0, 5);
    Console.WriteLine("Desafio | " + desafios[desafioEscolhido]);

    Console.WriteLine("Escolha seu herói:");
    for (int i = 0; i < 5; i++) 
    {
        Console.WriteLine ((i + 1) + " - " + heróis[i] + " | Força:" + força[i]);
    }
    Console.WriteLine("Agora sua escolha:");
    int escolha  = int.Parse(Console.ReadLine());
    int hEscolhido = escolha - 1;
    int bônus = random.Next(0, 6);
    int fFinal = força[hEscolhido] + bônus;
    Console.WriteLine("Herói escolhido:" + heróis[hEscolhido]);
    Console.WriteLine("Força:" + força[força[hEscolhido]]);
    Console.WriteLine("Bônus:" + bônus);
    Console.WriteLine("Força final:" [fFinal]);
    if (fFinal >= dificuldade[desafioEscolhido])
    { Console.WriteLine("Você venceu!");
        vitória++;
        pontuação += 10;

    }
    else
    {
        Console.WriteLine("Você perdeu! :(");
            derrota ++;
        pontuação -= -5;    
    }
}

Console.WriteLine("=====Resultado da partida=====");
Console.WriteLine("Jogador:" + nomejogador);
Console.WriteLine("Vitórias;" + vitória);
Console.WriteLine("Derrotas:" + derrota);
Console.WriteLine("Pontuação final:" + pontuação);

if (vitória >= 2)
{
    Console.WriteLine("Resultado da partida: Você Ganhou!!!");
}
else
{
    Console.WriteLine("Resultado da partida: Você perdeu! :(");
}