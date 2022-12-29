using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Services
{
    public class ProduseService
    {
        static ProduseService _instance;

        public static ProduseService Instance
        {
            get { return _instance ?? (_instance = new ProduseService()); }
        }

        public List<Produse> GetProducts()
        {
            return new List<Produse> {
              new Produse {
                  Name = "Hyaluronic Aloe crema de fata",
                  Image = "img2.jpg",
                  Description = "Contine aloe vera si acid-hialuronic, hraneste si calmeaza tenul",
                  Price = 29.95,
              },
              new Produse {
                  Name = "Gel de spalare hidratant",
                  Image = "img3.jpg",
                  Description = "Contine ceramide si acid-hialuronic, pentru piele normala-uscata",
                  Price = 35.71,
              },
              new Produse {
                  Name = "Ulei de curatare From Green",
                  Image = "img4.jpg",
                  Description = "Ofera o curatare delicata si eficienta pentru toate tipurile de ten",
                  Price = 102.00,
              },
              new Produse {
                  Name = "Apa Micelara 3 in 1",
                  Image = "img5.jpg",
                  Description = "Este un produs de curatare a tenului eficient, rapid si usor de folosit",
                  Price = 20.99,
              },
              new Produse {
                  Name = "Deodorant parfumat Pink Blossom",
                  Image = "img6.jpg",
                  Description = "Nu contine aluminiu si va protejeaza impotriva transpiratiei neplacute",
                  Price = 7.75,
              },
              new Produse {
                  Name = "Scrub cu zmeura pentru corp",
                  Image = "img7.jpg",
                  Description = "Exfoliaza pielea si ii ofera o textura catifelata si ferma",
                  Price = 16.99,
              },
              new Produse {
                  Name = "Gel de dus cristalin",
                  Image = "img8.jpg",
                  Description = "Are proprietati nutritive si regenerative remarcanile",
                  Price = 21.99,
              },
              new Produse {
                  Name = "Lash Sensational Sky High mascara",
                  Image = "img9.jpg",
                  Description = "Are o formula cu extract de bambus si microfibre speciale ce permite fixarea rezultatului pentru intreaga zi",
                  Price = 38.95,
              },
              new Produse {
                  Name = "5 In A Box paleta de farduri 010",
                  Image = "img10.jpg",
                  Description = "Nu contine particule microplastice si este usor de aplicat si de uniformizat",
                  Price = 19.50,
              },
              new Produse {
                  Name = "Matt Pro Ink ruj lichid 010 Trust In Me",
                  Image = "img11.jpg",
                  Description = "Foarte rezistent cu unt moringa si o textura lichida",
                  Price = 24.50,
              },
              new Produse {
                  Name = "True Match fond de ten",
                  Image = "img12.jpg",
                  Description = "Formula cu acid hialuronic si aloe vera ingrijeste si protejeaza piele si imbunatateste tenul",
                  Price = 66.95,
              },
              new Produse {
                  Name = "Vopsea de par permanenta 1-1 Negru",
                  Image = "img13.jpg",
                  Description = "Sistem de protectie impotriva deteriorarii, pentru culori vibrante de lunga durata",
                  Price = 18.60,
              },
              new Produse {
                  Name = "Perie de par paddle infuzata cu carbune",
                  Image = "img14.jpg",
                  Description = "Descurca parul fara a-l trage sau rupe si este ideala atat pentru parul umed, cat si uscat",
                  Price = 58.00,
              },
           };
        }
    }
}

