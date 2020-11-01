using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms.Maps;

namespace Bookcar.Models
{
    public class Vehicles : INotifyPropertyChanged
    {
        private Position _position { get; set; }
        public Position Position
        {

            get
            {
                return _position;
            }

            set
            {
                if (_position != value)
                {
                    _position = value;
                    OnPropertyChanged("Position");
                }
            }
        }


        private string _vehiclePlate { get; set; }
        public string VehiclePlate
        {

            get
            {
                return _vehiclePlate;
            }

            set
            {
                if (_vehiclePlate != value)
                {
                    _vehiclePlate = value;
                    OnPropertyChanged("VehiclePlate");
                }
            }
        }
        private string _address { get; set; }

        public string Address
        {

            get
            {
                return _address;
            }

            set
            {
                if (_address != value)
                {
                    _address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        private string _src { get; set; }
        public string Src
        {

            get
            {
                return _src;
            }

            set
            {
                if (_src != value)
                {
                    _src = value;
                    OnPropertyChanged("Src");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
