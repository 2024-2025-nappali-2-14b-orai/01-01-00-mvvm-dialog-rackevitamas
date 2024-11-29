using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KreataProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KreataProject.ViewModels
{
    public partial class ProductViewModel : ObservableObject
    {
        [ObservableProperty]
        private Product _product = new Product();

        [ObservableProperty]
        private List<string> _etelcsalad = new List<string> { "új", "épp", "öreg" };

        [ObservableProperty]
        private ObservableCollection<Product> _products = new ObservableCollection<Product>();

        [ObservableProperty]
        private Product _selectedProduct = new Product();

        public ProductViewModel()
        {
            Product.DatumLejarat = DateTime.Now;
        }

        [RelayCommand]
        public void DoSave(Product product)
        {
            if (Products.Any(p => p.Name == product.Name && p.Csalad == product.Csalad && p.DatumLejarat == product.DatumLejarat))
            {
                MessageBox.Show("Hiba: A termék már szerepel a listában.", "Termék Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return; 
            }

            Products.Add(product);

            Product = new Product();
            Product.DatumLejarat = DateTime.Now;
            OnPropertyChanged(nameof(Product));
        }

        [RelayCommand]
        public void DoNewProduct()
        {
            Product = new Product();
            Product.DatumLejarat = DateTime.Now;
            OnPropertyChanged(nameof(Product));
        }

        [RelayCommand]
        public void DoDelete(Product product)
        {
            Products.Remove(product);
            Product = new Product();
            Product.DatumLejarat = DateTime.Now;
            OnPropertyChanged(nameof(Product));
        }
        }
    }
