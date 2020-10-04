using System;

namespace pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Pendu pendus = new Pendu();
            pendus.Start();
         
        }
    }
    class Pendu
    {
        string lettre;
        string[] t1 = new string[3] { "L", "O", "N" };
        string[] t2 = new string[3] { "?", "?", "?" };

        int plus = 5;

        private void saisiemot()
        {
            Console.WriteLine(t2[0] + " " + t2[1] + " " + t2[2]);


        }
        
 

        private bool Verification(string c)
        {

          
            foreach (string a in t1)
            {
              
                
                  if (c == a)
                    {
                    return true;
                    }

                }
            
            return false;


        }

        private void modificatoon(string n)
        {
            for (int b = 0; b < t1.Length; b++)
            {
                if (n == t1[b])
                {
                   
                    t2[b] = n;
                }
            }
           
        }
        private bool Partiegagner()
        {

           if(t1[0] == t2[0] && t1[1] == t2[1] && t1[2] == t2[2])
            {
                return true;
            }
            return false;
        }
        public void Start()
        {
           
            while (true)
            {
             
         
                Console.WriteLine("Saisir mot : ");
                saisiemot();
                lettre = Console.ReadLine();
                
               
                Console.WriteLine("Il vous reste : "+ --plus + "tentative");
                if( plus == 0)
                {
                    Console.WriteLine("Perdu");
                    break;
                }
                if (!Verification(lettre))
                {
                  
                    continue;
                }

                modificatoon(lettre);
                 if (Partiegagner())
                {
                    Console.WriteLine("Vous avez trouver le mot");
                    saisiemot();
                    break;
                }
               
             
            }
               
        
        
        }

       
    }

}
