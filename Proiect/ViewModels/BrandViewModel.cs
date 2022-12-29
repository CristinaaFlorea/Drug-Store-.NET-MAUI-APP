using Proiect.Models;
using Proiect.Services;
using Proiect.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.ViewModels
{
    public class BrandViewModels : ViewModelBase
    {
        ObservableCollection<Brand> _brands;

        public BrandViewModels()
        {
            LoadData();
        }

        public ObservableCollection<Brand> Brands
        {
            get { return _brands; }
            set
            {
                _brands = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Brands = new ObservableCollection<Brand>();

            // Add first fake item
            Brands.Add(new Brand());

            foreach (var brand in BrandService.Instance.GetBrand())
                Brands.Add(brand);
        }
    }
}
