

// Exercício 1
Console.WriteLine("Escreva seu nome");
string nome = Console.ReadLine();
Console.WriteLine("\nSeja bem vindo(a)!!! " + nome);


// Exercício 2
int vida = 100;
Console.WriteLine("\nVida " + vida);
int vida1 = 80;
Console.WriteLine("\nVida " + vida1);


// Exercício 3
Console.WriteLine("\nEscreva sua pontuação inicial");
int pontuacao = int.Parse(Console.ReadLine());
if (pontuacao > 0)
{
    Console.WriteLine("\nVocê já começou pontuando!!");
}
else
{
    Console.WriteLine("\nVocê ainda não pontuou");
}


// Exercício 4
Console.WriteLine("\nQuanto HP você tem?");
int HP = int.Parse(Console.ReadLine());
if (HP > 0)
{
    Console.WriteLine("\nO jogador ainda está vivo");
}
else
{
    Console.WriteLine("\nGame Over");
}


// Exercício 5
Console.WriteLine("\nQuanto de energia você tem?");
int energia = int.Parse(Console.ReadLine());
if (energia >= 10)
{
    Console.WriteLine("\nVocê pode atacar!");
}
else
{
    Console.WriteLine("\nEnergia insuficiente");
}


// Exercício 6
Console.WriteLine("\nEscolha uma classe: Guerreiro, Mago, Arqueiro");
string classe = Console.ReadLine();

if (classe == "Guerreiro")
{
    Console.WriteLine("\nVocê é um: " + classe);
}
else
{
    Console.WriteLine("\nClasse diferente de Guerreiro");
}


// Exercício 7
Console.WriteLine("Você tem a chave?");
string chave = Console.ReadLine();
bool temChave = true;
if (temChave == true)
{
    Console.WriteLine("\nA porta abriu");
}
else
{
    Console.WriteLine("\nA porta está fechada");
}


// Exercício 8
Console.WriteLine("\nQuanto de moedas você tem?");
int moedas = int.Parse(Console.ReadLine());
if (moedas >= 50)
{
    Console.WriteLine("\nVocê vai poder comprar o item");
}
else
{
    Console.WriteLine("\nMoedas insuficientes");
}


// Exercício 9
Console.WriteLine("\nQual é sua vida atual?");
int vida_atual = int.Parse(Console.ReadLine());
Console.WriteLine("\nQual o dano que você recebeu?");
int dano = int.Parse(Console.ReadLine());
int vida_final = vida_atual - dano;
Console.WriteLine("\nVida Final: " + vida_final);
if (vida_final > 0)
{
    Console.WriteLine("\nVocê está vivo");
}
else
{
    Console.WriteLine("\nVocê morreu!");
}


// Exercício 10
Console.WriteLine("\nQual o nome do jogador?");
string nome_jogador = Console.ReadLine();
Console.WriteLine("\nSua classe");
string classe_jogador = Console.ReadLine();
Console.WriteLine("\nQuanto de vida você tem?");
int vida_jogador = int.Parse(Console.ReadLine());
Console.WriteLine("\nQuanto de energia você tem?");
int energia_jogador = int.Parse(Console.ReadLine());
Console.WriteLine("\n" + nome_jogador + "\n" + classe_jogador + "\n" + vida_jogador + "\n" + energia_jogador);
if (vida_jogador > 0)
{
    Console.WriteLine("\nPersonagem pronto para a aventura");
}
else
{
    Console.WriteLine("\nPersonagem inválido: vida precisa ser maior que zero.");
}


// Exercício 11
Console.WriteLine("\nQual sua vida atual ?");
int vida_atual2 = int.Parse(Console.ReadLine());
Console.WriteLine("\nQual a quantidade de cura?");
int cura = int.Parse(Console.ReadLine());
int vida_total = vida_atual2 + cura;
if (vida_total > 100)
{
    Console.WriteLine("\nVida Total: 100");
}
else
{
    Console.WriteLine("Vida Total: " + vida_total);
}


// Exercício 12
Console.WriteLine("\nEscolha um caminho");
Console.WriteLine("\n1-Floresta");
Console.WriteLine("\n2-Caverna");
Console.WriteLine("\n3-Castelo");
Console.WriteLine();
int caminho = int.Parse(Console.ReadLine());
if (caminho == 1)
{
    Console.WriteLine("Você entrou na floresta.");
}
else if (caminho == 2)
{
    Console.WriteLine("Você entrou na caverna.");
}
else if (caminho == 3)
{
    Console.WriteLine("Você entrou na castelo.");
}
else
{
    Console.WriteLine("Escolha um número válido");
}


