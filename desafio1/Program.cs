using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VARIÁVEIS GLOBAIS

            /** TEXTO DE APRESENTAÇÃO E DESCRIÇÃO DA APLICAÇÃO */
            string saudacao = "=============================================================\n"
                + "                                                            \n"
                + "               000000000000000000                           \n"
                + "            000000000000000000000000                        \n"
                + "          00000000             00000                        \n"
                + "        0000000                   00       777     777      \n"
                + "       000000                              777     777      \n"
                + "      000000                               77      77       \n"
                + "      00000                               777     777       \n"
                + "     000000                         7777777777777777777777  \n"
                + "     000000                              777     777        \n"
                + "     000000                             777     777         \n"
                + "     000000                             777     777         \n"
                + "     000000                       7777777777777777777777    \n"
                + "      00000                            777     777          \n"
                + "      000000                           777    777           \n"
                + "       000000                         777     777           \n"
                + "        000000                   00  77      77             \n"
                + "         00000000              00000                        \n"
                + "           0000000000000000000000000                        \n"
                + "              0000000000000000000                           \n"
                + "                     000000                                 \n"
                + "                                                            \n"
                + "=============== DESCRIÇÃO DA APLICAÇÃO ======================\n"
                + "  O professor desafiou seus alunos a criarem uma máquina     \n"
                + " inteligente. Lógica... café... e tudo que há de programação,\n"
                + " estes foram os ingredientes escolhidos para criar a         \n"
                + " aplicação perfeita... Mas o aluno Álex Prado acidentalmente \n"
                + " acrescentou um ingrediente extra na mistura...              \n"
                + " O ELEMENTO C#... E assim nasceu o S.U.E.D, usando seu ultra \n"
                + " conhecimento milenar, ele tem dedicado seus clocks          \n"
                + " demonstrando que domina o passado, o presente e o futuro.   \n"
                + "=============================================================  ";

            /** FRASE DE ELOGIO */
            string fraseElogio = "Oh máquina suprema, conhecedora de tudo e dominadora do passado, presente e futuro";

            /** RESPOSTA PADRÃO QUANDO O TRUQUE NÃO É ATIVADO */
            string respostaPadrao = "Não tente me enganar, eu só respondo para o meu mestre!";

            /** VARIÁVEL QUE ARMAZENARÁ A RESPOSTA DA PERGUNTA */
            string resposta = "";

            #endregion

            /** ALTERA A COR PARA VERDE E IMPRIME A SAUDAÇÃO */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(saudacao);

            #region NÚCLEO DA APLICAÇÃO
            do
            {
                /** IMPRIME TEXTO EM QUE A MÁQUINA SOLICITA A PERGUNTA */
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine("Faça-me qualquer pergunta, eu lhe darei a respota!");
                Console.ResetColor();
                Console.WriteLine();

                /** VARIÁVEL QUE ARMAZENARÁ TEMPORARIAMENTE CADA CARACTERE DIGITADO */
                ConsoleKeyInfo key;

                /** LÊ O PRIMEIRO CARACTERE DIGITADO SEM IMPRIMI-LO NO CONSOLE */
                key = Console.ReadKey(true);

                #region AQUI INICIA O TRUQUE DE MESTRE
                if (key.KeyChar == ';')
                {
                    /** LOOP CIRCULAR PARA LER TODAS OS CARACTERES DIGITADOS */
                    do
                    {
                        /** LÊ O CARACTERE DIGITADO SEM IMPRIMI-LO NO CONSOLE */
                        key = Console.ReadKey(true);

                        /** VERIFICA SE O CARACTERE DIGITADO NÃO É A TECLA 'ENTER' OU A TECLA 'ESC' */
                        if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                        {
                            /** VERIFICA SE O CARACTERE DIGITADO É UM ASCENTO */
                            if (key.KeyChar != '\0')
                            {
                                /** GUARDA O CARACTERE DIGITADO */
                                resposta += key.KeyChar;
                                /** VERIFICA SE TODOS OS CARACTERES DA FRASE DE ELOGIO FORAM USADOS. SE 'NÃO' IMRIME UM CARACTERE NÃO UTILIZADO, SE 'SIM' IMPRIME UM PONTO */
                                if (resposta.Length <= fraseElogio.Length)
                                    Console.Write(fraseElogio.ToCharArray()[resposta.Length - 1]);
                                else
                                    Console.Write(".");
                            }
                        }

                        /** VERIFICA SE O BACKSPACE FOI PRESSIONADO */
                        else if (key.Key == ConsoleKey.Backspace)
                        {
                            /** VERIFICA SE A RESPOSTA ESTÁ VAZIA, SE 'SIM' NÃO FAZ NADA, SE 'NÃO' REMOVE UM CARACTERE E APAGA UM CARACTERE DO CONSOLE */
                            if (resposta.Length != 0)
                            {
                                resposta = resposta.Remove(resposta.Length - 1);
                                Console.Write("\b \b");
                            }
                        }

                        /** SE O 'ENTER' FOI PRESSIONADO, FINALIZA A LEITURA DOS CARACTERES DA RESPOSTA */
                        else
                        {
                            break;
                        }
                    } while (true);

                    /** LÊ O TODA A LINHA DIGITADA (AQUI É O MOMENTO DE TERMINAR A ESCRITA DO ELOGIO E DA PERGUNTA) */
                    Console.ReadLine();

                    #region EFEITO DE PROCESSAMENTO

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.Write("PROCESSANDO");
                    Console.ResetColor();
                    Console.Beep(475, 300);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(".");
                    Console.Beep(475, 300);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(".");
                    Console.Beep(500, 250);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(".");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Beep(475, 200);

                    #endregion

                    /** IMPRIME A RESPOSTA DIGITADA */
                    Console.WriteLine("A RESPOSTA É: {0}", resposta);

                    /** LIMPA A VARIÁVEL PARA UMA NOVA RESPOSTA */
                    resposta = "";
                }

                #endregion

                /** SE A TECLA 'ESC' FOR A PRIMEIRA DIGITADA FINALIZA A APLICAÇÃO */
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                /** SE A TECLA 'ENTER' FOR A PRIMEIRA DIGITADA, A MÁQUINA SOLICITA QUE SEJA FEITA UMA PERGUNTA */
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    Console.WriteLine("Não vou responder se não houver pergunta!");
                }

                /** SE O TRUQUE NÃO FOI DISPARADO, LÊ TODA A LINHA DIGITADA E IMPRIME RESPOSTA PADRÃO */
                else
                {
                    Console.Write(key.KeyChar);
                    Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(respostaPadrao);
                }
            } while (true);

            #endregion
        }
    }
}
