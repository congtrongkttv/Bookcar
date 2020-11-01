using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Bookcar.ViewModels;
using Bookcar.Models;
using Bookcar.CustomControl;
using Plugin.Geolocator;
using Xamarin.Essentials;
using System.Linq;
using DurianCode.PlacesSearchBar;
using System.Threading.Tasks;

namespace Bookcar.Views
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel _homViewModel;
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = _homViewModel = new HomeViewModel();
            LoadPin();
            //LoadCurrentPosition();
            LoadAutoComplete();
        }

        public async void LoadCurrentPosition()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;
            var location = await locator.GetPositionAsync(TimeSpan.FromTicks(10000));
            Position position = new Position(location.Latitude, location.Longitude);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(100)));
        }

        public void LoadAutoComplete()
        {
            search_bar.ApiKey = "AIzaSyCdvNxkb5jbbggs7pvDs7nrSfak1lcsZ1E";
            search_bar.Type = PlaceType.Address;
            search_bar.Components = new Components("country:vn"); // Restrict results to Australia and New Zealand
            search_bar.PlacesRetrieved += Search_Bar_PlacesRetrieved;
            search_bar.TextChanged += Search_Bar_TextChanged;
            search_bar.MinimumSearchText = 2;
        }

        void Search_Bar_PlacesRetrieved(object sender, AutoCompleteResult result)
        {
            results_list.ItemsSource = result.AutoCompletePlaces;

            if (result.AutoCompletePlaces != null && result.AutoCompletePlaces.Count > 0)
                results_list.IsVisible = true;
        }

        void Search_Bar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                results_list.IsVisible = false;
            }
            else
            {
                results_list.IsVisible = true;
            }
        }

        public void LoadPin()
        {
            _homViewModel.FunctionLoadVehicleCommand();
            map.CustomPins = new System.Collections.Generic.List<CustomPin>();
            foreach (var v in _homViewModel.LstVehicle)
            {
                var cusPin = new CustomPin()
                {
                    Position = v.Position,
                    Address = v.Address,
                    Label = v.VehiclePlate,
                    Name = v.VehiclePlate,
                    Src = "Red0.png"
                };
                map.CustomPins.Add(cusPin);
                map.Pins.Add(cusPin);
            }
            map.MoveToRegion(MapSpan.FromCenterAndRadius(_homViewModel.LstVehicle[0].Position, Distance.FromMiles(100.0)));
        }
    }
}