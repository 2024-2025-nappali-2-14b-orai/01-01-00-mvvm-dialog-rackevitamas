using CommunityToolkit.Mvvm.ComponentModel;
using KreataProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreataProject.ViewModels
{
    public partial class ProductViewModel : ObservableObject
    {
        [ObservableProperty]

        private Product _product = new Product();

        [ObservableProperty]
        private List<string> _etelcsalad = new List<string> { "új", "épp", "öreg" };


    }
}
