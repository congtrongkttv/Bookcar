using Bookcar.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bookcar.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public List<Vehicles> LstVehicle = new List<Vehicles>();
        public HomeViewModel()
        {
            Title = "Home";
            LstVehicle.Add(new Vehicles() { Position = new Position(15.192381237, 106.1231241), VehiclePlate = "30A1234" });
            LstVehicle.Add(new Vehicles() { Position = new Position(15.192381237, 106.1231241), VehiclePlate = "30A1235" });
            LstVehicle.Add(new Vehicles() { Position = new Position(15.192381237, 106.1231241), VehiclePlate = "30A1236" });
        }

        

        public ICommand OpenWebCommand { get; }
    }
}