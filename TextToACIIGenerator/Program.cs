using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToACIIGenerator
{
    class Program
    {
        private static Random _random = new Random();
        public static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            ConsoleColor retColor = (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
            if (retColor == ConsoleColor.Black)
            {
                retColor = ConsoleColor.Cyan;
            }
            return retColor;
        }

        private static Dictionary<char, List<string>> CreateMapping()
        {
            /*
             * 
             * THIS FUNCTION is used to create a Hash map of the characters to their respective ACII characters
            * 
            * Here I will map all the characters to a ACII List<strings> that will later be used to print out the string
            * in big ACII letters, each character will be added to the next and so on.
            */


            List<string> A = new List<string>();
            List<string> B = new List<string>();
            List<string> C = new List<string>();
            List<string> D = new List<string>();
            List<string> E = new List<string>();
            List<string> F = new List<string>();
            List<string> G = new List<string>();
            List<string> H = new List<string>();
            List<string> I = new List<string>();
            List<string> J = new List<string>();
            List<string> K = new List<string>();
            List<string> L = new List<string>();
            List<string> M = new List<string>();
            List<string> N = new List<string>();
            List<string> O = new List<string>();
            List<string> P = new List<string>();
            List<string> Q = new List<string>();
            List<string> R = new List<string>();
            List<string> S = new List<string>();
            List<string> T = new List<string>();
            List<string> U = new List<string>();
            List<string> V = new List<string>();
            List<string> W = new List<string>();
            List<string> X = new List<string>();
            List<string> Y = new List<string>();
            List<string> Z = new List<string>();
            List<string> Space = new List<string>();
            List<string> Comma = new List<string>();
            List<string> Dot = new List<string>();

            Space.Add("   ");
            Space.Add("   ");
            Space.Add("   ");
            Space.Add("   ");
            Space.Add("   ");
            Space.Add("   ");
            Space.Add("   ");
            Space.Add("   ");

            Comma.Add("     ");
            Comma.Add("     ");
            Comma.Add("     ");
            Comma.Add("     ");
            Comma.Add("   _ ");
            Comma.Add("  ( )");
            Comma.Add("  |/ ");
            Comma.Add("  -  ");

            Dot.Add("     ");
            Dot.Add("     ");
            Dot.Add("     ");
            Dot.Add("     ");
            Dot.Add("  _  ");
            Dot.Add(" (_) ");
            Dot.Add("     ");
            Dot.Add("     ");

            A.Add(@"          ");
            A.Add(@"    /\    ");
            A.Add(@"   /  \   ");
            A.Add(@"  / /\ \  ");
            A.Add(@" / ____ \ ");
            A.Add(@"/_/    \_\");
            A.Add(@"           ");
            A.Add(@"           ");

            B.Add(@"  ____  ");
            B.Add(@" |  _ \ ");
            B.Add(@" | |_) |");
            B.Add(@" |  _ < ");
            B.Add(@" | |_) |");
            B.Add(@" |____/ ");
            B.Add(@"        ");
            B.Add(@"        ");

            C.Add(@"   _____ ");
            C.Add(@"  / ____|");
            C.Add(@" | |     ");
            C.Add(@" | |     ");
            C.Add(@" | |____ ");
            C.Add(@"  \_____|");
            C.Add(@"         ");
            C.Add(@"         ");

            D.Add(@"  _____  ");
            D.Add(@" |  __ \ ");
            D.Add(@" | |  | |");
            D.Add(@" | |  | |");
            D.Add(@" | |__| |");
            D.Add(@" |_____/ ");
            D.Add(@"         ");
            D.Add(@"         ");

            E.Add(@"  ______ ");
            E.Add(@" |  ____|");
            E.Add(@" | |__   ");
            E.Add(@" |  __|  ");
            E.Add(@" | |____ ");
            E.Add(@" |______|");
            E.Add(@"         ");
            E.Add(@"         ");

            F.Add(@"  ______ ");
            F.Add(@" |  ____|");
            F.Add(@" | |__   ");
            F.Add(@" |  __|  ");
            F.Add(@" | |     ");
            F.Add(@" |_|     ");
            F.Add(@"         ");
            F.Add(@"         ");

            G.Add(@"   _____ ");
            G.Add(@"  / ____|");
            G.Add(@" | |  __ ");
            G.Add(@" | | |_ |");
            G.Add(@" | |__| |");
            G.Add(@"  \_____|");
            G.Add(@"         ");

            H.Add(@"  _    _ ");
            H.Add(@" | |  | |");
            H.Add(@" | |__| |");
            H.Add(@" |  __  |");
            H.Add(@" | |  | |");
            H.Add(@" |_|  |_|");
            H.Add(@"         ");
            H.Add(@"         ");

            I.Add(@"  _____ ");
            I.Add(@" |_   _|");
            I.Add(@"   | |  ");
            I.Add(@"   | |  ");
            I.Add(@"  _| |_ ");
            I.Add(@" |_____|");
            I.Add(@"        ");
            I.Add(@"        ");

            J.Add(@"       _ ");
            J.Add(@"      | |");
            J.Add(@"      | |");
            J.Add(@"  _   | |");
            J.Add(@" | |__| |");
            J.Add(@"  \____/ ");
            J.Add(@"         ");
            J.Add(@"         ");

            K.Add(@"  _  __");
            K.Add(@" | |/ /");
            K.Add(@" | ' / ");
            K.Add(@" |  <  ");
            K.Add(@" | . \ ");
            K.Add(@" |_|\_\");
            K.Add(@"       ");
            K.Add(@"       ");

            L.Add(@"  _      ");
            L.Add(@" | |     ");
            L.Add(@" | |     ");
            L.Add(@" | |     ");
            L.Add(@" | |____ ");
            L.Add(@" |______|");
            L.Add(@"         ");
            L.Add(@"         ");

            M.Add(@"  __  __ ");
            M.Add(@" |  \/  |");
            M.Add(@" | \  / |");
            M.Add(@" | |\/| |");
            M.Add(@" | |  | |");
            M.Add(@" |_|  |_|");
            M.Add(@"         ");
            M.Add(@"         ");

            N.Add(@"  _   _ ");
            N.Add(@" | \ | |");
            N.Add(@" |  \| |");
            N.Add(@" | . ` |");
            N.Add(@" | |\  |");
            N.Add(@" |_| \_|");
            N.Add(@"        ");
            N.Add(@"        ");

            O.Add(@"   ____  ");
            O.Add(@"  / __ \ ");
            O.Add(@" | |  | |");
            O.Add(@" | |  | |");
            O.Add(@" | |__| |");
            O.Add(@"  \____/ ");
            O.Add(@"         ");
            O.Add(@"         ");

            P.Add(@"  _____  ");
            P.Add(@" |  __ \ ");
            P.Add(@" | |__) |");
            P.Add(@" |  ___/ ");
            P.Add(@" | |     ");
            P.Add(@" |_|     ");
            P.Add(@"         ");
            P.Add(@"         ");

            Q.Add(@"   ____  ");
            Q.Add(@"  / __ \ ");
            Q.Add(@" | |  | |");
            Q.Add(@" | |  | |");
            Q.Add(@" | |__| |");
            Q.Add(@"  \___\_\");
            Q.Add(@"         ");
            Q.Add(@"         ");

            R.Add(@"  _____  ");
            R.Add(@" |  __ \ ");
            R.Add(@" | |__) |");
            R.Add(@" |  _  / ");
            R.Add(@" | | \ \ ");
            R.Add(@" |_|  \_\");
            R.Add(@"         ");
            R.Add(@"         ");

            S.Add(@"   _____ ");
            S.Add(@"  / ____|");
            S.Add(@" | (___  ");
            S.Add(@"  \___ \ ");
            S.Add(@"  ____) |");
            S.Add(@" |_____/ ");
            S.Add(@"         ");
            S.Add(@"         ");

            T.Add(@"  _______ ");
            T.Add(@" |__   __|");
            T.Add(@"    | |   ");
            T.Add(@"    | |   ");
            T.Add(@"    | |   ");
            T.Add(@"    |_|   ");
            T.Add(@"          ");
            T.Add(@"          ");

            U.Add(@"  _    _ ");
            U.Add(@" | |  | |");
            U.Add(@" | |  | |");
            U.Add(@" | |  | |");
            U.Add(@" | |__| |");
            U.Add(@"  \____/ ");
            U.Add(@"         ");
            U.Add(@"         ");

            V.Add(@" __      __");
            V.Add(@" \ \    / /");
            V.Add(@"  \ \  / / ");
            V.Add(@"   \ \/ /  ");
            V.Add(@"    \  /   ");
            V.Add(@"     \/    ");
            V.Add(@"           ");
            V.Add(@"           ");

            W.Add(@" __          __");
            W.Add(@" \ \        / /");
            W.Add(@"  \ \  /\  / / ");
            W.Add(@"   \ \/  \/ /  ");
            W.Add(@"    \  /\  /   ");
            W.Add(@"     \/  \/    ");
            W.Add(@"               ");
            W.Add(@"               ");

            X.Add(@" __   __");
            X.Add(@" \ \ / /");
            X.Add(@"  \ V / ");
            X.Add(@"   > <  ");
            X.Add(@"  / . \ ");
            X.Add(@" /_/ \_\");
            X.Add(@"        ");
            X.Add(@"        ");

            Y.Add(@" __     __");
            Y.Add(@" \ \   / /");
            Y.Add(@"  \ \_/ / ");
            Y.Add(@"   \   /  ");
            Y.Add(@"    | |   ");
            Y.Add(@"    |_|   ");
            Y.Add(@"          ");
            Y.Add(@"          ");

            Z.Add(@"  ______");
            Z.Add(@" |___  /");
            Z.Add(@"    / / ");
            Z.Add(@"   / /  ");
            Z.Add(@"  / /__ ");
            Z.Add(@" /_____|");
            Z.Add(@"        ");
            Z.Add(@"        ");

            Dictionary<char, List<string>> Mapping = new Dictionary<char, List<string>>();

            //Here we add all the letters to the Dictionary mapping with thier respective List of strings
            Mapping.Add('A', A);
            Mapping.Add('B', B);
            Mapping.Add('C', C);
            Mapping.Add('D', D);
            Mapping.Add('E', E);
            Mapping.Add('F', F);
            Mapping.Add('G', G);
            Mapping.Add('H', H);
            Mapping.Add('I', I);
            Mapping.Add('J', J);
            Mapping.Add('K', K);
            Mapping.Add('L', L);
            Mapping.Add('M', M);
            Mapping.Add('N', N);
            Mapping.Add('O', O);
            Mapping.Add('P', P);
            Mapping.Add('Q', Q);
            Mapping.Add('R', R);
            Mapping.Add('S', S);
            Mapping.Add('T', T);
            Mapping.Add('U', U);
            Mapping.Add('V', V);
            Mapping.Add('W', W);
            Mapping.Add('X', X);
            Mapping.Add('Y', Y);
            Mapping.Add('Z', Z);

            Mapping.Add(' ', Space);
            Mapping.Add(',', Comma);
            Mapping.Add('.', Dot);



            return Mapping;


        }
        public static List<List<string>> ToLists(string input)
        {
            Dictionary<char, List<string>> Dict = CreateMapping();

            List<List<string>> DoubleList = new List<List<string>>();
            List<string> RetList = new List<string>();
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");


            foreach (char letter in input)
            {
                if (letter == '/')
                {
                    
                    DoubleList.Add(RetList);
                    RetList = new List<string>();
                    RetList.Add("");
                    RetList.Add("");
                    RetList.Add("");
                    RetList.Add("");
                    RetList.Add("");
                    RetList.Add("");
                    RetList.Add("");
                    RetList.Add("");

                }
                else
                {
                    FindMatch(letter, RetList, Dict);
                }
            }
            DoubleList.Add(RetList);

            return DoubleList;
        }


        public static void PrintLists(List<List<string>> TwoD_List,ConsoleColor color = ConsoleColor.White )
        {
            Console.ForegroundColor = color;
            foreach (List<string> Lst in TwoD_List)
            {
                Print(Lst);
            }
            Console.ResetColor();
        }

        public static void PrintListsWDelay(List<List<string>> TwoD_List, int delay, bool randColor = false)
        {
            if (randColor)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                

                    foreach (List<string> Lst in TwoD_List)
                    {
                        PrintWDelay(Lst,delay,true);
                    }

              
                Console.ResetColor();
            }
            else
            {
                foreach (List<string> Lst in TwoD_List)
                {
                    PrintWDelay(Lst, delay, false);
                }
            }
           
           
        }



        public static List<string>ToList(string input)
        {
            Dictionary<char, List<string>> Dict = CreateMapping();
            input = input.ToUpper();
            List<string> RetList = new List<string>();
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");
            RetList.Add("");

            foreach (char letter in input)
            {
                FindMatch(letter, RetList, Dict);
            }

            return RetList;

         }

        static void Help ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("USAGE : ");
            Console.WriteLine("Available characters a-z , . ");
            Console.WriteLine("New Line = / ");
            Console.WriteLine("If it does not look good either make the console bigger or add newlines");
            Console.ResetColor();
        }
        static void FindMatch(char letter, List<string> Result,Dictionary<char,List<string>> Dict)
        {
            bool keyExists = Dict.ContainsKey(letter);
            if (keyExists)
            {
                List<string> Letter_ACII = Dict[letter];

                for (int i = 0; i < Letter_ACII.Count; i++)
                {
                    Result[i] += Letter_ACII[i];
                }

            }
            else
            {

                return;
            }
            


        }
        static void Print(List<string> Print,ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (string line in Print)
            {
                Console.WriteLine(line);
            }
            Console.ResetColor();

        }
  

        static void PrintWDelay(List<string> Print, int delay,bool randColor=false)
        {
            if (randColor)
            {
                foreach (string line in Print)
                {
                    Console.ForegroundColor = GetRandomConsoleColor();
                    Console.WriteLine(line);
                    System.Threading.Thread.Sleep(delay);
                    Console.ResetColor();
                }
            }
            else
            {
                foreach (string line in Print)
                {
                    Console.WriteLine(line);
                    System.Threading.Thread.Sleep(delay);
                }
            }

            
        }
        static void Main(string[] args)
        {
           

            //Console.WriteLine("Enter a string");

            string input="";

            input =Console.ReadLine();
            input = input.ToUpper();

             //Help();

            //List<string> Lst = ToList(input);
            //Print(Lst, ConsoleColor.Green);
            //Print(Lst);
            //PrintWDelay(Lst, 300, true);
            //Print(Lst, ConsoleColor.Red);
            List<List<string>> LISTS = ToLists(input);
            //PrintLists(LISTS);
            PrintListsWDelay(LISTS, 300, true);



            Console.ReadLine();



        }
    }
}
