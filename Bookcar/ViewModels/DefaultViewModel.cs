using Bookcar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bookcar.ViewModels
{
    public class DefaultViewModel : BaseViewModel<Vehicles>
    {
        public Command LoadVehicleCommand { get; }
       
        public DefaultViewModel()
        {
            Title = "Home";
        }
    }
}