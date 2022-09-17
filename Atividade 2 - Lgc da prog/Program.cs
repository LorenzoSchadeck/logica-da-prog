//Dupla: Lorenzo Schadeck e Lucas Moretti

Console.WriteLine("Bem-vindo ao Knight's Adventure!!");
Console.WriteLine("Como jogar:");
Console.WriteLine("Use os números de 1 a 4 para escolher entre as opções e trilhar seu caminho.");
Console.WriteLine("Pressione <Enter> para jogar");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
    Console.WriteLine();
}

//Inicio
string[] escolhas1 = new string[4];

escolhas1[0] = "entrada ao leste";
escolhas1[1] = "entrada ao oeste";
escolhas1[2] = "antigo bosque";
escolhas1[3] = "trilha da perdição";

Console.WriteLine("Você é um jovem aventureiro, e se depara com alguns caminhos...");
Console.WriteLine("O que você faz?");

//O que o player faz?
Console.WriteLine("1" + ") Vou pela " + escolhas1[0]);
Console.WriteLine("2" + ") Vou pela " + escolhas1[1]);
Console.WriteLine("3" + ") Vou pelo " + escolhas1[2]);
Console.WriteLine("4" + ") Vou pela " + escolhas1[3]);

string choices1 = Convert.ToString(Console.ReadLine());

