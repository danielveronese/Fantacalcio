using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Fantacalcio
{
    class Fantallenatore
    {
        //attributi
        private static string mainpath = Environment.CurrentDirectory;
        string fantaallenatore;
     public string setFantallenatore()
        {

            fantaallenatore = Console.ReadLine();
            using(StreamWriter a = File.CreateText($"{mainpath}\\Squasdre\\{fantaallenatore}")) { }
            return fantaallenatore;


        }

        class program
        {
            private static string mainpath = Environment.CurrentDirectory;

            static void Main(string[] args)
            {

                string fant1; fant1 = "";
                string fant2; fant2 = "";
                int m,i,j;
                Fantallenatore fa = new Fantallenatore();
                Fantallenatore fa2 = new Fantallenatore();

                Console.WriteLine("premi 1 per creare una nuova partita");
                Console.WriteLine("premi 2 per iniziare/continuare una nuova partita");
                Console.WriteLine("premi 3 per cancellare una nuova partita");
                m = Convert.ToInt32(Console.ReadLine());
                for(j = 0; j==0; j++)
                {
                    if(m==1)
                    {
                        for (i = 0; i == 0; i++)
                        {

                            Console.WriteLine("inserisci il nome del primo fantaallenatore");
                            fant1 = fa.setFantallenatore();
                            Console.WriteLine("inserosci il nome del secondo fantaallenatore");
                            fant2 = fa2.setFantallenatore();
                            if (fant1 == fant2)
                            {
                                Console.WriteLine("nome del fantaallenatore2 e già stato preso da primo fantallenatore inseriscine un altro ");
                                Console.WriteLine("fantallenatore 2 inserisci il nome ");
                                fant2 = fa2.setFantallenatore();
                                j--;
                            }


                        }



                    }
                    else
                    {
                        if (m == 2)
                        {



                        }

                        else
                        {
                            if (m == 3)
                            {
                                if(!Directory.Exists(mainpath+ "\\Squadre"))
                                {
                                    Console.WriteLine("se vuoi eliminare la partita srivi YES se non vuoi elimiminarla srivi NO");
                                    string delete;
                                    delete = Console.ReadLine();
                                    if (delete == "YES")
                                    {
                                        Directory.Delete(mainpath + "\\Squadre",true);
                                        Console.WriteLine("la partita è stata eliminata ");
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("non hai iniziato nessuna partita ");


                                }




                            }    
                        }
                    }




                }

               


                Console.ReadKey();

            }






        }
    }
}
