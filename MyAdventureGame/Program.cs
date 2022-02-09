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

            public static string getStringRand = randCharGen();

            public static int getCharRCounter = charRCounter();

            public static int getCharGCounter = charGCounter();

            public static int getCharBCounter = charBCounter();

            public static int getRandWiggle = randWiggleGen();
        }

        public static int randNumGen()
        {
            Random rnd = new Random();

            int rand = rnd.Next(4999);

            return rand;
            
        }

        public static int randWiggleGen()
        {
            Random random = new Random();
            int rand = random.Next(3);
            return rand;
        }
        public static string randCharGen()
        {
            Random rand = new Random();
            String RGB = "RGB";
            int charlength = 10;

            String random = " ";

            for (int i = 0; i < charlength; i++)
            {
                int a = rand.Next(3);
                random = random + RGB.ElementAt(a);
            }

            return random;

        }

        public static int charRCounter()
        {
            string randString = Global.getStringRand;
            char r = 'R';

            int count = 0;
            foreach(char c in randString)
            {
                if (c == r)
                {
                    count++;
                }
            }

            return count;
        }

        public static int charGCounter()
        {
            string randString = Global.getStringRand;
            char g = 'G';

            int count = 0;
            foreach(char c in randString)
            {
                if(c == g)
                {
                    count++;
                }
            }
            return count;
        }

        public static int charBCounter()
        {
            string randString = Global.getStringRand;
            char b = 'B';

            int counter = 0;
            foreach(char c in randString)
            {
                if(c == b)
                {
                    counter++;
                }
            }

            return counter;
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
            System.Threading.Thread.Sleep(500);
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
            System.Threading.Thread.Sleep(500);
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
                            System.Threading.Thread.Sleep(500);
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
            System.Threading.Thread.Sleep(500);
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
            System.Threading.Thread.Sleep(500);
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
                            System.Threading.Thread.Sleep(300);
                            if (Global.knife == 0)
                            {
                                Global.knife = 1;
                            }
                            else
                            {
                                slowLine("You have already checked this drawer");
                                System.Threading.Thread.Sleep(500);
                            }
                            drawerFlag = false;
                            desk();
                            break;
                        }

                    case "2":
                    case "middle drawer":
                        {
                            slowLine("There nothing here");
                            System.Threading.Thread.Sleep(500);
                            drawerFlag = false;
                            desk();
                            break;
                        }

                    case "3":
                    case "bottom drawer":
                        {
                            slowLine("You find a peice of paper and it reads " + Global.getRand);
                            System.Threading.Thread.Sleep(3000);
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
                            System.Threading.Thread.Sleep(500);
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
            string password;
            int parsedPass;
            Console.Write("Username: Find Your Friends\n");
            Console.Write("Password: ");
            password = Console.ReadLine();
            while (!int.TryParse(password, out parsedPass))
            {
                Console.Write("Please write and integer");
                password = Console.ReadLine();
            }
            
            if (parsedPass == Global.getRand)
            {
                slowLine("The computer boots up and you plug in the Flash Drive\n");
                System.Threading.Thread.Sleep(500);
                loadingScreen();
            }
            else if (parsedPass == 071504)
            {
                slowLine("Hey you found my easter egg. I hope you're enjoying the game :)\n");
                System.Threading.Thread.Sleep(500);
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

            Console.Write("\n\nLoading...");
            progressBar("================================\n");
            Console.Write("Finished Loading");
            System.Threading.Thread.Sleep(500);

            Console.Clear();

            slowLine("\n\nOnce the flash drive is inserted a door behind you opens and you see one of your friends\n");
            System.Threading.Thread.Sleep(300);
            slowLine("He is gagged and tied up. You quickly go untie him. You have found 1 of 3 of your friends\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You notice behind your friend there are random letters\n");
            System.Threading.Thread.Sleep(300);
            slowLine("The letters read " + Global.getStringRand);
            System.Threading.Thread.Sleep(3000);
            buildUpToFriendTwo();
        }


        public static void buildUpToFriendTwo()
        {
            slowLine("\nAfter you untie your friend. You and your friend start to search for more\nclues about your other friends in the cabin\n");
            System.Threading.Thread.Sleep(300);
            slowLine("For some time you guys werent getting any information on where to find your other friend\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You stumble across a door with a code pad that has R, G, B\n");
            System.Threading.Thread.Sleep(300);
            slowLine("The code pad has a setup as such: \n\tR\n\tG\n\tB\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You begin with the charcter R");
            System.Threading.Thread.Sleep(1000);
            doorCodeR();
        }



        public static void doorCodeR()
        {
            Console.Clear();
            Console.Write("REMEMBER, THE CODE WRITTEN ON THE WALL IS: " + Global.getStringRand);
            Console.Write("\nWrite Something for R: ");
            string answer;
            int parsedAns = 0;
            answer = Console.ReadLine();

            while (!int.TryParse(answer, out parsedAns))
            {
                Console.Write("\nHINT! THE INPUT SHOULD BE A NUMBER: ");
                answer = Console.ReadLine();    
            }

            if(parsedAns == Global.getCharRCounter)
            {
                Console.Write("CORRECT");
                System.Threading.Thread.Sleep(1000);
                doorCodeG();
            }
            else
            {
                Console.Write("INCORRECT");
                System.Threading.Thread.Sleep (1000);
                doorCodeR();
            }

        }

        public static void doorCodeG()
        {
            Console.Clear();
            Console.Write("REMEMBER, THE CODE WRITTEN ON THE WALL IS: " + Global.getStringRand);
            Console.Write("\nWrite Something for G: ");
            string answer;
            int parsedAns = 0;
            answer = Console.ReadLine();

            while (!int.TryParse(answer, out parsedAns))
            {
                Console.Write("\nHINT YOU INPUT SHOULD BE A NUMBER: ");
                answer = Console.ReadLine();
            }

            if (parsedAns == Global.getCharGCounter)
            {
                Console.Write("CORRECT");
                System.Threading.Thread.Sleep(500);
                doorCodeB();
            }
            else
            {
                Console.Write("INCORRECT");
                System.Threading.Thread.Sleep(500);
                doorCodeG();
            }
        }

        public static void doorCodeB()
        {
            Console.Clear();
            Console.Write("REMEMBER, THE CODE WRITTEN ON THE WALL IS: " + Global.getStringRand);
            Console.Write("\n\nWrite Something for B: ");
            string answer;
            int parsedAns = 0;
            answer = Console.ReadLine();

            while (!int.TryParse(answer, out parsedAns))
            {
                Console.Write("\nHINT! YOU INPUT SHOULD BE A NUMBER: ");
                answer = Console.ReadLine();
            }

            if (parsedAns == Global.getCharBCounter)
            {
                Console.Write("CORRECT");
                System.Threading.Thread.Sleep(500);
                secondFriend();
            }
            else
            {
                Console.Write("INCORRECT");
                System.Threading.Thread.Sleep(500);
                doorCodeB();
            }
        }

        public static void secondFriend()
        {
            Console.Clear();
            slowLine("The door opens and you find your second friend tied up like your first friend.\n ");
            System.Threading.Thread.Sleep(300);
            slowLine("You quickly untie him but then you get hit on the side of the head by a bat.\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You regain consciousness. You are getting carried on a strangers shoulder\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You have to think quickly. What do you do");
            System.Threading.Thread.Sleep(1000);
            thinkQuickAction();
        }

        public static void thinkQuickAction()
        {
            Console.Clear();
            Console.Write("1. Stab the attacker with the knife you picked up\n");
            Console.Write("2. Try to wiggle out\n");
            Console.Write("3. Give up");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    {
                        if (Global.knife == 1)
                        {
                            Console.Write("You stab the atacker in the back and run");
                            System.Threading.Thread.Sleep(1000);
                            escape();
                        }
                        else
                        {
                            Console.Write("You dont have a knife");
                            thinkQuickAction(); 
                        }
                        break;
                    }

                case "2":
                    {
                        if (Global.getRandWiggle == 2)
                        {
                            Console.Write("You attempt to wiggle out and are successful. The attacker lets go and you start to run\n");
                            System.Threading.Thread.Sleep(1000);
                            escape();
                        }
                        else
                        {
                            slowLine("You attempt to wiggle out, but are unsuccessful\n");
                            System.Threading.Thread.Sleep(300);
                            slowLine("You give in. The attacker isn't working alone. You see two other figures.\n");
                            System.Threading.Thread.Sleep(300);
                            slowLine("You cant believe what you are seeing, those two figues are you freinds that you saved.\n");
                            System.Threading.Thread.Sleep(300);
                            slowLine("All three of your friends have been working together all this time.\n");
                            System.Threading.Thread.Sleep(300);
                            slowLine("The three of your friends are all working together to kill you.\n");
                            System.Threading.Thread.Sleep(300);
                            slowLine("One of the figues pulls out a knife and stabs you in the stomach\n");
                            System.Threading.Thread.Sleep(300);
                            slowLine("You slowly start to black out as you see three figues standing over you\n");
                            System.Threading.Thread.Sleep(1000);
                            deathScreen();
                        }

                        break;
                    }
                case "3":
                    {
                        slowLine("You give in. The attacker isn't working alone. You see two other figures.\n");
                        System.Threading.Thread.Sleep(300);
                        slowLine("You cant believe what you are seeing, those two figues are you freinds that you saved.\n");
                        System.Threading.Thread.Sleep(300);
                        slowLine("All three of your friends have been working together all this time.\n");
                        System.Threading.Thread.Sleep(300);
                        slowLine("The three of your friends are all working together to kill you.\n");
                        System.Threading.Thread.Sleep(300);
                        slowLine("One of the figues pulls out a knife and stabs you in the stomach\n");
                        System.Threading.Thread.Sleep(300);
                        slowLine("You slowly start to black out as you see three figues standing over you");                        
                        System.Threading.Thread.Sleep(1000);
                        deathScreen();
                        break;
                    }
            }
        }

        public static void escape()
        {
            Console.Clear();
            slowLine("You run away\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You look back and see three figues chasing after you\n");
            System.Threading.Thread.Sleep(300);
            slowLine("Realization kicks in. The three figues are the same people who you have been trying to save\n");
            System.Threading.Thread.Sleep(300);
            slowLine("You manage to escape the forest unscaved. You find the nearest police station\n");
            System.Threading.Thread.Sleep(1000);
            celebrationScreen();
        }

        public static void celebrationScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            slowLine("You survived");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }
            

        public static void deathScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            slowLine("You have DIED");
            System.Threading.Thread.Sleep(1000);
                
            Environment.Exit(0);
            
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

