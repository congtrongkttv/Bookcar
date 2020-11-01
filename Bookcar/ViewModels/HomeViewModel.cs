using Bookcar.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bookcar.ViewModels
{
    public class HomeViewModel : BaseViewModel<Vehicles>
    {
     
        public Command LoadVehicleCommand { get; }

        private ObservableCollection<Vehicles> lstVehicle;

        public ObservableCollection<Vehicles> LstVehicle
        {
            get => lstVehicle;
            set
            {
                SetProperty(ref lstVehicle, value);
            }
        }

        public Position Position = new Position(20.812201, 106.6231241);
        public HomeViewModel()
        {
            Title = "Home";
            LstVehicle = new ObservableCollection<Vehicles>();
            LoadVehicleCommand = new Command(FunctionChangePositionCommand);
        }

        public async void FunctionLoadVehicleCommand()
        {
            IsBusy = true;
            try
            {
                LstVehicle.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    LstVehicle.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void FunctionChangePositionCommand()
        {
            IsBusy = true;
            try
            {
                foreach (var item in LstVehicle)
                {
                    item.Position = new Position(item.Position.Latitude + 0.1, item.Position.Longitude + 0.1);
                    item.Address = item.Address + "1";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}