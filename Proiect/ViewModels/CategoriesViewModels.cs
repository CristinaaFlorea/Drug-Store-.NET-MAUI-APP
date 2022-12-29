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
    public class CategoriesViewModels : ViewModelBase
    {
        ObservableCollection<Categories> _categorieses;

        public CategoriesViewModels()
        {
            LoadData();
        }

        public ObservableCollection<Categories> Categorieses
        {
            get { return _categorieses; }
            set
            {
                _categorieses = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Categorieses = new ObservableCollection<Categories>();

            // Add first fake item
            Categorieses.Add(new Categories());

            foreach (var categories in CategoriesServices.Instance.GetCategories())
                Categorieses.Add(categories);
        }
    }
}
