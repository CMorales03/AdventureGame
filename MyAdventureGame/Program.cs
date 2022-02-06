using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdventureGame
{

    internal class Program
    {
        public static class Global
        {
            public static int knife = 0;

            public static int getRand = randNumGen();
        }

        public static int getRandNum(int rand)
        {
            return rand;
        }

        public static int randNumGen()
        {
            Random rnd = new Random();

            int rand = rnd.Next(4999);

            return rand;
            
        }

       


        static void Main(string[] args)
        {
            title();
        }

        public static void title()
        {
            slowLine("Welcome to the game\n\n");
            slowLine("To play press ");
            string txt = "ENTER: ";
            while (true)
            {
                WriteBlinkingText(txt, 500, true);
                WriteBlinkingText(txt, 500, false);
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            Console.Clear();
            start();

        }

        public static void start()
        {
            slowLine("You decide to go on a camping trip out in the forest with 3 of your friends.\n");
            System.Threading.Thread.Sleep(300);
            slowLine("Upon arrival you get a feeling that someone is watching you, but you decide to ignore it.\n");
            System.Threading.Thread.Sleep(300);
            slowLine("Nightfall arrives. Everone decides to go to their tents to go to sleep\n\n");
            System.Threading.Thread.Sleep(1000);
            Console.Write("*SILENCE*\n\n");
            System.Threading.Thread.Sleep(3000);
            slowLine("You hear a loud scream coming from outside your tent\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You run outside of the tent, All of your friends are gone\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You see a note on the ground.It reads\n\n\tIf you want to leave this forest alive\n");
            System.Threading.Thread.Sleep(300);
            slowLine("\tYou must find all of your friends\n\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You set out on your journey.\n");
            System.Threading.Thread.Sleep(300);
            slowLine("Along your trip you encounter bloodstaines on the ground\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You follow the trail. Up ahead there's a fork on the road.\n");
            System.Threading.Thread.Sleep(300);
            forkChoice();

        }

        public static void forkChoice()
        {
            bool flag = true;
            string choice;

            Console.Write("Do you go left or right?: ");
            choice = Console.ReadLine().ToLower();

            while (flag)
            {
                switch (choice)
                {
                    case "1":
                    case "right":
                        {
                            right();
                            break;
                        }

                    case "2":
                    case "left":
                        {
                            left();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("This is not a valid choice");
                            flag = false;
                            forkChoice();
                            break;
                        }
                }
            }
        }

        public static void right()
        {
            Console.Clear();
            slowLine("You go right, After following the trail for some time you get sent straight to a water fall\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You cannot continue so you go back to the fork and go left\n");
            left();

        }

        public static void left()
        {
            Console.Clear();

            System.Threading.Thread.Sleep(300);
            slowLine("You go left, and continue your journey. After some time on the trail you find an abondoned cabin\n");
            System.Threading.Thread.Sleep(300);

            System.Console.Write("  \n" +
"                                     =##                          \n" +
"                                      # *:                        \n" +
"                                     #   #                        \n" +
"                                    #:    #                       \n" +
"                                   -*-#                           \n" +
"                                   #       #:                     \n" +
"                  :               #         #                     \n" +
"                  ##             #:          #                    \n" +
"                 # *-           -#           =*                   \n" +
"                #-  #           #=============#.                  \n" +
"               :#    #         ::::#:::::::#-:::                  \n" +
"               #     -#           #         #                     \n" +
"              #       #:         +=         .#                    \n" +
"             *=        #        .#           *+                   \n" +
"            :#          #       #             #.                  \n" +
"            #############*     #.              #                  \n" +
"              *-      #       ++       ######  .#                 \n" +
"             :#        #     .#        #    +   *=                \n" +
"             #         -#    #         #    +    #                \n" +
"            #           #:  #.         #    +     #               \n" +
"           *=            # =*-##########    +####+:#              \n" +
"          :#              ##*#         #    +    *#*=             \n" +
"          #               ##+     #.   #    +     =##             \n" +
"         #                #-       #:  ######      .#             \n" +
"        ++               #.         #+               #            \n" +
"       .#***************#      *     *#               #:          \n" +
"          -#          :#     .#+#     =#               #=         \n" +
"          #          +#     =#  :#     .#               #*        \n" +
"         #          #*     *#    .#      #               =#       \n" +
"        *-         #=     ##########.                     :#      \n" +
"       :#         -=     #-         #:      ###########    :*     \n" +
"       #          #     #.           #+                     #     \n" +
"      #           ==  .#### ######.   *#                   -=     \n" +
"     *-            ####:    #  # +.    ##******************#      \n" +
"    :#              # #     #  # +.    #..#             #: #      \n" +
"    #               ######% ######.    -##=#############:##+      \n" +
"   #               -= +:    #  # +.    #  #             #  #      \n" +
"  *################## #     #++#+*.    #::#             #-.#      \n" +
"                *   #######         -#####= ###############+      \n" +
"               =:  --+:               #  #             #  #       \n" +
"               #    # #                #-:#             #-.#      \n" +
"              .#    #+#++++++++++++++++###+ +++++++++++ =##*      \n" +
"              #    -- =:       #.      #  #             #  #      \n" +
"    .:::::::+#-::::-#:#::::::::::::::::#==#:::::::::::::#+-#      \n" +
"    .------------ -###*++++++++++++++++++++++++++++++++++++*##-   \n" +
"                 #=                                          +#   \n" +
"                #                                              #  \n" +
"               #                                               -* \n" +
"              #.                                                # \n" +
"              -                                                 . \n");



            System.Threading.Thread.Sleep(300);
            slowLine("You decide to go inside but dont see anything except a flash drive and a computer on top a desk.\n");
            System.Threading.Thread.Sleep(300);
            slowLine("The flash drive has somehting written on the side of it and it says \"plug me in\".\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You go to turn on the computer and it askes for a password.\n");
            System.Threading.Thread.Sleep(300);
            slowLine("There are drawers on the desk you decide to start opening drawer desks\n");
            desk();

        }

        public static void desk()
        {
            Console.Clear();
            string drawerChoice;
            bool drawerFlag = true;

            Console.Clear();
            Console.Write("1. Top Drawer\n");
            Console.Write("2. Middle Drawer\n");
            Console.Write("3. Bottom Drawer\n");
            Console.Write("4. Go To Computer\n");
            drawerChoice = Console.ReadLine().ToLower();

            while (drawerFlag)
            {
                switch (drawerChoice)
                {
                    case "1":
                    case "top drawer":
                        {
                            slowLine("You find a Knife on the top drawer and decide to pick it up\n");
                            if (Global.knife == 0)
                            {
                                Global.knife = 1;
                            }
                            else
                            {
                                slowLine("You have already checked this drawer");
                            }
                            drawerFlag = false;
                            desk();
                            break;
                        }

                    case "2":
                    case "middle drawer":
                        {
                            slowLine("There nothing here");
                            System.Threading.Thread.Sleep(300);
                            drawerFlag = false;
                            desk();
                            break;
                        }

                    case "3":
                    case "bottom drawer":
                        {
                            slowLine("You find a peice of paper and it reads " + Global.getRand);
                            System.Threading.Thread.Sleep(1000);
                            drawerFlag = false;
                            desk();
                            break;
                        }

                    case "4":
                    case "go to computer":
                        {
                            lockedComputer();
                            break;
                        }

                    default:
                        {
                            Console.Write("This is not a valid choice");
                            drawerFlag = false;
                            desk();
                            break;
                        }
                }
            }


        }

        public static void lockedComputer()
        {
            Console.Clear();
            int password = 0;
            Console.Write("Username: Find Your Friends\n");
            Console.Write("Password: ");
            password = Console.Read();
            if (password == Global.getRand)
            {
                slowLine("The computer boots up and you plug in the Flash Drive\n");
                System.Threading.Thread.Sleep(300);
                loadingScreen();
            }
            else if (password == 071504)
            {
                slowLine("Hey you found my easter egg. I hope you're enjoying the game :)\n");
                System.Threading.Thread.Sleep(300);
                lockedComputer();
            }
            else
            {
                Console.Write("This is not the correct password\n");
                System.Threading.Thread.Sleep(500);
                lockedComputer();
            }
        }

        public static void loadingScreen()
        {
            Console.Clear();

            Console.Write("Loading...");
            progressBar("================================\n");
            Console.Write("Finished Loading");

            Console.Clear();

            slowLine("Once the flash drive is inserted a door behind you opens and you see one of your friends\n");
            System.Threading.Thread.Sleep(300);
            slowLine("He is gagged and tied up. You quickly go untie him. You have found 1 of 3 of your friends\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You notice behind your friend there are random letters");
            System.Threading.Thread.Sleep(300);
        }

        static void slowLine(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(70);
            }

        }

        static void progressBar(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(200);
            }

        }
        private static void WriteBlinkingText(string text, int delay, bool visible)
        {
            if (visible)
                Console.Write(text);
            else
                for (int i = 0; i < text.Length; i++)
                    Console.Write(" ");
            Console.CursorLeft -= text.Length;
            System.Threading.Thread.Sleep(delay);
        }

    }
}

