using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //DEBUT

            //variable
            int reponse = 0;

            //SAISIE
            Console.WriteLine("le film la panthere noir, est un film ou lorsque le roi du wakanda est tuer sont fils,qui est T'Challa, doit prendre sa place comme roi.mais pour ceci,\n il doit se battre contre quiconque qui se presente contre ui dans les 5 nation.un certain chef nommer M'Baku se presente contre lui.");
            Console.WriteLine("1 T'Challa se bat contre M'Baku\n 2 T'Challa ne se bat pas");
            reponse = Convert.ToInt32(Console.ReadLine());


            //branche 1
            if (reponse == 1)
            {
                Console.WriteLine("il devien roi du Wakanda. sur cette terre il y a presence de metal\n précieux et qui permet un developpement de leur tecnhologie.");


                Console.WriteLine("3 il continue leurs developpement technologique\n 4 il ne continue pas leus developpement");
                reponse = Convert.ToInt32(Console.ReadLine());
                if (reponse == 3)// il continue le développement
                {
                    Console.WriteLine("cela permet a sa soeur qui dirige la section technologie,de créé un \n nouvelle armure disimuler dans un collier,pour le roi.");
                    Console.WriteLine("mais un decendant de leur famille surgit pour leur metal et pour prendre la place du roi,\n il doit donc se battre pour defendre son titre.\n mais linconnu(n'jadaca) qui est le fils de son oncle a reussi a vincre T'Challa. il a le choix ");
                    Console.WriteLine("5.tuer le roi\n 6. laisser vivre");
                    reponse = Convert.ToInt32(Console.ReadLine());
                }
                if (reponse == 4)//il ne continue pas leur developpement
                {
                    Console.WriteLine("il continue quand meme a proteger leurs nation contre leurs enemies");
                }




                if (reponse == 5)//il tu le roi
                {
                    Console.WriteLine("N'jadak jette le roi par la falaise et devien roi du wakanda.\n mais la mere de T'challa et la femme quil aime ne sont pas cappable daccepter sa mort.il von donc \n voir M'baku puisque ses le seul a pouvoir les aider.");
                    Console.WriteLine("7 il aide sa mere et la femme qu'il aime\n 8 il l'est laisse a leurs sort");
                    reponse = Convert.ToInt32(Console.ReadLine());
                }
                if (reponse == 6)//il laisse vivre le roi
                {
                    Console.WriteLine("il reussise un terrain danttente ou il seron roi tout les deux");
                }


                if (reponse == 7)//il les aide
                {
                    Console.WriteLine("M'Baku a une surprise pour eux. il avait recuillit le corps de T'Challa dans la riviere.\n mais le plus etonnant ses qu'il n'etait pas mort.\n il decongela pour ensuite etre pret a remettre les arme contre N'jadaka. ");
                    Console.WriteLine("9 il peut se battre pour sauvé son peuple de la destruction que le nouveau roi voulait causer dans le monde \n 10 il se sauve avec les deux personne qu'il aime");
                    reponse = Convert.ToInt32(Console.ReadLine());
                }
                if (reponse == 8)//il les aide pas
                {
                    Console.WriteLine("elles decouvres plus tard que le suposer mort n'etait pas mort.\n M'Baku avait cacher la veriter eux deux femes,comme sa il a pue le tuer de ses propre main.");
                }

                if (reponse == 9)//il combat le nw roi
                {
                    Console.WriteLine("il reussit a vaincre le nouveau roi grace a un demagnetiseur.\n cela a desactiver larmure des deux panthere mais ses T'challa qui reussi a gagner.");
                }

                if (reponse == 10)//il se sauve
                {
                    Console.WriteLine("Le monde est tomber en destructiom total.\n meme si T'challa etait dans une vie bien paisible\n avec les deux personne les plus importentes pour lui.\n Il a quand meme le regret d'avoir laisser son peuple entre les main de se roi.");
                }

            }
            else // il ne veut pas se battre, alors...
            {
                Console.WriteLine("ses M'Baku qui devien roi et T'Challa ne peut plus etre roi");
            }



            //Attendre avant de fermer la fenêtre 
            Console.ReadKey();

        }
    }
}
