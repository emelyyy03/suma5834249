using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma5834249
{
    partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        public string? n1;
        [ObservableProperty]
        public string? n2;
        [ObservableProperty]
        public string? suma;

        [RelayCommand]
        private void ActualizarDatos()
        {
            if (double.TryParse(N1, out double num1)&& double.TryParse(N2, out double num2))
            {
                Suma = (num1 + num2).ToString();
            }
            else
            {
                Suma = "Ingrese números válidos";
            }
        }
    }
}
