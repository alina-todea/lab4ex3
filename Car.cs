using System;
using System.Collections.Generic;

namespace lab4ex3

{


    class Car
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
        public Car(string marca, string numarInmatriculare, int capacitateCilindrica)
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
                result = result + pasager + ", ";
            }

            result = $" { GetMarca()}\t{ GetNumarInmatriculare()}\t{ GetCapacitateCilindrica()}\t" + result;

            return result;

        }

        /// <summary>
        /// adauga un pasager intr-un autoturism
        /// </summary>
        /// <param name="pasager"></param>
        public void AdaugaPasager(string pasager)
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
