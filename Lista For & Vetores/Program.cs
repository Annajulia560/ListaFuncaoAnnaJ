// See https://aka.ms/new-console-template for more information
//Exercício 1: 
string[] personagens =
{
    "Kai", "Mika", "Luna"
};

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(personagens[0]);
Console.ResetColor();
Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(personagens[1]);
Console.ResetColor();
Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(personagens[2]);
Console.ResetColor();



//Exercício 2: 
string[] ItensDeJogo =
{
    "Poção", "Espada", "Escudo", "Mapa"
};

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Primeiro item: " + ItensDeJogo[0]);
Console.ResetColor();
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Segundo item: " + ItensDeJogo[1]);
Console.ResetColor();
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Terceiro item: " + ItensDeJogo[2]);
Console.ResetColor();
Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Último item: " + ItensDeJogo[3]);
Console.ResetColor();



//Exercício 3: 
string[] itens =
{
    "Poção", "Chave", "Mapa", "Espada", "Cristal"
};

for (int item = 0; item < itens.Length; item++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(itens[item]);
    Console.ResetColor();
    Thread.Sleep(1500);
}



//Exercício 4:
string[] fases =
{
    "Floresta", "Caverna", "Castelo", "Laboratório"
};

for (int fase = 0; fase < fases.Length; fase++)
{
    Console.WriteLine((fase + 1) + " - " + fases[fase]);
    Thread.Sleep(1000);
}



//Exercício 5: 
int[] pontos = { 100, 250, 300, 150, 400 };

for (int i = 0; i < pontos.Length; i++)
{
    Console.WriteLine("Fase " + (i + 1) + ": " + pontos[i] + " pontos");
    Thread.Sleep(1000);
}



//Exercício 6: 
int[] pontos3 =
{
    100, 250, 300, 150, 400
};

int total = 0;

for (int i = 0; i < pontos.Length; i++)
{
    total += pontos[i];
}

Console.WriteLine("Pontuação total: " + total);



Exercício7:
int[] partidas = { 80, 120, 60, 200, 150 };
int maior = partidas[0];

for (int i = 1; i < partidas.Length; i++)
{
    if (partidas[i] > maior)
    {
        maior = partidas[i];
    }
}

Console.WriteLine("Maior pontuação: " + maior);



//Exercício 8: 
string[] inventario = { "Poção", "Mapa", "Chave", "Cristal" };
bool encontrou = false;

Console.WriteLine("Digite o nome de um item: ");
string resposta = Console.ReadLine();

for (int i = 0; i < inventario.Length; i++)
{
    if (resposta == inventario[i])
    {
        encontrou = true;
        Console.WriteLine("Item encontrado!");
    }
}

if (encontrou == false)
{
    Console.WriteLine("Item não encontrado.");
}



//Exercício 9:
string[] inimigos = { "Slime", "Morcego", "Goblin", "Esqueleto" };

Console.WriteLine("Inimigos encontrados: ");
Thread.Sleep(2000);
for (int i = 0; i < inimigos.Length; i++)
{
    Console.WriteLine("Um " + inimigos[i] + " apareceu!");
    Thread.Sleep(1000);
}



//Exercício 10: 
string[] nomes = { "Luna", "Kai", "Mika" };
int[] vidas = { 100, 80, 50 };

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i] + " - Vida: " + vidas[i]);
    Thread.Sleep(1000);

}

for (int i = 0; i < vidas.Length; i++)
{
    if (vidas[i] >= 70)
    {
        Console.WriteLine(nomes[i] + " - Vida: " + vidas[i] + " - Saudável.");
    }
    else
    {
        Console.WriteLine(nomes[i] + " - Vida: " + vidas[i] + " - Ferido.");
    }
    Thread.Sleep(1000);
}
