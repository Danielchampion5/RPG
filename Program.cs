using System;
using System.Globalization;
namespace Teste;
internal class Program
{
    private static void Main(string[] args)
    {
        Combate();
    }
    static void Combate()
    {
        int vida = 1, vidainimigo = 1;

        do
        {
            int defesa = 0, agilidade = 0;

            Fichadepersonagem(); int i = 0;

            i += 1;

            Random d20 = new Random();

            vidainimigo = d20.Next(1, 21);

            Console.WriteLine($"{i}ºRodada");

            Thread.Sleep(3000);

            int iniciaiva = d20.Next(1, 21);

            int iniciativainimigo = d20.Next(1, 21);

            if (iniciaiva > iniciativainimigo)
            {
                int taxadeacerto = d20.Next(1, 21), esquiva = d20.Next(1, 21) + (agilidade / 2);

                if (taxadeacerto > esquiva)
                {
                    int dano = d20.Next(1, 21) - defesa;
                    vidainimigo -= dano;
                    Console.WriteLine($"Voce atacou primeiro e deu {dano} de dano.\nAgora o inimigo tem {vidainimigo} de vida.");
                }

                else
                {
                    Console.WriteLine("Voce errou o ataque.");
                }
            }
            else
            {
                int taxadeacerto = d20.Next(1, 21), esquiva = d20.Next(1, 21);

                if (taxadeacerto > esquiva)
                {
                    int dano = d20.Next(1, 21) - defesa;
                    vida -= dano;
                    Console.WriteLine($"Seu inimigo atacou primeiro e deu {dano} de dano.\nAgora voce esta com {vida} de vida.");
                }
                else
                {
                    Console.WriteLine("O inimigo errou seu ataque.");
                }
            }
            if (vidainimigo <= 0)
            {
                Console.WriteLine("Voce matou o inimigo.");
            }
            else if (vida <= 0)
            {
                Console.WriteLine("Voce morreu.");
            }
            else
            {
                Console.WriteLine("Voce sobreviveu.");
            }
        }
        while (vida > 0 && vidainimigo > 0);
    }
    static void Fichadepersonagem()
    {
        int vida = 0, força = 0, constituição = 0, inteligencia = 0, sorte = 0, agilidade = 0; Console.WriteLine("Agora iremos fazer sua ficha de personagem. Escolha o metodo que voce irá utilizar para distribuir seus status.\n1-Dados 2-Distribuição de pontos.");
        int resposta = int.Parse(Console.ReadLine());
        if (resposta == 1)
        {
            Console.WriteLine("Escolha quais dados voce deseja usar.\n1-d6 2-d8 3-d10");
            resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    Random d6 = new Random(); agilidade = d6.Next(1, 7); força = d6.Next(1, 7); constituição = d6.Next(1, 7);
                    inteligencia = d6.Next(1, 7); sorte = d6.Next(1, 7); vida = (constituição / 2) + 5; break;
                case 2:
                    Random d8 = new Random();
                    agilidade = d8.Next(1, 9); força = d8.Next(1, 9); constituição = d8.Next(1, 9); inteligencia = d8.Next(1, 9); sorte = d8.Next(1, 9);
                    vida = (constituição / 2) + 5;
                    break;
                case 3:
                    Random d10 = new Random(); agilidade = d10.Next(1, 11); força = d10.Next(1, 11);
                    constituição = d10.Next(1, 11); inteligencia = d10.Next(1, 11); sorte = d10.Next(1, 11); vida = (constituição / 2) + 5; break;
            }
        }
        else
        {
            Console.WriteLine("Escolha quantos pontos voce deseja distribuir.\n1-(24 pontos) 2-(32 pontos) 3-(40 pontos)");
            resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    for (int i = 0; i < resposta; i++)
                    {
                        Console.Write("Força-"); força = int.Parse(Console.ReadLine()); Console.Write("Agilidade-"); agilidade = int.Parse(Console.ReadLine());
                        Console.Write("Constituição-"); constituição = int.Parse(Console.ReadLine()); Console.Write("Inteligencia-");
                        inteligencia = int.Parse(Console.ReadLine()); Console.Write("Sorte-"); sorte = int.Parse(Console.ReadLine());
                        int totalpontos = força + sorte + inteligencia + constituição + agilidade; vida = (constituição / 2) + 5;

                        if (totalpontos > 24)
                        {
                            Console.WriteLine("Voce adicionou mais pontos que o permitido. Refaça a distribuição de pontos ou o programa será fechado.\n1-sim 2-Não");
                            resposta = int.Parse(Console.ReadLine());
                            if (resposta == 1)
                            {
                                Console.WriteLine("Voce será redirecionado a distribuição de pontos.");
                                Thread.Sleep(1000);
                                Distribuição();
                            }
                            else
                            {
                                Console.WriteLine("Fechando o jogo...");
                                Environment.Exit(0);
                            }
                        }
                        else if (totalpontos < 24)
                        {
                            Console.WriteLine("Voce adicionou menos pontos que o permitido.Voce deseja Refazer a distribuição de pontos ou continuar assim mesmo.\n1-sim 2-Não");
                            resposta = int.Parse(Console.ReadLine());
                            if (resposta == 1)
                            {
                                Console.WriteLine("Voce será redirecionado a distribuição de pontos.");
                                Thread.Sleep(1000); Distribuição();
                            }
                            else
                            {
                                Console.WriteLine("Fechando o jogo...");
                                Environment.Exit(0);
                            }
                        }
                        vida = (constituição / 2) + 5;
                    }
                    break;

                case 2:
                    for (int i = 0; i < resposta; i++)
                    {
                        Console.Write("Força-"); força = int.Parse(Console.ReadLine()); Console.Write("Agilidade-");
                        agilidade = int.Parse(Console.ReadLine()); Console.Write("Constituição-"); constituição = int.Parse(Console.ReadLine());
                        Console.Write("Inteligencia-"); inteligencia = int.Parse(Console.ReadLine()); Console.Write("Sorte-");
                        sorte = int.Parse(Console.ReadLine()); int totalpontos = força + sorte + inteligencia + constituição + agilidade;
                        vida = (constituição / 2) + 5;
                        if (totalpontos > 32)
                        {
                            Console.WriteLine("Voce adicionou mais pontos que o permitido. Refaça a distribuição de pontos ou o programa será fechado.\n1-sim 2-Não");
                            resposta = int.Parse(Console.ReadLine());
                            if (resposta == 1)
                            {
                                Console.WriteLine("Voce será redirecionado a distribuição de pontos.");
                                Thread.Sleep(1000); Distribuição();
                            }
                            else
                            {
                                Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                            }
                        }
                        else if (totalpontos < 32)
                        {
                            Console.WriteLine("Voce adicionou menos pontos que o permitido.Voce deseja Refazer a distribuição de pontos ou continuar assim mesmo.\n1-sim 2-Não");
                            resposta = int.Parse(Console.ReadLine());
                            if (resposta == 1)
                            {
                                Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                            }
                            else
                            {
                                Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                            }
                        }
                        vida = (constituição / 2) + 5;
                    }
                    break;

                case 3:
                    for (int i = 0; i < resposta; i++)
                    {
                        Console.Write("Força-"); força = int.Parse(Console.ReadLine()); Console.Write("Agilidade-");
                        agilidade = int.Parse(Console.ReadLine()); Console.Write("Constituição-"); constituição = int.Parse(Console.ReadLine());
                        Console.Write("Inteligencia-"); inteligencia = int.Parse(Console.ReadLine()); Console.Write("Sorte-");
                        sorte = int.Parse(Console.ReadLine()); int totalpontos = força + sorte + inteligencia + constituição + agilidade;
                        vida = (constituição / 2) + 5;
                        if (totalpontos > 40)
                        {
                            Console.WriteLine("Voce adicionou mais pontos que o permitido. Refaça a distribuição de pontos ou o programa será fechado.\n1-sim 2-Não");
                            resposta = int.Parse(Console.ReadLine());
                            if (resposta == 1)
                            {
                                Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                            }
                            else
                            {
                                Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                            }
                        }
                        else if (totalpontos < 40)
                        {
                            Console.WriteLine("Voce adicionou menos pontos que o permitido.Voce deseja Refazer a distribuição de pontos ou continuar assim mesmo.\n1-sim 2-Não");
                            resposta = int.Parse(Console.ReadLine());
                            if (resposta == 1)
                            {
                                Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                            }
                            else
                            {
                                Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                            }
                        }
                    }
                    break;
            }
        }
        Console.WriteLine($"Sua ficha:\n" + $"Vida {vida}\n" + $"Força {força} /Agilidade {agilidade}\n" + $"Constituição {constituição} /Inteligencia {inteligencia}\n" + $"Sorte {sorte}");
    }
    static void Distribuição()
    {
        int resposta, força, constituição, sorte, agilidade, inteligencia, vida;
        Console.WriteLine("Escolha quantos pontos voce deseja distribuir.\n1-(24 pontos) 2-(32 pontos) 3-(40 pontos)");
        resposta = int.Parse(Console.ReadLine());
        switch (resposta)
        {
            case 1:
                for (int i = 0; i < resposta; i++)
                {
                    Console.Write("Força-"); força = int.Parse(Console.ReadLine()); Console.Write("Agilidade-");
                    agilidade = int.Parse(Console.ReadLine()); Console.Write("Constituição-");
                    constituição = int.Parse(Console.ReadLine()); Console.Write("Inteligencia-");
                    inteligencia = int.Parse(Console.ReadLine()); Console.Write("Sorte-"); sorte = int.Parse(Console.ReadLine());
                    int totalpontos = força + sorte + inteligencia + constituição + agilidade; vida = (constituição / 2) + 5;
                    if (totalpontos > 24)
                    {
                        Console.WriteLine("Voce adicionou mais pontos que o permitido. Refaça a distribuição de pontos ou o programa será fechado.\n1-sim 2-Não");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                        }
                        else
                        {
                            Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                        }
                    }
                    else if (totalpontos < 24)
                    {
                        Console.WriteLine("Voce adicionou menos pontos que o permitido.Voce deseja Refazer a distribuição de pontos ou continuar assim mesmo.\n1-sim 2-Não");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                        }
                        else
                        {
                            Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                        }
                    }
                    vida = (constituição / 2) + 5;
                }
                break;

            case 2:
                for (int i = 0; i < resposta; i++)
                {
                    Console.Write("Força-"); força = int.Parse(Console.ReadLine()); Console.Write("Agilidade-");
                    agilidade = int.Parse(Console.ReadLine()); Console.Write("Constituição-"); constituição = int.Parse(Console.ReadLine());
                    Console.Write("Inteligencia-"); inteligencia = int.Parse(Console.ReadLine()); Console.Write("Sorte-");
                    sorte = int.Parse(Console.ReadLine()); int totalpontos = força + sorte + inteligencia + constituição + agilidade;
                    vida = (constituição / 2) + 5;
                    if (totalpontos > 32)
                    {
                        Console.WriteLine("Voce adicionou mais pontos que o permitido. Refaça a distribuição de pontos ou o programa será fechado.\n1-sim 2-Não");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                        }
                        else
                        {
                            Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                        }
                    }
                    else if (totalpontos < 32)
                    {
                        Console.WriteLine("Voce adicionou menos pontos que o permitido.Voce deseja Refazer a distribuição de pontos ou continuar assim mesmo.\n1-sim 2-Não");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                        }
                        else
                        {
                            Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                        }
                    }
                    vida = (constituição / 2) + 5;
                }
                break;

            case 3:
                for (int i = 0; i < resposta; i++)
                {
                    Console.Write("Força-"); força = int.Parse(Console.ReadLine()); Console.Write("Agilidade-"); agilidade = int.Parse(Console.ReadLine());
                    Console.Write("Constituição-"); constituição = int.Parse(Console.ReadLine()); Console.Write("Inteligencia-");
                    inteligencia = int.Parse(Console.ReadLine()); Console.Write("Sorte-"); sorte = int.Parse(Console.ReadLine());
                    int totalpontos = força + sorte + inteligencia + constituição + agilidade; vida = (constituição / 2) + 5;
                    if (totalpontos > 40)
                    {
                        Console.WriteLine("Voce adicionou mais pontos que o permitido. Refaça a distribuição de pontos ou o programa será fechado.\n1-sim 2-Não");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                        }
                        else
                        {
                            Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                        }
                    }
                    else if (totalpontos < 40)
                    {
                        Console.WriteLine("Voce adicionou menos pontos que o permitido.Voce deseja Refazer a distribuição de pontos ou continuar assim mesmo.\n1-sim 2-Não");
                        resposta = int.Parse(Console.ReadLine());
                        if (resposta == 1)
                        {
                            Console.WriteLine("Voce será redirecionado a distribuição de pontos."); Thread.Sleep(1000); Distribuição();
                        }
                        else
                        {
                            Console.WriteLine("Fechando o jogo..."); Environment.Exit(0);
                        }
                    }
                }
                break;
        }
    }
}