if (choices1 == "1" || choices1 == "3")
{
    //1.1

    //Caminho 1.1
    string[] escolhas2 = new string[4];

    escolhas2[0] = "espada e escudo";
    escolhas2[1] = "me escondo";
    escolhas2[2] = "fujo";
    escolhas2[3] = "arco e flecha";

    Console.WriteLine("Uma alcateia surge em sua frente...");
    Console.WriteLine("O que você faz?");

    //O que o player faz?
    Console.WriteLine("1" + ") Uso a " + escolhas2[0]);
    Console.WriteLine("2" + ") " + escolhas2[1]);
    Console.WriteLine("3" + ") " + escolhas2[2]);
    Console.WriteLine("4" + ") Uso o " + escolhas2[3]);

    string choices2 = Convert.ToString(Console.ReadLine());

    if (choices2 == "1" || choices2 == "4")
    {
        Console.WriteLine("voce derrota as bestas, e recebe um pote com mel");

        //Caminho 2.1
        string[] escolhas4 = new string[4];

        escolhas4[0] = "espada";
        escolhas4[1] = "mel";
        escolhas4[2] = "fujo";
        escolhas4[3] = "me escondo";

        Console.WriteLine("Um fera que apaarenta ser um urso o espreita...");
        Console.WriteLine("O que você faz?");

        //O que o player faz?
        Console.WriteLine("1" + ") Uso minha " + escolhas4[0]);
        Console.WriteLine("2" + ") Uso o " + escolhas4[1]);
        Console.WriteLine("3" + ") " + escolhas4[2]);
        Console.WriteLine("4" + ") " + escolhas4[3]);

        string choices4 = Convert.ToString(Console.ReadLine());

        if (choices4 == "2")
        {
            Console.WriteLine("Você o dosmestica...");
            //Caminho 3.3
            string[] escolhas8 = new string[4];

            escolhas8[0] = "urso";
            escolhas8[1] = "espada encantada";
            escolhas8[2] = "arco e flecha";
            escolhas8[3] = "espada";

            Console.WriteLine("Nos céus, um grifo avança em sua direção...");
            Console.WriteLine("O que você faz?");

            //O que o player faz?
            Console.WriteLine("1" + ") Uso " + escolhas8[0]);
            Console.WriteLine("2" + ") Uso " + escolhas8[1]);
            Console.WriteLine("3" + ") Uso " + escolhas8[2]);
            Console.WriteLine("4" + ") Uso " + escolhas8[3]);

            string choices8 = Convert.ToString(Console.ReadLine());

            if (choices8 == "1" || choices8 == "2" || choices8 == "3" || choices8 == "4")
            {
                Console.WriteLine("Seu urso se sacrifica por você, e derrota o grifo...");

                //Final 1
                string[] escolhas10 = new string[4];

                escolhas10[0] = "espada encantada";
                escolhas10[1] = "Ataco furtivamente";
                escolhas10[2] = "Me escondo na pedra extremamente conveniente no meio do campo de batalha";
                escolhas10[3] = "Imploro pela minha vidaa";

                Console.WriteLine("Porém, logo atrás do grifo, o DRAGAO ANCIAO DE OLHOS NEGROS DO MAL vinha em sua direção...");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso a " + escolhas10[0]);
                Console.WriteLine("2" + ") " + escolhas10[1]);
                Console.WriteLine("3" + ") " + escolhas10[2]);
                Console.WriteLine("4" + ") " + escolhas10[3]);

                string choices10 = Convert.ToString(Console.ReadLine());

                if (choices10 == "1" || choices10 == "2")
                {
                    Console.WriteLine("Vitoria");
                    Console.WriteLine("O monstro se desfaz em poeira, e você comemora sua vitória!!");
                }
                else
                {
                    Console.WriteLine("Morte");

                    //Final 1
                    Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas10[0]);
                    Console.WriteLine("2" + ") " + escolhas10[1]);
                    Console.WriteLine("3" + ") " + escolhas10[2]);
                    Console.WriteLine("4" + ") " + escolhas10[3]);

                    choices10 = Convert.ToString(Console.ReadLine());

                    if (choices10 == "1" || choices10 == "2")
                    {
                        Console.WriteLine("Vitoria");
                    }
                    else
                    {
                        Console.WriteLine("Morte");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Morte");

            //Caminho 2.1
            Console.WriteLine("urso");
            Console.WriteLine("O que você faz?");

            //O que o player faz?
            Console.WriteLine("1" + ") Uso minha " + escolhas4[0]);
            Console.WriteLine("2" + ") Uso o " + escolhas4[1]);
            Console.WriteLine("3" + ") " + escolhas4[2]);
            Console.WriteLine("4" + ") " + escolhas4[3]);

            choices4 = Convert.ToString(Console.ReadLine());

            if (choices4 == "2")
            {
                //Caminho 3.3
                string[] escolhas8 = new string[4];

                escolhas8[0] = "urso";
                escolhas8[1] = "espada encantada";
                escolhas8[2] = "arco e flecha";
                escolhas8[3] = "espada";

                Console.WriteLine("grifo");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso " + escolhas8[0]);
                Console.WriteLine("2" + ") Uso " + escolhas8[1]);
                Console.WriteLine("3" + ") Uso " + escolhas8[2]);
                Console.WriteLine("4" + ") Uso " + escolhas8[3]);

                string choices8 = Convert.ToString(Console.ReadLine());

                if (choices8 == "1" || choices8 == "2" || choices8 == "3" || choices8 == "4")
                {
                    //Final 1
                    string[] escolhas10 = new string[4];

                    escolhas10[0] = "espada encantada";
                    escolhas10[1] = "Ataco furtivamente";
                    escolhas10[2] = "Me escondo na pedra extremamente conveniente no meio do campo de batalha";
                    escolhas10[3] = "Imploro pela minha vidaa";

                    Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas10[0]);
                    Console.WriteLine("2" + ") " + escolhas10[1]);
                    Console.WriteLine("3" + ") " + escolhas10[2]);
                    Console.WriteLine("4" + ") " + escolhas10[3]);

                    string choices10 = Convert.ToString(Console.ReadLine());

                    if (choices10 == "1" || choices10 == "2")
                    {
                        Console.WriteLine("Vitoria");
                    }
                    else
                    {
                        Console.WriteLine("Morte");

                        //Final 1
                        Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL");
                        Console.WriteLine("O que você faz?");

                        //O que o player faz?
                        Console.WriteLine("1" + ") Uso a " + escolhas10[0]);
                        Console.WriteLine("2" + ") " + escolhas10[1]);
                        Console.WriteLine("3" + ") " + escolhas10[2]);
                        Console.WriteLine("4" + ") " + escolhas10[3]);

                        choices10 = Convert.ToString(Console.ReadLine());

                        if (choices10 == "1" || choices10 == "2")
                        {
                            Console.WriteLine("Vitoria");
                        }
                        else
                        {
                            Console.WriteLine("Morte");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Morte");

            }
        }
    }
    else if (choices2 == "2" || choices2 == "3")
    {
        Console.WriteLine("Morte");

        //Caminho 1.1
        Console.WriteLine("lobos");
        Console.WriteLine("O que você faz?");

        //O que o player faz?
        Console.WriteLine("1" + ") Uso a " + escolhas2[0]);
        Console.WriteLine("2" + ") " + escolhas2[1]);
        Console.WriteLine("3" + ") " + escolhas2[2]);
        Console.WriteLine("4" + ") Uso o " + escolhas2[3]);

        choices2 = Convert.ToString(Console.ReadLine());

        if (choices2 == "1" || choices2 == "4")
        {
            Console.WriteLine("voce derrota as bestas, e recebe um pote com mel");

            //Caminho 2.1
            string[] escolhas4 = new string[4];

            escolhas4[0] = "espada";
            escolhas4[1] = "mel";
            escolhas4[2] = "fujo";
            escolhas4[3] = "me escondo";

            Console.WriteLine("urso");
            Console.WriteLine("O que você faz?");

            //O que o player faz?
            Console.WriteLine("1" + ") Uso minha " + escolhas4[0]);
            Console.WriteLine("2" + ") Uso o " + escolhas4[1]);
            Console.WriteLine("3" + ") " + escolhas4[2]);
            Console.WriteLine("4" + ") " + escolhas4[3]);

            string choices4 = Convert.ToString(Console.ReadLine());

            if (choices4 == "2")
            {
                //Caminho 3.3
                string[] escolhas8 = new string[4];

                escolhas8[0] = "urso";
                escolhas8[1] = "espada encantada";
                escolhas8[2] = "arco e flecha";
                escolhas8[3] = "espada";

                Console.WriteLine("grifo");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso " + escolhas8[0]);
                Console.WriteLine("2" + ") Uso " + escolhas8[1]);
                Console.WriteLine("3" + ") Uso " + escolhas8[2]);
                Console.WriteLine("4" + ") Uso " + escolhas8[3]);

                string choices8 = Convert.ToString(Console.ReadLine());

                if (choices8 == "1" || choices8 == "2" || choices8 == "3" || choices8 == "4")
                {
                    //Final 1
                    string[] escolhas10 = new string[4];

                    escolhas10[0] = "espada encantada";
                    escolhas10[1] = "Ataco furtivamente";
                    escolhas10[2] = "Me escondo na pedra extremamente conveniente no meio do campo de batalha";
                    escolhas10[3] = "Imploro pela minha vidaa";

                    Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas10[0]);
                    Console.WriteLine("2" + ") " + escolhas10[1]);
                    Console.WriteLine("3" + ") " + escolhas10[2]);
                    Console.WriteLine("4" + ") " + escolhas10[3]);

                    string choices10 = Convert.ToString(Console.ReadLine());

                    if (choices10 == "1" || choices10 == "2")
                    {
                        Console.WriteLine("Vitoria");
                    }
                    else
                    {
                        Console.WriteLine("Morte");

                        //Final 1
                        Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL");
                        Console.WriteLine("O que você faz?");

                        //O que o player faz?
                        Console.WriteLine("1" + ") Uso a " + escolhas10[0]);
                        Console.WriteLine("2" + ") " + escolhas10[1]);
                        Console.WriteLine("3" + ") " + escolhas10[2]);
                        Console.WriteLine("4" + ") " + escolhas10[3]);

                        choices10 = Convert.ToString(Console.ReadLine());

                        if (choices10 == "1" || choices10 == "2")
                        {
                            Console.WriteLine("Vitoria");
                        }
                        else
                        {
                            Console.WriteLine("Morte");
                        }
                    }
                }
            }
        }

    }
}  //1.1
else
{
    //1.2

    //Caminho 1.2
    string[] escolhas3 = new string[4];

    escolhas3[0] = "espada/escudo";
    escolhas3[1] = "me escondo";
    escolhas3[2] = "fujo";
    escolhas3[3] = "arco e flecha";

    Console.WriteLine("Ao vir por aqui, você se depara com um bando de goblins...");
    Console.WriteLine("O que você faz?");

    //O que o player faz?
    Console.WriteLine("1" + ") Uso a " + escolhas3[0]);
    Console.WriteLine("2" + ") " + escolhas3[1]);
    Console.WriteLine("3" + ") " + escolhas3[2]);
    Console.WriteLine("4" + ") Uso " + escolhas3[3]);

    string choices3 = Convert.ToString(Console.ReadLine());

    if (choices3 == "1" || choices3 == "3")
    {
        Console.WriteLine("Você se livra dos goblins");
        //Caminho 2.2
        string[] escolhas5 = new string[4];

        escolhas5[0] = "arco e flecha";
        escolhas5[1] = "Fujo";
        escolhas5[2] = "espada/escudo";
        escolhas5[3] = "Evito o urso";

        Console.WriteLine("Ao continuar sua jornada, surge um urso zumbi em sua frente...");
        Console.WriteLine("O que você faz?");

        //O que o player faz?
        Console.WriteLine("1" + ") Uso a " + escolhas5[0]);
        Console.WriteLine("2" + ") " + escolhas5[1]);
        Console.WriteLine("3" + ") Uso o " + escolhas5[2]);
        Console.WriteLine("4" + ") " + escolhas5[3]);

        string choices5 = Convert.ToString(Console.ReadLine());

        if (choices5 == "1")
        {
            Console.WriteLine("O urso acaba morrendo (de novo) e voce recebe uma espada encantada!!");

            //Caminho 3.2
            string[] escolhas7 = new string[4];

            escolhas7[0] = "espada encantada";
            escolhas7[1] = "espada normal";
            escolhas7[2] = "Fujo";
            escolhas7[3] = "Morro";

            Console.WriteLine("Entrando em uma catacumba, você acaba cercado por um grupo de esqueletos...");
            Console.WriteLine("O que você faz?");

            //O que o player faz?
            Console.WriteLine("1" + ") Uso a " + escolhas7[0]);
            Console.WriteLine("2" + ") Uso a " + escolhas7[1]);
            Console.WriteLine("3" + ") " + escolhas7[2]);
            Console.WriteLine("4" + ") " + escolhas7[3]);

            string choices7 = Convert.ToString(Console.ReadLine());

            if (choices7 == "1" || choices7 == "2")
            {
                Console.WriteLine("Você os manda de volta para suas covas");

                //Final 2
                string[] escolhas11 = new string[4];

                escolhas11[0] = "espada encantada";
                escolhas11[1] = "Me sacrifico";
                escolhas11[2] = "cajado do antigo Lich";
                escolhas11[3] = "Desisto";

                Console.WriteLine("No final da catacumba, um DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI aparece para devora-lo...");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                Console.WriteLine("2" + ") " + escolhas11[1]);
                Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                Console.WriteLine("4" + ") " + escolhas11[3]);

                string choices11 = Convert.ToString(Console.ReadLine());

                if (choices11 == "1")
                {
                    Console.WriteLine("Vitoria");
                    Console.WriteLine("Você esxpurga a besta maligna da terra, e comemora sua vitoria!!!");
                }
                else
                {
                    Console.WriteLine("Morte");

                    //Final 2
                    Console.WriteLine("No final da catacumba, um DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI aparece para devora-lo...");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                    Console.WriteLine("2" + ") " + escolhas11[1]);
                    Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                    Console.WriteLine("4" + ") " + escolhas11[3]);

                    choices11 = Convert.ToString(Console.ReadLine());

                    if (choices11 == "1")
                    {
                        Console.WriteLine("Vitoria");
                        Console.WriteLine("Você espurga a besta maligna da terra, e comemora sua vitoria!!!");
                    }
                    else
                    {
                        Console.WriteLine("Morte");
                    }
                }
            }
            else
            {
                Console.WriteLine("morte");

                Console.WriteLine("");

                //Final 2
                string[] escolhas11 = new string[4];

                escolhas11[0] = "espada encantada";
                escolhas11[1] = "Me sacrifico";
                escolhas11[2] = "cajado do antigo Lich";
                escolhas11[3] = "Desisto";

                Console.WriteLine("No final da catacumba, um DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI aparece para devora-lo...");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                Console.WriteLine("2" + ") " + escolhas11[1]);
                Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                Console.WriteLine("4" + ") " + escolhas11[3]);

                string choices11 = Convert.ToString(Console.ReadLine());

                if (choices11 == "1")
                {
                    Console.WriteLine("Vitoria");
                    Console.WriteLine("Você espurga a besta maligna da terra, e comemora sua vitoria!!!");
                }
                else
                {
                    Console.WriteLine("Morte");

                    //Final 2
                    Console.WriteLine("No final da catacumba, um DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI aparece para devora-lo...");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                    Console.WriteLine("2" + ") " + escolhas11[1]);
                    Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                    Console.WriteLine("4" + ") " + escolhas11[3]);

                    choices11 = Convert.ToString(Console.ReadLine());

                    if (choices11 == "1")
                    {
                        Console.WriteLine("Vitoria");
                        Console.WriteLine("Você esxpurga a besta maligna da terra, e comemora sua vitoria!!!");
                    }
                    else
                    {
                        Console.WriteLine("Morte");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Morte");

            //Caminho 2.2
            Console.WriteLine("Ao continuar sua jornada, surge um urso zumbi em sua frente...");
            Console.WriteLine("O que você faz?");

            //O que o player faz?
            Console.WriteLine("1" + ") Uso a " + escolhas5[0]);
            Console.WriteLine("2" + ") " + escolhas5[1]);
            Console.WriteLine("3" + ") Uso o " + escolhas5[2]);
            Console.WriteLine("4" + ") " + escolhas5[3]);

            choices5 = Convert.ToString(Console.ReadLine());

            if (choices5 == "1")
            {
                Console.WriteLine("O urso acaba morrendo (de novo) e voce recebe uma espada encantada!!");

                //Caminho 3.2
                string[] escolhas7 = new string[4];

                escolhas7[0] = "espada encantada";
                escolhas7[1] = "espada normal";
                escolhas7[2] = "Fujo";
                escolhas7[3] = "Morro";

                Console.WriteLine("Entrando em uma catacumba, você acaba cercado por um grupo de esqueletos...");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso a " + escolhas7[0]);
                Console.WriteLine("2" + ") Uso a " + escolhas7[1]);
                Console.WriteLine("3" + ") " + escolhas7[2]);
                Console.WriteLine("4" + ") " + escolhas7[3]);

                string choices7 = Convert.ToString(Console.ReadLine());

                if (choices7 == "1" || choices7 == "2")
                {
                    Console.WriteLine("Você os manda de volta para suas covas");

                    //Final 2
                    string[] escolhas11 = new string[4];

                    escolhas11[0] = "espada encantada";
                    escolhas11[1] = "Me sacrifico";
                    escolhas11[2] = "cajado do antigo Lich";
                    escolhas11[3] = "Desisto";

                    Console.WriteLine("No final da catacumba, um DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI aparece para devora-lo...");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                    Console.WriteLine("2" + ") " + escolhas11[1]);
                    Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                    Console.WriteLine("4" + ") " + escolhas11[3]);

                    string choices11 = Convert.ToString(Console.ReadLine());

                    if (choices11 == "1")
                    {
                        Console.WriteLine("Vitoria");
                        Console.WriteLine("Você esxpurga a besta maligna da terra, e comemora sua vitoria!!!");
                    }
                    else
                    {
                        Console.WriteLine("Morte");

                        //Final 2
                        Console.WriteLine("No final da catacumba, um DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI aparece para devora-lo...");
                        Console.WriteLine("O que você faz?");

                        //O que o player faz?
                        Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                        Console.WriteLine("2" + ") " + escolhas11[1]);
                        Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                        Console.WriteLine("4" + ") " + escolhas11[3]);

                        choices11 = Convert.ToString(Console.ReadLine());

                        if (choices11 == "1")
                        {
                            Console.WriteLine("Vitoria");
                            Console.WriteLine("Você esxpurga a besta maligna da terra, e comemora sua vitoria!!!");
                        }
                        else
                        {
                            Console.WriteLine("Morte");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("morte");

                    //Caminho 3.2
                    Console.WriteLine("Entrando em uma catacumba, você acaba cercado por um grupo de esqueletos...");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas7[0]);
                    Console.WriteLine("2" + ") Uso a " + escolhas7[1]);
                    Console.WriteLine("3" + ") " + escolhas7[2]);
                    Console.WriteLine("4" + ") " + escolhas7[3]);

                    choices7 = Convert.ToString(Console.ReadLine());

                    if (choices7 == "1" || choices7 == "2")
                    {
                        Console.WriteLine("Você os manda de volta para suas covas");

                        //Final 2
                        string[] escolhas11 = new string[4];

                        escolhas11[0] = "espada encantada";
                        escolhas11[1] = "Me sacrifico";
                        escolhas11[2] = "cajado do antigo Lich";
                        escolhas11[3] = "Desisto";

                        Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI");
                        Console.WriteLine("O que você faz?");

                        //O que o player faz?
                        Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                        Console.WriteLine("2" + ") " + escolhas11[1]);
                        Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                        Console.WriteLine("4" + ") " + escolhas11[3]);

                        string choices11 = Convert.ToString(Console.ReadLine());

                        if (choices11 == "1")
                        {
                            Console.WriteLine("Vitoria");
                        }
                        else
                        {
                            Console.WriteLine("Morte");

                            //Final 2
                            Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI");
                            Console.WriteLine("O que você faz?");

                            //O que o player faz?
                            Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                            Console.WriteLine("2" + ") " + escolhas11[1]);
                            Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                            Console.WriteLine("4" + ") " + escolhas11[3]);

                            choices11 = Convert.ToString(Console.ReadLine());

                            if (choices11 == "1")
                            {
                                Console.WriteLine("Vitoria");
                            }
                            else
                            {
                                Console.WriteLine("Morte");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("morte");

                    }
                }
            }
        }
    }
    else if (choices3 == "4" || choices3 == "2")
    {
        Console.WriteLine("Morte");

        //Caminho 1.2
        Console.WriteLine("goblins");
        Console.WriteLine("O que você faz?");

        //O que o player faz?
        Console.WriteLine("1" + ") Uso a " + escolhas3[0]);
        Console.WriteLine("2" + ") " + escolhas3[1]);
        Console.WriteLine("3" + ") " + escolhas3[2]);
        Console.WriteLine("4" + ") Uso " + escolhas3[3]);

        choices3 = Convert.ToString(Console.ReadLine());

        if (choices3 == "1" || choices3 == "3")
        {
            //Caminho 2.2
            string[] escolhas5 = new string[4];

            escolhas5[0] = "arco e flecha";
            escolhas5[1] = "Fujo";
            escolhas5[2] = "espada/escudo";
            escolhas5[3] = "Evito o urso";

            Console.WriteLine("urso zumbi");
            Console.WriteLine("O que você faz?");

            //O que o player faz?
            Console.WriteLine("1" + ") Uso a " + escolhas5[0]);
            Console.WriteLine("2" + ") " + escolhas5[1]);
            Console.WriteLine("3" + ") Uso o " + escolhas5[2]);
            Console.WriteLine("4" + ") " + escolhas5[3]);

            string choices5 = Convert.ToString(Console.ReadLine());

            if (choices5 == "1")
            {
                Console.WriteLine("O urso acaba morrendo (de novo) e voce recebe uma espada encantada!!");

                //Caminho 3.2
                string[] escolhas7 = new string[4];

                escolhas7[0] = "espada encantada";
                escolhas7[1] = "espada normal";
                escolhas7[2] = "Fujo";
                escolhas7[3] = "Morro";

                Console.WriteLine("Grupo de esqueletos");
                Console.WriteLine("O que você faz?");

                //O que o player faz?
                Console.WriteLine("1" + ") Uso a " + escolhas7[0]);
                Console.WriteLine("2" + ") Uso a " + escolhas7[1]);
                Console.WriteLine("3" + ") " + escolhas7[2]);
                Console.WriteLine("4" + ") " + escolhas7[3]);

                string choices7 = Convert.ToString(Console.ReadLine());

                if (choices7 == "1" || choices7 == "2")
                {
                    Console.WriteLine("");

                    //Final 2
                    string[] escolhas11 = new string[4];

                    escolhas11[0] = "espada encantada";
                    escolhas11[1] = "Me sacrifico";
                    escolhas11[2] = "cajado do antigo Lich";
                    escolhas11[3] = "Desisto";

                    Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                    Console.WriteLine("2" + ") " + escolhas11[1]);
                    Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                    Console.WriteLine("4" + ") " + escolhas11[3]);

                    string choices11 = Convert.ToString(Console.ReadLine());

                    if (choices11 == "1")
                    {
                        Console.WriteLine("Vitoria");
                    }
                    else
                    {
                        Console.WriteLine("Morte");

                        //Final 2
                        Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI");
                        Console.WriteLine("O que você faz?");

                        //O que o player faz?
                        Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                        Console.WriteLine("2" + ") " + escolhas11[1]);
                        Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                        Console.WriteLine("4" + ") " + escolhas11[3]);

                        choices11 = Convert.ToString(Console.ReadLine());

                        if (choices11 == "1")
                        {
                            Console.WriteLine("Vitoria");
                        }
                        else
                        {
                            Console.WriteLine("Morte");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("morte");

                    Console.WriteLine("");

                    //Final 2
                    string[] escolhas11 = new string[4];

                    escolhas11[0] = "espada encantada";
                    escolhas11[1] = "Me sacrifico";
                    escolhas11[2] = "cajado do antigo Lich";
                    escolhas11[3] = "Desisto";

                    Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI");
                    Console.WriteLine("O que você faz?");

                    //O que o player faz?
                    Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                    Console.WriteLine("2" + ") " + escolhas11[1]);
                    Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                    Console.WriteLine("4" + ") " + escolhas11[3]);

                    string choices11 = Convert.ToString(Console.ReadLine());

                    if (choices11 == "1")
                    {
                        Console.WriteLine("Vitoria");
                    }
                    else
                    {
                        Console.WriteLine("Morte");

                        //Final 2
                        Console.WriteLine("DRAGAO ANCIAO DE OLHOS NEGROS DO MAL ZUMBI");
                        Console.WriteLine("O que você faz?");

                        //O que o player faz?
                        Console.WriteLine("1" + ") Uso a " + escolhas11[0]);
                        Console.WriteLine("2" + ") " + escolhas11[1]);
                        Console.WriteLine("3" + ") Uso o " + escolhas11[2]);
                        Console.WriteLine("4" + ") " + escolhas11[3]);

                        choices11 = Convert.ToString(Console.ReadLine());

                        if (choices11 == "1")
                        {
                            Console.WriteLine("Vitoria");
                        }
                        else
                        {
                            Console.WriteLine("Morte");
                        }
                    }
                }
            }
        }
        else if (choices3 == "4" || choices3 == "2")
        {
            Console.WriteLine("Morte");
        }
    }
}                                     //1.2

Console.WriteLine("Presisone <R> para recomçar");

while (Console.ReadKey().Key != ConsoleKey.R)
{
    Console.ReadLine();
}
