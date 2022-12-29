using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Services
{
    public class CategoriesServices
    {
        static CategoriesServices _instance;

        public static CategoriesServices Instance
        {
            get { return _instance ?? (_instance = new CategoriesServices()); }
        }

        public List<Categories> GetCategories()
        {
            return new List<Categories>
            {
                new Categories
                {
                    CategoriesName = "INGRIJIREA FETEI",
                    CategoriesDescription = "Curatarea tenului, Crema de zi, Anti-acnee, Demachiere",

                },
                new Categories
                {
                    CategoriesName = "INGRIJIREA CORPULUI",
                    CategoriesDescription = "Deodorante, Exfolierea corpului, Geluri de dus",

                },
                new Categories
                {
                    CategoriesName = "MACHIAJ PENTRU OCHI",
                    CategoriesDescription = "Mascara, Sprancene, Farduri de pleoape, Primer si baze de machiaj pentru ochi",

                },
                new Categories
                {
                    CategoriesName = "MACHIAJ PENTRU BUZE",
                    CategoriesDescription = "Ruj, Luciu de buze, Creion de buze, Balsam si uleiuri de buze",

                },
                new Categories
                {
                    CategoriesName = "MACHIAJ PENTRU TEN",
                    CategoriesDescription = "Fond de ten, Crema BB si CC, Iluminator, Fard de obraz, Pudra bronzanta",

                },
                new Categories
                {
                    CategoriesName = "PRODUSE PENTRU PAR",
                    CategoriesDescription = "Perii si piepteni, Vopsea de par, Sampon, Balsam, Tratamente",

                },

            };
        }
    }
}
