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
                + "  O professor desafiou seus alunos a criar uma máquina       \n"
                + " inteligente. Lógica... café... e tudo que há de programação,\n"
                + " estes foram os ingredientes escolhidos para criar a         \n"
                + " aplicação perfeita... Mas o aluno Álex Prado acidentalmente \n"
                + " acrescentou um ingrediente extra na mistura...              \n"
                + " O ELEMENTO C#... E assim nasceu o SUED, usando seu ultra    \n"
                + " conhecimento milenar, ele tem dedicado seus clocks          \n"
                + " demonstrando que domina o passado, o presente e o futuro.   \n"
                + "=============================================================  ";
            string fraseElogio = "Oh máquina suprema, conhecedora de tudo e dominadora do passado, presente e futuro";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(saudacao);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            //ConsoleKeyInfo key;
            //do
            //{
            //    Console.WriteLine("Faça-me qualquer pergunta, eu lhe darei a respota!");
            //    key = Console.ReadKey(true);
            //    if (key.KeyChar == ';')
            //    {
            //        Console.Write("A");
            //    }
            //    break;
            //} while (true);
        }
    }
}
