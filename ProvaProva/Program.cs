//Dupla: Lucas Moretti e Lorenzo Schadeck

Console.WriteLine("Bem-vindo ao The Boys: o Quiz");
Console.WriteLine("Responda as perguntas com os números de 1 a 4, respectivamente, e em seguida pressione <enter> para prosseguir.");
Console.WriteLine("Para começar, pressione a tecla <enter>");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
    Console.WriteLine();
}

int acertos = 0;
int erros = 0;

//Pergunta 1
Console.WriteLine("Pergunta 1");
Console.WriteLine("Como a namorada do personagem Hughie morre?");

//Alternativas
Console.WriteLine("A) Atingida por um trem");
Console.WriteLine("B) Atropelada por um trem-bala");
Console.WriteLine("C) Atingida pelo Trem-Bala");
Console.WriteLine("D) Atingida por uma bala");

int resp = Convert.ToInt32(Console.ReadLine());

if (resp == 3)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Pergunta 2
Console.WriteLine("Pergunta 2");
Console.WriteLine("Qual o sonho da Luz Estrela?");

//Alternativas
Console.WriteLine("A) Salvar o mundo");
Console.WriteLine("B) Entrar na liga do Revanche");
Console.WriteLine("C) Entrar nos Avengers");
Console.WriteLine("D) Entrar para os 7");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 4)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Pergunta 3
Console.WriteLine("Pergunta 3");
Console.WriteLine("Qual herói substitui a vaga do Faixo de Luz nos 7?");

//Alternativas
Console.WriteLine("A) Profundo");
Console.WriteLine("B) Batman");
Console.WriteLine("C) Luz Estrela");
Console.WriteLine("D) Billy Bruto");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 3)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Pergunta 4
Console.WriteLine("Pergunta 4");
Console.WriteLine("Qual o músico favorito do Hughie?");

//Alternativas
Console.WriteLine("A) Billy Joel");
Console.WriteLine("B) James Taylor");
Console.WriteLine("C) Simon e Garfunkol");
Console.WriteLine("D) Green Day");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 2)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}


//Pergunta 5
Console.WriteLine("Pergunta 5");
Console.WriteLine("Do que é feita a pele do translúcido?");

//Alternativas
Console.WriteLine("A) Kryptonita");
Console.WriteLine("B) Diamante");
Console.WriteLine("C) Carbono");
Console.WriteLine("D) Metal");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 2)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Fim de Jogo 1

Console.WriteLine("Fim de Jogo!!");
Console.WriteLine("Deseja Jogar novamente?");
Console.WriteLine("Sim: <enter>");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
    Console.WriteLine();
}

//Pergunta 1
Console.WriteLine("Pergunta 1");
Console.WriteLine("Qual o primeiro super que os caras matam?");

//Alternativas
Console.WriteLine("A) Soldier Boy");
Console.WriteLine("B) Billy Bruto");
Console.WriteLine("C) Capitão Pátria");
Console.WriteLine("D) Translúcido");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 4)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Pergunta 2
Console.WriteLine("Pergunta 2");
Console.WriteLine("Quem é o vencedor da disputa entre Trem-Bala e Onda de Choque?");

//Alternativas
Console.WriteLine("A) Onda de Choque");
Console.WriteLine("B) Trem-Bala");
Console.WriteLine("C) Termina em empate");
Console.WriteLine("D) A disputa é interrompida");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 2)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Pergunta 3
Console.WriteLine("Pergunta 3");
Console.WriteLine("O que é composto V?");

//Alternativas
Console.WriteLine("A) Uma droga");
Console.WriteLine("B) Um experimento da Vought");
Console.WriteLine("C) Uma arma química");
Console.WriteLine("D) Uma bebida alcoolica");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 1)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}

//Pergunta 4
Console.WriteLine("Pergunta 4");
Console.WriteLine("O que o composto V faz?");

//Alternativas
Console.WriteLine("A) Muta em contato com a pele");
Console.WriteLine("B) Te deixa alucinado");
Console.WriteLine("C) Concede super poderes ou os aumenta");
Console.WriteLine("D) Tem efeito nenhum");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 4)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}


//Pergunta 5
Console.WriteLine("Pergunta 5");
Console.WriteLine("Como os supers salvaram o voo 37?");

//Alternativas
Console.WriteLine("A) Capitão Pátria voou e aterrizou o avião");
Console.WriteLine("B) Não salvaram");
Console.WriteLine("C) Pilotaramm o avião");
Console.WriteLine("D) Destruiram o avião");

resp = Convert.ToInt32(Console.ReadLine());

if (resp == 2)
{
    acertos++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}
else
{
    erros++;
    Console.WriteLine("Respostas Corretas: " + acertos);
    Console.WriteLine("Respostas Incorretas: " + erros);
}



