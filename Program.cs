using System;
using System.Collections.Generic;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Hello World!");

            /*
      • Ex3
Autoturismului ii putem adauga pasageri sub forma unor siruri de caractere
 “nume prenume”
Adaugati autoturismului un set de
 Adaugare pasager
 Stergere pasager
 O metoda care verifica daca un pasager oferit ca parametru a fost adaugat in autoturism
 Metoda GetDescription va adauga la descriere numele tuturor pasagerilor din autovehicul
• NOTA: in numarul pasagerilor nu este limitat.
             */



            autoturism Ford = new autoturism("Ford", "CJ03 123", 1600);
            autoturism Audi = new autoturism("Audi", "CJ01 456", 1800);

            Console.WriteLine($"Primul autoturism:\t{Ford.GetDescription(Ford.GetMarca(), Ford.GetNumarInmatriculare(), Ford.GetCapacitateCilindrica())} ");
            Console.WriteLine($"Al doilea  autoturism:\t{Audi.GetDescription(Ford.GetMarca(), Audi.GetNumarInmatriculare(), Audi.GetCapacitateCilindrica())}");


            Ford.AdaugaPasager("John Smith");
            Ford.AdaugaPasager("Jane Smith");
            Ford.AdaugaPasager("Mickey Mouse");
            Ford.AdaugaPasager("Minnie Mouse");


            Audi.AdaugaPasager("Donald Duck");
            Audi.AdaugaPasager("Daisy Duck");


            Console.WriteLine("introduceti un nume de pasager:");
            string pasager = Console.ReadLine();


            if (Ford.VerificaPasagerInMasina(pasager, Ford.GetNumarInmatriculare()))
            {
                Console.WriteLine($"{pasager} a fost adaugat in {Ford.GetMarca()}, {Ford.GetNumarInmatriculare()}.");

                Console.WriteLine($"de ce aici imi apar pasagerii si mai sus nu? {Ford.GetDescription(Ford.GetMarca(), Ford.GetNumarInmatriculare(), Ford.GetCapacitateCilindrica())}");

            }
            else if (Audi.VerificaPasagerInMasina(pasager, Audi.GetNumarInmatriculare()))
            {
                Console.WriteLine($"{pasager} a fost adaugat in {Ford.GetMarca()}, {Audi.GetNumarInmatriculare()}.");

                Console.WriteLine($"de ce aici imi apar pasagerii si mai sus nu? {Audi.GetDescription(Ford.GetMarca(), Audi.GetNumarInmatriculare(), Audi.GetCapacitateCilindrica())}");
            }
            else
            {
                Console.WriteLine($"Pasagerul {pasager} nu a fost adaugat in nici o masina.");
             }

        }





        class autoturism
        {

            private string marca;
            private string numarInmatriculare;
            private int capacitateCilindrica;
            private List<string> pasageri = new List<string>();


            /// <summary>
            /// constructor, initializeaza marca, nr inmatriculare, caoacitate cilindriuca
            /// </summary>
            /// <param name="marca"></param>
            /// <param name="numarInmatriculare"></param>
            /// <param name="capacitateCilindrica"></param>
            public autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
            {

                this.marca = marca;
                this.numarInmatriculare = numarInmatriculare;
                this.capacitateCilindrica = capacitateCilindrica;
            }


            /// <summary>
            /// returneaza lista de pasageri
            /// </summary>
            /// <returns></returns>
            public List<string> GetPasageri()
            {
                return pasageri;
            }


            /// <summary>
            /// returneaza marca
            /// </summary>
            /// <returns></returns>
            public string GetMarca()
            {
                return marca;
            }

            /// <summary>
            /// returneaza nr de inmatriculare
            /// </summary>
            /// <returns></returns>
            public string GetNumarInmatriculare()
            {
                return numarInmatriculare;
            }

            /// <summary>
            /// returneaza capacitatea cilindrica
            /// </summary>
            /// <returns></returns>
            public int GetCapacitateCilindrica()
            {
                return capacitateCilindrica;
            }

            /// <summary>
            /// genereaza descrierea unui autoturism: marca, nr inmatriculare, capacitate cilindrica, lista de pasageri
            /// </summary>
            /// <param name="marca"></param>
            /// <param name="numarInmatriculare"></param>
            /// <param name="capacitateCilindrica"></param>
            /// <returns></returns>
            public string GetDescription(string marca, string numarInmatriculare, int capacitateCilindrica)
            {
                string result = "pasageri: ";
                //return GetMarca() + ", " + GetNumarInmatriculare() + ", " + GetCapacitateCilindrica();
                //return $" {GetMarca()}\t{ GetNumarInmatriculare()}\t{GetCapacitateCilindrica()}\t{GetPasageri()}";

                foreach (var pasager in pasageri)
                {
                    result = result  + pasager + ", ";
                }

                result = $" { GetMarca()}\t{ GetNumarInmatriculare()}\t{ GetCapacitateCilindrica()}\t" + result;
                
                return result;

            }

            /// <summary>
            /// adauga un pasager intr-un autoturism
            /// </summary>
            /// <param name="pasager"></param>
            public void AdaugaPasager (string pasager)
            {
                pasageri.Add(pasager);
            }

           

            /// <summary>
            /// Verifica un pasager adaugat intr-un autoturism, pe bvza de nume si nr de inmatriculare
            /// </summary>
            /// <param name="pasager"></param>
            /// <param name="numarInmatriculare"></param>
            /// <returns></returns>
            public bool VerificaPasagerInMasina(string pasager, string numarInmatriculare)
            {

                bool result = false;

                for (int i = 0; i < pasageri.Count; i++)
                {
                    if (pasageri[i] == pasager && this.numarInmatriculare == numarInmatriculare)
                    {
                        result = true;
                    }
                }

                return result;
            }

        }
    }
}