// Exercício 13
Console.WriteLine("Qual é o seu nível?");
int nivel = int.Parse(Console.ReadLine());
if (nivel < 5)
{
    Console.WriteLine("Iniciante");
}
else if (nivel == 10 && nivel > 5)
{
    Console.WriteLine("Aventureiro");
}
else if (nivel > 10)
{
    Console.WriteLine("Herói experiente");
}


// Exercício 14
Console.WriteLine("Qual é a sua pontuação?");
int rank = int.Parse(Console.ReadLine());
if (rank < 100)
{
    Console.WriteLine("Rank C");
}
else if (rank >= 100)
{
    Console.WriteLine("Rank B");
}
else if (rank >= 300)
{
    Console.WriteLine("Rank A");
}
else if (rank >= 500)
{
    Console.WriteLine("Rank S");
}


// Exercício 15
Console.WriteLine("Qual é a Vida do Inimigo?");
int vidaInimigo = int.Parse(Console.ReadLine());
Console.WriteLine("Qual é a sua energia?");
int energiaJogador = int.Parse(Console.ReadLine());
Console.WriteLine("Qual foi o dano do seu ataque?");
int dan = int.Parse(Console.ReadLine());
int vidaInimigoFinal = vidaInimigo - dano;
if (energiaJogador >= 10)
{
    Console.WriteLine("Jogador pode atacar");
    if (vidaInimigoFinal < 0)
    {
        Console.WriteLine("Inimigo derrotado!");
    }
    else
    {
        Console.WriteLine("Vida do Inimigo " + vidaInimigoFinal);
    }
}
else
{
    Console.WriteLine("Energia insuficiente para atacar");
}


// Exercício 16
Console.WriteLine("Você tem uma chave?" +
"\n Sim" +
"\n Não");
string chav = Console.ReadLine();
Console.WriteLine("Qual é o seu nível?");
int lvl = int.Parse(Console.ReadLine());
if (chave == "Sim" || lvl >= 5)
{
    Console.WriteLine("O báu foi aberto!");
}
else
{
    Console.WriteLine("Você não conseguiu abrir o báu");
}


// Exercício 17
Console.WriteLine("Qual a sua vida?");
int vid = int.Parse(Console.ReadLine());
Console.WriteLine("Qual a sua energia?");
int energi = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o seu nível?");
int nive = int.Parse(Console.ReadLine());
if (vida > 50 && energia >= 30 && nivel >= 3)
{
    Console.WriteLine("Você entrou na dungeon");
}
else
{
    Console.WriteLine("Você ainda não está preparado");
}


// Exercício 18
Console.WriteLine("Quantas moedas você possui?");
int moeda = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o preço do item?");
int preco = int.Parse(Console.ReadLine());
int saldo = moedas - preco;
Console.WriteLine("Qual o nome do item?" +
"\n Espada" +
"\n Arco" +
"\n Cajado");
if (moedas >= preco)
{
    Console.WriteLine("Você comprou");
    Console.WriteLine("Seu Saldo agora é: " + saldo);
}
else
{
    Console.WriteLine("Você não tem moedas suficientes para comprar esse item.");
}


// Exercício 19
Console.WriteLine("Quantas moedas você coletou?");
int moedasColetadas = int.Parse(Console.ReadLine());
Console.WriteLine("Você derrotou o chefe?" +
"\n Sim" +
"\n Não");
string derrotaChefe = Console.ReadLine();
Console.WriteLine("Qual a sua vida final depois da luta?");
int vidaFinal = int.Parse(Console.ReadLine());
if (moedasColetadas >= 10 && derrotaChefe == "Sim" && vidaFinal > 0)
{
    Console.WriteLine("Fase Concluída!");
}
else
{
    Console.WriteLine("Você não cumpriu todos os objetivos.");
}
// Exercício 20
Console.WriteLine(" Como deseja ser chamado(a)?"); string nomee = Console.ReadLine(); Console.WriteLine("\n Parabéns por chegar até aqui " + nome);
Console.WriteLine("\n Com quantos pontos de vida você esta agora?"); int vidaa = int.Parse(Console.ReadLine());
Console.WriteLine("\n Quantos pontos você tem?"); int pontos = int.Parse(Console.ReadLine());
Console.WriteLine("\n Você tem arma?" +
    "\n Sim" +
    "\n Não"); string arma = Console.ReadLine();
Console.WriteLine("\n Você possui uma chave mágica?" +
    "\n Sim" +
    "\n Não"); string chavee = Console.ReadLine();
Console.WriteLine("\n Você derrotou o chefe?" +
    "\n Sim" +
    "\n Não"); string chefe = Console.ReadLine();
if (vida > 0 && pontos >= 100 && chefe == "Sim" && arma == "Sim" || chave == "Sim")
{
    Console.WriteLine("\n Final bom: " + nome + " salvou o reino!");
}
else if (vida <= 0)
{
    Console.WriteLine("\nFinal ruim: " + nome + " foi derrotado.");
}