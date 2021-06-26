using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace proje
{
    class Program
    {

        static int bestScore;
        static int computerScore;
        static int playerScore;
        static int time;



        static void Main(string[] args)
        {
            char[] playerBlocks = new char[12] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L' };
            char[] computerBlocks = new char[12] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L' };

            char[] box0h = new char[12 * 9];
            char[] box1h = new char[20];
            char[] box2h = new char[20];
            char[] box3h = new char[20];
            char[] box0c = new char[12 * 9];
            char[] box1c = new char[20];
            char[] box2c = new char[20];
            char[] box3c = new char[20];

            int[] counthuman = new int[12];
            int[] countcomputer = new int[12];

            int spaceLenght = 10;

            int box1hBosluk = 20;
            int box2hBosluk = 20;
            int box3hBosluk = 20;
            int box1cBosluk = 20;
            int box2cBosluk = 20;
            int box3cBosluk = 20;
            for (int i = 0; i < 20; i++)
            {
                box1h[i] = ' ';
                box2h[i] = ' ';
                box3h[i] = ' ';

                box1c[i] = ' ';
                box2c[i] = ' ';
                box3c[i] = ' ';
            }


            for (int i = 0; i < 12; i++)
            {
                counthuman[i] = 0;
                countcomputer[i] = 0;
            }


            Random rnd = new Random();
            int randomNumber4_9;


            int x = 0;
            for (int i = 0; i < 12; i++)//-------creating  blocks
            {
                randomNumber4_9 = rnd.Next(4, 10);


                for (int j = 0; j < randomNumber4_9; j++)
                {

                    box0h[x] = playerBlocks[i];
                    box0c[x] = computerBlocks[i];
                    x = x + 1;
                }
            }

            int an = 0;
            int bn = 0;
            int cn = 0;
            int dn = 0;
            int en = 0;
            int fn = 0;
            int gn = 0;
            int hn = 0;
            int ın = 0;
            int jn = 0;
            int kn = 0;
            int ln = 0;

            for (int i = 0; i < box0h.Length; i++)
            {
                if (box0h[i] == 'A')
                    an = an + 1;
                if (box0h[i] == 'B')
                    bn = bn + 1;
                if (box0h[i] == 'C')
                    cn = cn + 1;
                if (box0h[i] == 'D')
                    dn = dn + 1;
                if (box0h[i] == 'E')
                    en = en + 1;
                if (box0h[i] == 'F')
                    fn = fn + 1;
                if (box0h[i] == 'G')
                    gn = gn + 1;
                if (box0h[i] == 'H')
                    hn = hn + 1;
                if (box0h[i] == 'I')
                    ın = ın + 1;
                if (box0h[i] == 'J')
                    jn = jn + 1;
                if (box0h[i] == 'K')
                    kn = kn + 1;
                if (box0h[i] == 'L')
                    ln = ln + 1;

            }


            for (int i = 0; i < playerBlocks.Length; i++)
            {
                for (int j = 0; j < box0h.Length; j++)
                {
                    if (playerBlocks[i] == box0h[j])
                    {
                        counthuman[i] = counthuman[i] + 1;
                    }
                }
            }

            for (int i = 0; i < computerBlocks.Length; i++)
            {
                for (int j = 0; j < box0c.Length; j++)
                {
                    if (computerBlocks[i] == box0c[j])
                    {
                        countcomputer[i] = countcomputer[i] + 1;
                    }
                }
            }


            Stopwatch watch = new Stopwatch();

            watch.Start();

            while (true)
            {
                if (watch.Elapsed.Minutes >= 1)
                {
                    break;
                }

                playerScore = 0;
                bestScore = 0;
                computerScore = 0;
                int box1cScore = 0;
                int box2cScore = 0;
                int box3cScore = 0;
                int box1hScore = 0;
                int box2hScore = 0;
                int box3hScore = 0;

                for (int i = 0; i < 20; i++)
                {
                    if (box1h[i] != ' ')
                    box1hScore = box1hScore + 1;
                    
                    if (box2h[i] != ' ')
                     box2hScore = box2hScore + 1;
                    
                    if (box3h[i] != ' ')
                     box3hScore = box3hScore + 1;
                    
                    if (box1c[i] != ' ')
                    box1cScore = box1cScore + 1;
                    
                    if (box2c[i] != ' ')
                     box2cScore = box2cScore + 1;
                    
                    if (box3c[i] != ' ')
                    box3cScore = box3cScore + 1;
                }

                
                playerScore = box1hScore + box2hScore + box3hScore;
                computerScore = box1cScore + box2cScore + box3cScore;

                Console.Clear();
                Console.WriteLine("                     Human" + "                        Time= " + (60 - watch.Elapsed.Seconds) + "                   Computer");
                Console.WriteLine("                     --------------                                          --------------");
                Console.WriteLine("                     Score =   " + playerScore + "                      |                      Score =   " + computerScore);
                Console.WriteLine("                                                      |");
                Console.WriteLine("  [0]                                                 |   [0]");

                for (int i = 0; i < 21; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 65)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 65)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                    if (i == 1)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 66)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("             5   10   15   20             | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 66)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("             5   10   15   20");
                    }
                    if (i == 2)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 67)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("         ----+----+----+----+             | ");
                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 67)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("         ----+----+----+----+");
                    }
                    if (i == 3)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 68)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("     [1] ");
                        for (int j = 0; j < box1h.Length; j++)
                        {
                            Console.Write(box1h[j]);
                        }
                        if (box1hScore >= 10)
                        {
                            Console.Write(" " + box1hScore + "          | ");
                        }
                        else
                            Console.Write(" " + box1hScore + "           | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 68)
                            {
                                Console.Write(box0c[j]);
                            }

                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("     [1] ");
                        for (int j = 0; j < box1c.Length; j++)
                        {
                            Console.Write(box1c[j]);
                        }
                        Console.Write(" " + box1cScore);
                        Console.WriteLine();
                    }
                    if (i == 4)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 69)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("     [2] ");
                        for (int j = 0; j < box2h.Length; j++)
                        {
                            Console.Write(box2h[j]);
                        }
                        if (box2hScore >= 10)
                        {
                            Console.Write(" " + box2hScore + "          | ");
                        }
                        else
                            Console.Write(" " + box2hScore + "           | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 69)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("     [2] ");
                        for (int j = 0; j < box2c.Length; j++)
                        {
                            Console.Write(box2c[j]);
                        }
                        Console.Write(" " + box2cScore);
                        Console.WriteLine();
                    }
                    if (i == 5)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 70)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("     [3] ");
                        for (int j = 0; j < box3h.Length; j++)
                        {
                            Console.Write(box3h[j]);
                        }
                        if (box3hScore >= 10)
                        {
                            Console.Write(" " + box3hScore + "          | ");
                        }
                        else
                            Console.Write(" " + box3hScore + "           | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 70)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("     [3] ");
                        for (int j = 0; j < box3c.Length; j++)
                        {
                            Console.Write(box3c[j]);
                        }
                        Console.Write(" " + box3cScore);
                        Console.WriteLine();
                    }
                    if (i == 6)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 71)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 71)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    if (i == 7)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 72)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 72)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    if (i == 8)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 73)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 73)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    if (i == 9)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 74)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 74)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    if (i == 10)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 75)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 75)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("         Best Score =  " + bestScore);
                    }
                    if (i == 11)
                    {
                        Console.Write(counthuman[i] + " ");

                        for (int j = 0; j < box0h.Length; j++)
                        {
                            if (Convert.ToInt32(box0h[j]) == 76)
                            {
                                Console.Write(box0h[j]);
                            }
                        }

                        spaceLenght = 10 - counthuman[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("                                          | ");

                        Console.Write(countcomputer[i] + " ");

                        for (int j = 0; j < box0c.Length; j++)
                        {
                            if (Convert.ToInt32(box0c[j]) == 76)
                            {
                                Console.Write(box0c[j]);
                            }
                        }

                        spaceLenght = 10 - countcomputer[i];
                        for (int k = 0; k < spaceLenght; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    if (i == 12)
                    {
                        Console.WriteLine("                                                      |                          5   10   15   20");
                    }
                    if (i == 13)
                    {
                        Console.WriteLine("                                                      |                      ----+----+----+----+");
                    }
                    if (i == 14)
                    {
                        Console.WriteLine("                                                      |                  [1]                      0");
                    }
                    if (i == 15)
                    {
                        Console.WriteLine("                                                      |                  [2]                      0");
                    }
                    if (i == 16)
                    {
                        Console.WriteLine("                                                      |                  [3]                      0");
                    }
                    if (i == 17)
                    {
                        Console.WriteLine("                                                      |");
                    }
                    if (i == 18)
                    {
                        Console.WriteLine("                                                      |");
                    }
                    if (i == 19)
                    {
                        for (int j = 0; j <= 40; j++)
                        {
                            Console.Write(box0h[j]);

                        }
                        Console.Write("                          ");

                        for (int j = 0; j <= 40; j++)
                        {
                            Console.Write(box0c[j]);
                        }

                        Console.WriteLine();
                    }
                    if (i == 20)
                    {
                        for (int j = 41; j < 108; j++)
                        {
                            Console.Write(box0h[j]);
                        }

                        for (int j = 41; j < 108; j++)
                        {
                            Console.Write(box0c[j]);
                        }
                    }


                }



                Random rndharf = new Random();//sonsuz döngü
                char computerharf = playerBlocks[rndharf.Next(0, 12)];
                Random rndsayı = new Random();
                int computersayı = rndsayı.Next(0, 4);

              
                if (computerharf == 'A')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[0])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 65)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[0]; i++)
                                    {
                                        box1c[i] = 'A';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[0];
                                    countcomputer[0] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[0])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 65)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[0]; i++)
                                    {
                                        box2c[i] = 'A';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[0];
                                    countcomputer[0] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[0])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 65)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[0]; i++)
                                    {
                                        box3c[i] = 'A';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[0];
                                    countcomputer[0] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'A' || box2c[k] == 'A' || box3c[k] == 'A')
                            {
                                int anumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'A')
                                    {
                                        anumber = anumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'A')
                                    {
                                        anumber = anumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'A')
                                    {
                                        anumber = anumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[0] = anumber;
                            }
                        }
                       
                    }

                }
                if (computerharf == 'B')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[1])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 66)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[1]; i++)
                                    {
                                        box1c[i] = 'B';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[1];
                                    countcomputer[1] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[1])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 66)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[1]; i++)
                                    {
                                        box2c[i] = 'B';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[1];
                                    countcomputer[1] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[1])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 66)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[1]; i++)
                                    {
                                        box3c[i] = 'B';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[1];
                                    countcomputer[1] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'B' || box2c[k] == 'B' || box3c[k] == 'B')
                            {
                                int bnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'B')
                                    {
                                        bnumber = bnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'B')
                                    {
                                        bnumber = bnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'B')
                                    {
                                        bnumber = bnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[1] = bnumber;
                            }
                        }
                       
                       
                    }

                }
                if (computerharf == 'C')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[2])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 67)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[2]; i++)
                                    {
                                        box1c[i] = 'C';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[2];
                                    countcomputer[2] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[2])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 67)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[2]; i++)
                                    {
                                        box2c[i] = 'C';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[2];
                                    countcomputer[2] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[2])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 67)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[2]; i++)
                                    {
                                        box3c[i] = 'C';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[2];
                                    countcomputer[2] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {

                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'C' || box2c[k] == 'C' || box3c[k] == 'C')
                            {
                                int cnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'C')
                                    {
                                        cnumber = cnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'C')
                                    {
                                        cnumber = cnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'C')
                                    {
                                        cnumber = cnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[2] = cnumber;
                            }
                        }
                        
                    }

                }
                if (computerharf == 'D')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[3])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 68)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[3]; i++)
                                    {
                                        box1c[i] = 'D';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[3];
                                    countcomputer[3] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[3])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 68)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[3]; i++)
                                    {
                                        box2c[i] = 'D';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[3];
                                    countcomputer[3] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[3])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 68)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[3]; i++)
                                    {
                                        box3c[i] = 'D';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[3];
                                    countcomputer[3] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'D' || box2c[k] == 'D' || box3c[k] == 'D')
                            {
                                int dnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'D')
                                    {
                                        dnumber = dnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'D')
                                    {
                                        dnumber = dnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'D')
                                    {
                                        dnumber = dnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[3] = dnumber;
                            }
                        }

                       
                    }

                }
                if (computerharf == 'E')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[4])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 69)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[4]; i++)
                                    {
                                        box1c[i] = 'E';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[4];
                                    countcomputer[4] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[4])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 69)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[4]; i++)
                                    {
                                        box2c[i] = 'E';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[4];
                                    countcomputer[4] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[4])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 69)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[4]; i++)
                                    {
                                        box3c[i] = 'E';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[4];
                                    countcomputer[4] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else 
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'E' || box2c[k] == 'E' || box3c[k] == 'E')
                            {
                                int enumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'E')
                                    {
                                        enumber = enumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'E')
                                    {
                                        enumber = enumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'E')
                                    {
                                        enumber = enumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[4] = enumber;
                            }
                        }
                       
                    }

                }
                if (computerharf == 'F')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[5])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 70)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[5]; i++)
                                    {
                                        box1c[i] = 'F';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[5];
                                    countcomputer[5] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[5])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 70)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[5]; i++)
                                    {
                                        box2c[i] = 'F';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[5];
                                    countcomputer[5] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[5])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 70)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[5]; i++)
                                    {
                                        box3c[i] = 'F';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[5];
                                    countcomputer[5] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else 
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'F' || box2c[k] == 'F' || box3c[k] == 'F')
                            {
                                int fnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'F')
                                    {
                                        fnumber = fnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'F')
                                    {
                                        fnumber = fnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'F')
                                    {
                                        fnumber = fnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[5] = fnumber;
                            }
                        }
                        
                    }

                }
                if (computerharf == 'G')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[6])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 71)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[6]; i++)
                                    {
                                        box1c[i] = 'G';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[6];
                                    countcomputer[6] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[6])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 71)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[6]; i++)
                                    {
                                        box2c[i] = 'G';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[6];
                                    countcomputer[6] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[6])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 71)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[6]; i++)
                                    {
                                        box3c[i] = 'G';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[6];
                                    countcomputer[6] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {

                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'G' || box2c[k] == 'G' || box3c[k] == 'G')
                            {
                                int gnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'G')
                                    {
                                        gnumber = gnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'G')
                                    {
                                        gnumber = gnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'G')
                                    {
                                        gnumber = gnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[6] = gnumber;
                            }
                        }
                      
                    }

                }
                if (computerharf == 'H')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[7])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 72)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[7]; i++)
                                    {
                                        box1c[i] = 'H';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[7];
                                    countcomputer[7] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[7])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 72)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[7]; i++)
                                    {
                                        box2c[i] = 'H';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[7];
                                    countcomputer[7] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[7])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 72)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[7]; i++)
                                    {
                                        box3c[i] = 'H';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[7];
                                    countcomputer[7] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else 
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'H' || box2c[k] == 'H' || box3c[k] == 'H')
                            {
                                int hnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'H')
                                    {
                                        hnumber = hnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'H')
                                    {
                                        hnumber = hnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'H')
                                    {
                                        hnumber = hnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[7] = hnumber;
                            }
                        }
                      
                    }

                }
                if (computerharf == 'I')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[8])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 73)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[8]; i++)
                                    {
                                        box1c[i] = 'I';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[8];
                                    countcomputer[8] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[8])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 73)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[8]; i++)
                                    {
                                        box2c[i] = 'I';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[8];
                                    countcomputer[8] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[8])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 73)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[8]; i++)
                                    {
                                        box3c[i] = 'I';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[8];
                                    countcomputer[8] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'I' || box2c[k] == 'I' || box3c[k] == 'I')
                            {
                                int ınumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'I')
                                    {
                                        ınumber = ınumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'I')
                                    {
                                        ınumber = ınumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'I')
                                    {
                                        ınumber = ınumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[8] = ınumber;
                            }
                        }
                       
                    }

                }
                if (computerharf == 'J')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[9])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 74)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[9]; i++)
                                    {
                                        box1c[i] = 'J';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[9];
                                    countcomputer[9] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[9])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 74)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[9]; i++)
                                    {
                                        box2c[i] = 'J';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[9];
                                    countcomputer[9] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[9])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 74)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[9]; i++)
                                    {
                                        box3c[i] = 'J';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[9];
                                    countcomputer[9] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'J' || box2c[k] == 'J' || box3c[k] == 'J')
                            {
                                int jnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'J')
                                    {
                                        jnumber = jnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'J')
                                    {
                                        jnumber = jnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'J')
                                    {
                                        jnumber = jnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[9] = jnumber;
                            }
                        }
                        
                    }

                }
                if (computerharf == 'K')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[10])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 75)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[10]; i++)
                                    {
                                        box1c[i] = 'K';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[10];
                                    countcomputer[10] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[10])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 75)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[10]; i++)
                                    {
                                        box2c[i] = 'K';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[10];
                                    countcomputer[10] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[10])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 75)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[10]; i++)
                                    {
                                        box3c[i] = 'K';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[10];
                                    countcomputer[10] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else 
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'K' || box2c[k] == 'K' || box3c[k] == 'K')
                            {
                                int knumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'K')
                                    {
                                        knumber = knumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'K')
                                    {
                                        knumber = knumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'K')
                                    {
                                        knumber = knumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[10] = knumber;
                            }
                        }
                        
                    }

                }
                if (computerharf == 'L')
                {
                    if (computersayı == 1)
                    {
                        if (box1cBosluk >= countcomputer[11])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 76)
                                {
                                    for (int i = 20 - box1cBosluk; i < 20 - box1cBosluk + countcomputer[11]; i++)
                                    {
                                        box1c[i] = 'L';
                                    }

                                    box1cBosluk = box1cBosluk - countcomputer[11];
                                    countcomputer[11] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 2)
                    {
                        if (box2cBosluk >= countcomputer[11])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 76)
                                {
                                    for (int i = 20 - box2cBosluk; i < 20 - box2cBosluk + countcomputer[11]; i++)
                                    {
                                        box2c[i] = 'L';
                                    }

                                    box2cBosluk = box2cBosluk - countcomputer[11];
                                    countcomputer[11] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else if (computersayı == 3)
                    {
                        if (box3cBosluk >= countcomputer[11])
                        {

                            for (int j = 0; j < box0c.Length; j++)
                            {
                                if (Convert.ToInt32(box0c[j]) == 76)
                                {
                                    for (int i = 20 - box3cBosluk; i < 20 - box3cBosluk + countcomputer[11]; i++)
                                    {
                                        box3c[i] = 'L';
                                    }

                                    box3cBosluk = box3cBosluk - countcomputer[11];
                                    countcomputer[11] = 0;
                                    box0c[j] = ' ';

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (computersayı == 0 && box1c[k] == 'A' || box2c[k] == 'A' || box3c[k] == 'A')
                            {
                                int lnumber = 0;
                                for (int i = 0; i < 20; i++)
                                {
                                    if (box1c[i] == 'L')
                                    {
                                        lnumber = lnumber + 1;
                                        box1c[i] = ' ';

                                    }
                                    else if (box2c[i] == 'L')
                                    {
                                        lnumber = lnumber + 1;
                                        box2c[i] = ' ';
                                    }
                                    else if (box3c[i] == 'L')
                                    {
                                        lnumber = lnumber + 1;
                                        box3c[i] = ' ';
                                    }
                                }
                                countcomputer[1] = lnumber;
                            }
                        }
                      
                    }

                }

                ConsoleKeyInfo harf;
                ConsoleKeyInfo sayı;

                while (Console.KeyAvailable == false)
                {
                    Thread.Sleep(250);
                }
                harf = Console.ReadKey(true);
                sayı = Console.ReadKey(true);
               
                
                
                   
                if (harf.Key == ConsoleKey.A)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[0])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {

                                if (Convert.ToInt32(box0h[j]) == 65)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[0]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[0]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[0]; i++)
                                    {
                                        box1h[i] = 'A';
                                    }

                                    box1hBosluk = box1hBosluk - counthuman[0];
                                    counthuman[0] = 0;
                                    
                           
                                }

                            }
                        }

                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[0])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 65)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[0]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[0]];
                                    }
                                   
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[0]; i++)
                                    {
                                        box2h[i] = 'A';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[0];
                                    counthuman[0] = 0;
                                  

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[0])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 65)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[0]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[0]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[0]; i++)
                                    {
                                        box3h[i] = 'A';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[0];
                                    counthuman[0] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)//geriçek
                    {
                        int anumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'A')
                            {
                                anumber = anumber + 1;
                                for (int j = i; j < 20 - an; j++)
                                {
                                    box1h[j] = box1h[j + an];
                                }

                            }
                            else if (box2h[i] == 'A')
                            {
                                anumber = anumber + 1;
                                for (int j = i; j < 20 - an; j++)
                                {
                                    box2h[j] = box2h[j + an];
                                }
                            }
                            else if (box3h[i] == 'A')
                            {
                                anumber = anumber + 1;
                                for (int j = i; j < 20 - an; j++)
                                {
                                    box3h[j] = box3h[j + an];
                                }
                            }
                        }
                        counthuman[0] = anumber;

                        for (int i = 0; i < 108 - an; i++)
                        {
                            box0h[i] = box0h[i + anumber];
                        }
                        for (int i = 0; i < an; i++)
                        {
                            box0h[i] = 'A';
                        }

                    }

                }
                if (harf.Key == ConsoleKey.B)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[1])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 66)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[1]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[1]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[1]; i++)
                                    {
                                        box1h[i] = 'B';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[1];
                                    counthuman[1] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[1])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 66)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[1]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[1]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[1]; i++)
                                    {
                                        box2h[i] = 'B';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[1];
                                    counthuman[1] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[1])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 66)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[1]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[1]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[1]; i++)
                                    {
                                        box3h[i] = 'B';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[1];
                                    counthuman[1] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int bnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'B')
                            {
                                bnumber = bnumber + 1;
                                for (int j = i; j < 20 - bn; j++)
                                {
                                    box1h[j] = box1h[j + bn];
                                }

                            }
                            else if (box2h[i] == 'B')
                            {
                                bnumber = bnumber + 1;
                                for (int j = i; j < 20 - bn; j++)
                                {
                                    box2h[j] = box2h[j + bn];
                                }
                            }
                            else if (box3h[i] == 'B')
                            {
                                bnumber = bnumber + 1;
                                for (int j = i; j < 20 - bn; j++)
                                {
                                    box3h[j] = box3h[j + bn];
                                }
                            }
                        }
                        counthuman[1] = bnumber;
                        for (int i = an; i < 108 - bn; i++)
                        {
                            box0h[i] = box0h[i + bn];
                        }
                        for (int i = an; i < an + bn; i++)
                        {
                            box0h[i] = 'B';
                        }
                       
                    }
                }
                if (harf.Key == ConsoleKey.C)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[2])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 67)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[2]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[2]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[2]; i++)
                                    {
                                        box1h[i] = 'C';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[2];
                                    counthuman[2] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[2])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 67)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[2]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[2]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[2]; i++)
                                    {
                                        box2h[i] = 'C';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[2];
                                    counthuman[2] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[2])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 67)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[2]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[2]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[2]; i++)
                                    {
                                        box3h[i] = 'C';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[2];
                                    counthuman[2] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int cnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'C')
                            {
                                cnumber = cnumber + 1;
                                for (int j = i; j < 20 - cn; j++)
                                {
                                    box1h[j] = box1h[j + cn];
                                }

                            }
                            else if (box2h[i] == 'C')
                            {
                                cnumber = cnumber + 1;
                                for (int j = i; j < 20 - cn; j++)
                                {
                                    box2h[j] = box2h[j + cn];
                                }
                            }
                            else if (box3h[i] == 'C')
                            {
                                cnumber = cnumber + 1;
                                for (int j = i; j < 20 - cn; j++)
                                {
                                    box3h[j] = box3h[j + cn];
                                }
                            }
                        }
                        counthuman[2] = cnumber;
                        for (int i = an+bn; i < an + bn+cn; i++)
                        {
                            box0h[i] = 'C';
                        }

                    }
                }
                if (harf.Key == ConsoleKey.D)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[3])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 68)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[3]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[3]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[3]; i++)
                                    {
                                        box1h[i] = 'D';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[3];
                                    counthuman[3] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[3])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 68)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[3]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[3]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[3]; i++)
                                    {
                                        box2h[i] = 'D';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[3];
                                    counthuman[3] = 0;
                                    

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[3])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 68)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[3]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[3]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[3]; i++)
                                    {
                                        box3h[i] = 'D';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[3];
                                    counthuman[3] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int dnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'D')
                            {
                                dnumber = dnumber + 1;
                                for (int j = i; j < 20 - dn; j++)
                                {
                                    box1h[j] = box1h[j + dn];
                                }

                            }
                            else if (box2h[i] == 'D')
                            {
                                dnumber = dnumber + 1;
                                for (int j = i; j < 20 - dn; j++)
                                {
                                    box2h[j] = box2h[j + dn];
                                }
                            }
                            else if (box3h[i] == 'D')
                            {
                                dnumber = dnumber + 1;
                                for (int j = i; j < 20 - dn; j++)
                                {
                                    box3h[j] = box3h[j + dn];
                                }
                            }
                        }
                        counthuman[3] = dnumber;
                        for (int i = an + bn+cn; i < an + bn + cn+dn; i++)
                        {
                            box0h[i] = 'D';
                        }
                    }

                }
                if (harf.Key == ConsoleKey.E)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[4])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 69)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[4]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[4]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[4]; i++)
                                    {
                                        box1h[i] = 'E';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[4];
                                    counthuman[4] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[4])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 69)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[4]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[4]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[4]; i++)
                                    {
                                        box2h[i] = 'E';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[4];
                                    counthuman[4] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[4])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 69)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[4]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[4]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[4]; i++)
                                    {
                                        box3h[i] = 'E';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[4];
                                    counthuman[4] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int enumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'E')
                            {
                                enumber = enumber + 1;
                                for (int j = i; j < 20 - en; j++)
                                {
                                    box1h[j] = box1h[j + en];
                                }

                            }
                            else if (box2h[i] == 'E')
                            {
                                enumber = enumber + 1;
                                for (int j = i; j < 20 - en; j++)
                                {
                                    box2h[j] = box2h[j + en];
                                }
                            }
                            else if (box3h[i] == 'E')
                            {
                                enumber = enumber + 1;
                                for (int j = i; j < 20 - en; j++)
                                {
                                    box3h[j] = box3h[j + en];
                                }
                            }
                        }
                        counthuman[4] = enumber;
                        for (int i = an + bn+cn+dn; i < an + bn + cn+dn+en; i++)
                        {
                            box0h[i] = 'E';
                        }
                    }
                }
                if (harf.Key == ConsoleKey.F)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[5])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 70)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[5]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[5]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[5]; i++)
                                    {
                                        box1h[i] = 'F';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[5];
                                    counthuman[5] = 0;
                                  

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[5])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 70)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[5]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[5]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[5]; i++)
                                    {
                                        box2h[i] = 'F';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[5];
                                    counthuman[5] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[5])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 70)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[5]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[5]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[5]; i++)
                                    {
                                        box3h[i] = 'F';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[5];
                                    counthuman[5] = 0;
                                 

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int fnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'F')
                            {
                                fnumber = fnumber + 1;
                                for (int j = i; j < 20 - fn; j++)
                                {
                                    box1h[j] = box1h[j + fn];
                                }
                            }
                            else if (box2h[i] == 'F')
                            {
                                fnumber = fnumber + 1;
                                for (int j = i; j < 20 - fn; j++)
                                {
                                    box2h[j] = box2h[j + fn];
                                }
                            }
                            else if (box3h[i] == 'F')
                            {
                                fnumber = fnumber + 1;
                                for (int j = i; j < 20 - fn; j++)
                                {
                                    box3h[j] = box3h[j + fn];
                                }
                            }
                        }
                        counthuman[5] = fnumber;
                        for (int i = an + bn+cn+dn+en; i < an + bn + cn+dn+en+fn; i++)
                        {
                            box0h[i] = 'F';
                        }
                    }
                }
                if (harf.Key == ConsoleKey.G)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[6])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 71)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[6]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[6]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[6]; i++)
                                    {
                                        box1h[i] = 'G';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[6];
                                    counthuman[6] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[6])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 71)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[6]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[6]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[6]; i++)
                                    {
                                        box2h[i] = 'G';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[6];
                                    counthuman[6] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[6])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 71)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[6]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[6]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[6]; i++)
                                    {
                                        box3h[i] = 'G';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[6];
                                    counthuman[6] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int gnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'G')
                            {
                                gnumber = gnumber + 1;
                                for (int j = i; j < 20 - gn; j++)
                                {
                                    box1h[j] = box1h[j + gn];
                                }

                            }
                            else if (box2h[i] == 'G')
                            {
                                gnumber = gnumber + 1;
                                for (int j = i; j < 20 - gn; j++)
                                {
                                    box2h[j] = box2h[j + gn];
                                }
                            }
                            else if (box3h[i] == 'G')
                            {
                                gnumber = gnumber + 1;
                                for (int j = i; j < 20 - gn; j++)
                                {
                                    box3h[j] = box3h[j + gn];
                                }
                            }
                        }
                        counthuman[6] = gnumber;
                        for (int i = an + bn + cn + dn + en+fn; i < an + bn + cn + dn + en + fn+gn; i++)
                        {
                            box0h[i] = 'G';
                        }
                    }
                }
                if (harf.Key == ConsoleKey.H)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[7])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 72)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[7]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[7]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[7]; i++)
                                    {
                                        box1h[i] = 'H';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[7];
                                    counthuman[7] = 0;
                               

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[7])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 72)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[7]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[7]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[7]; i++)
                                    {
                                        box2h[i] = 'H';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[7];
                                    counthuman[7] = 0;
                                  

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[7])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 72)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[7]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[7]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[7]; i++)
                                    {
                                        box3h[i] = 'H';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[7];
                                    counthuman[7] = 0;
                                 

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int hnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'H')
                            {
                                hnumber = hnumber + 1;
                                for (int j = i; j < 20 - hn; j++)
                                {
                                    box1h[j] = box1h[j + hn];
                                }

                            }
                            else if (box2h[i] == 'H')
                            {
                                hnumber = hnumber + 1;
                                for (int j = i; j < 20 - hn; j++)
                                {
                                    box2h[j] = box2h[j + hn];
                                }
                            }
                            else if (box3h[i] == 'H')
                            {
                                hnumber = hnumber + 1;
                                for (int j = i; j < 20 - hn; j++)
                                {
                                    box3h[j] = box3h[j + hn];
                                }
                            }
                        }
                        counthuman[7] = hnumber;
                        for (int i = an + bn + cn + dn + en + fn+gn; i < an + bn + cn + dn + en + fn + gn+hn; i++)
                        {
                            box0h[i] = 'H';
                        }
                    }
                }
                if (harf.Key == ConsoleKey.I)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[8])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 73)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[8]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[8]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[8]; i++)
                                    {
                                        box1h[i] = 'I';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[8];
                                    counthuman[8] = 0;
                                 

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[8])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 73)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[8]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[8]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[8]; i++)
                                    {
                                        box2h[i] = 'I';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[8];
                                    counthuman[8] = 0;
                                  

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[8])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 73)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[8]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[8]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[8]; i++)
                                    {
                                        box3h[i] = 'I';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[8];
                                    counthuman[8] = 0;
                                   

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int ınumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'I')
                            {
                                ınumber = ınumber + 1;
                                for (int j = i; j < 20 - ın; j++)
                                {
                                    box1h[j] = box1h[j + ın];
                                }

                            }
                            else if (box2h[i] == 'I')
                            {
                                ınumber = ınumber + 1;
                                for (int j = i; j < 20 - ın; j++)
                                {
                                    box2h[j] = box2h[j + ın];
                                }
                            }
                            else if (box3h[i] == 'I')
                            {
                                ınumber = ınumber + 1;
                                for (int j = i; j < 20 - ın; j++)
                                {
                                    box3h[j] = box3h[j + ın];
                                }
                            }
                        }
                        counthuman[8] = ınumber;
                        for (int i = an + bn + cn + dn + en + fn + gn+hn; i < an + bn + cn + dn + en + fn + gn + hn+ın; i++)
                        {
                            box0h[i] = 'I';
                        }
                    }
                }
                if (harf.Key == ConsoleKey.J)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[9])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 74)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[9]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[9]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[9]; i++)
                                    {
                                        box1h[i] = 'J';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[9];
                                    counthuman[9] = 0;
                                
                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[9])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 74)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[9]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[9]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[9]; i++)
                                    {
                                        box2h[i] = 'J';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[9];
                                    counthuman[9] = 0;
                                

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[9])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 74)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[9]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[9]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[9]; i++)
                                    {
                                        box3h[i] = 'J';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[9];
                                    counthuman[9] = 0;
                                  

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int jnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'J')
                            {
                                jnumber = jnumber + 1;
                                for (int j = i; j < 20 - jn; j++)
                                {
                                    box1h[j] = box1h[j + jn];
                                }

                            }
                            else if (box2h[i] == 'J')
                            {
                                jnumber = jnumber + 1;
                                for (int j = i; j < 20 - jn; j++)
                                {
                                    box2h[j] = box2h[j + jn];
                                }
                            }
                            else if (box3h[i] == 'J')
                            {
                                jnumber = jnumber + 1;
                                for (int j = i; j < 20 - jn; j++)
                                {
                                    box3h[j] = box3h[j + jn];
                                }
                            }
                        }
                        counthuman[9] = jnumber;
                        for (int i = an + bn + cn + dn + en + fn + gn + hn+ın; i < an + bn + cn + dn + en + fn + gn + hn + ın+jn; i++)
                        {
                            box0h[i] = 'J';
                        }
                    }

                }
                if (harf.Key == ConsoleKey.K)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[10])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 75)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[10]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[10]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[10]; i++)
                                    {
                                        box1h[i] = 'K';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[10];
                                    counthuman[10] = 0;
                                  

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[10])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 75)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[10]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[10]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[10]; i++)
                                    {
                                        box2h[i] = 'K';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[10];
                                    counthuman[10] = 0;
                              

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[10])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 75)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[10]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[10]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[10]; i++)
                                    {
                                        box3h[i] = 'K';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[10];
                                    counthuman[10] = 0;
                                

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int knumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'K')
                            {
                                knumber = knumber + 1;
                                for (int j = i; j < 20 - kn; j++)
                                {
                                    box1h[j] = box1h[j + kn];
                                }

                            }
                            else if (box2h[i] == 'K')
                            {
                                knumber = knumber + 1;
                                for (int j = i; j < 20 - kn; j++)
                                {
                                    box2h[j] = box2h[j + kn];
                                }
                            }
                            else if (box3h[i] == 'K')
                            {
                                knumber = knumber + 1;
                                for (int j = i; j < 20 - kn; j++)
                                {
                                    box3h[j] = box3h[j + kn];
                                }
                            }
                        }
                        counthuman[10] = knumber;
                        for (int i = an + bn + cn + dn + en + fn + gn + hn + ın+jn; i < an + bn + cn + dn + en + fn + gn + hn + ın + jn+kn; i++)
                        {
                            box0h[i] = 'K';
                        }
                    }
                }
                if (harf.Key == ConsoleKey.L)
                {
                    if (sayı.Key == ConsoleKey.D1)
                    {
                        if (box1hBosluk >= counthuman[11])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 76)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[11]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[11]];
                                    }
                                    for (int i = 20 - box1hBosluk; i < 20 - box1hBosluk + counthuman[11]; i++)
                                    {
                                        box1h[i] = 'L';
                                    }
                                    box1hBosluk = box1hBosluk - counthuman[11];
                                    counthuman[11] = 0;
                                 

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D2)
                    {
                        if (box2hBosluk >= counthuman[11])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 76)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[11]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[11]];
                                    }
                                    for (int i = 20 - box2hBosluk; i < 20 - box2hBosluk + counthuman[11]; i++)
                                    {
                                        box2h[i] = 'L';
                                    }
                                    box2hBosluk = box2hBosluk - counthuman[11];
                                    counthuman[11] = 0;
                                

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D3)
                    {
                        if (box3hBosluk >= counthuman[11])
                        {

                            for (int j = 0; j < box0h.Length; j++)
                            {
                                if (Convert.ToInt32(box0h[j]) == 76)
                                {
                                    for (int i = j; i < box0h.Length - counthuman[11]; i++)
                                    {
                                        box0h[i] = box0h[i + counthuman[11]];
                                    }
                                    for (int i = 20 - box3hBosluk; i < 20 - box3hBosluk + counthuman[11]; i++)
                                    {
                                        box3h[i] = 'L';
                                    }
                                    box3hBosluk = box3hBosluk - counthuman[11];
                                    counthuman[11] = 0;
                                

                                }
                            }
                        }
                    }
                    else if (sayı.Key == ConsoleKey.D0)
                    {
                        int lnumber = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (box1h[i] == 'L')
                            {
                                lnumber = lnumber + 1;
                                for (int j = i; j < 20 - ln; j++)
                                {
                                    box1h[j] = box1h[j + ln];
                                }

                            }
                            else if (box2h[i] == 'L')
                            {
                                lnumber = lnumber + 1;
                                for (int j = i; j < 20 - ln; j++)
                                {
                                    box2h[j] = box2h[j + ln];
                                }
                            }
                            else if (box3h[i] == 'L')
                            {
                                lnumber = lnumber + 1;
                                for (int j = i; j < 20 - ln; j++)
                                {
                                    box3h[j] = box3h[j + ln];
                                }
                            }
                        }
                        counthuman[11] = lnumber;
                        for (int i = an + bn + cn + dn + en + fn + gn + hn + ın + jn + kn; i < an + bn + cn + dn + en + fn + gn + hn + ın + jn + kn + ln; i++)
                        {
                            box0h[i] = 'L';
                        }
                    }
                }


               
               

               
            }
            watch.Stop();

            if (playerScore > computerScore)
            {
                Console.WriteLine("--------------------------------------------YOU WIN--------------------------------------------");
                Console.WriteLine("              --------------------------------------------GAME OVER--------------------------------------------");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("--------------------------------------------YOU LOSE--------------------------------------------");
                Console.WriteLine("              --------------------------------------------GAME OVER--------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------IT'S A TIE--------------------------------------------");
                Console.WriteLine("              ---------------------------------------------GAME OVER--------------------------------------------");
            }


           

            Console.ReadLine();
        }


    }
}