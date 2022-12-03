using System;
using System.Linq;

namespace JDR
{
    class MonPersonnage : Hero
    {

        public MonPersonnage(string nom, int pointDeVie, int pointAttaque, int pointDefence, string classe) : base(nom, pointDeVie, pointAttaque, pointDefence, classe)
        {

        }
        public override void Afficher()
        {
            base.Afficher();
        }

    }
    class Hero : Personnage
    {
        // hero -> liste de 3 classes chevalier, socier ,mort vivant ( Nom,pv,ini,point d'attaque,point de déffance)
        public string classe;

        public Hero(string nom, int pointDeVie, int pointAttaque, int pointDefence, string classe) : base(nom, pointDeVie, pointAttaque, pointDefence)
        {
            this.classe = classe;
        }
        public override void Afficher()
        {
            Console.WriteLine("classe :" + classe);
            base.Afficher();

        }

    }

    class Monstre : Personnage
    {
        // monstre -> liste de 18 monstres ( Nom,pv,ini,point d'attaque,point de déffance)

        public Monstre (string nom, int pointDeVie, int pointAttaque, int pointDefence) : base(nom, pointDeVie, pointAttaque, pointDefence)
        {

        }

    }


    class Personnage
    {

        public string nom;
        public int pointDeVie;
        public int pointAttaque;
        int pointDefence;

        public Personnage (string nom, int pointDeVie, int pointAttaque, int pointDefence)
        {
            this.nom = nom;
            this.pointDeVie = pointDeVie;
            this.pointAttaque = pointAttaque;
            this.pointDefence = pointDefence;
        }


        public virtual void  Afficher()
        {
            Console.WriteLine("Nom : "+nom );
            Console.WriteLine("Point de vie : " + pointDeVie);
            Console.WriteLine("Point d'attaque : " + pointAttaque);
            Console.WriteLine("Point de defence : " + pointDefence);
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var classeDePersonnage = new List<Hero>
            {
                new Hero("Artas",60,7,8,"Chevalier"),
                new Hero("Dumbledor", 45, 10, 3,"Sorcier"),
                new Hero("Liche", 100, 5, 1,"MortViant")
            };


            var Guldan = new Monstre("Guldan", 70, 6, 0);

            //classeDePersonnage = classeDePersonnage.Where(p => p.classe == "Chevalier").ToList();

            foreach (var hero in classeDePersonnage)
            {
                hero.Afficher();
            }
            
            Console.WriteLine("choisi ton personnage\n " +
                "Appuye 1 pour le chevalier\n" +
                "Appuye 2 pour le sorcier\n" +
                "Appuye 3 pour le mort vivant ");

            var monPersonnage = new List<MonPersonnage>();

            while (true)
            {
                try
                {
                    int choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        monPersonnage = new List<MonPersonnage>
                        {
                             new MonPersonnage("Artas", 60, 7, 8, "Chevalier")
                        };
                        break;
                    }
                    if (choix == 2)
                    {
                        monPersonnage = new List<MonPersonnage>
                        {
                            new MonPersonnage("Dumbledor", 45, 10, 3,"Sorcier")
                        };
                        break;
                    }
                    if (choix == 3)
                    {
                        monPersonnage = new List<MonPersonnage>
                        {
                            new MonPersonnage("Liche", 100, 5, 1,"MortViant")
                        };
                        break;
                    }
                    else
                    {
                        Console.WriteLine("tu n'as pas mis un bon chiffre");
                    }
                }
                catch
                {
                    Console.WriteLine("on a dit un chiffre");
                }


            }

            
            foreach(var perso in monPersonnage)
            {
                Console.Clear();
                Console.WriteLine("le hero que tu as choisi est : ");
                Console.WriteLine();
                perso.Afficher();
            }

        }
    }
}