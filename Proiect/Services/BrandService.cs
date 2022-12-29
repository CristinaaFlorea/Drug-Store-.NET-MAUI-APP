using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Services
{
    public class BrandService
    {
        static BrandService _instance;

        public static BrandService Instance
        {
            get { return _instance ?? (_instance = new BrandService()); }
        }

        public List<Brand> GetBrand()
        {
            return new List<Brand>
            {
                new Brand
                {
                    Name = "GARNIER SKIN NATURALS",
                },
                new Brand
                {
                    Name = "CERAVE",
                },
                new Brand
                {
                    Name = "GREEN",
                },
                new Brand
                {
                    Name = "BALEA",
                },
                new Brand
                {
                    Name = "ORGANIC SHOP",
                },
                new Brand
                {
                    Name = "ZIOJA",
                },
                new Brand
                {
                    Name = "MAYBELLINE NEW YORK",
                },
                new Brand
                {
                    Name = "CATRICE",
                },
                new Brand
                {
                    Name = "L'OREAL PARIS",
                },
                new Brand
                {
                    Name = "SYOSS",
                },
                new Brand
                {
                    Name = "WET BRUSH",
                },
            };
        }
    }
}
