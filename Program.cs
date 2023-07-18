using System;
using System.Collections.Generic;
using lab4ex3;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)

        {
            

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



            Car Ford = new Car("Ford", "CJ03 123", 1600);
            Car Audi = new Car("Audi", "CJ01 456", 1800);

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

    }
}
