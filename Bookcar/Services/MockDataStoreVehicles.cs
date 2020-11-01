using Bookcar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace Bookcar.Services
{
    public class MockDataStoreVehicles : IDataStore<Vehicles>
    {
        private readonly List<Vehicles> LstVehicles;
        public MockDataStoreVehicles()
        {
            LstVehicles = new List<Vehicles>()
            {
                new Vehicles(){ VehiclePlate = "35A923048", Address = "Ninh Bình", Position = new Position(16.502384, 106.45843085), Src="Red0.png" },
                new Vehicles(){ VehiclePlate = "36A923048", Address = "Nam ĐỊnh", Position = new Position(16.002384, 106.75843085),Src="Blue0.png" },
                new Vehicles(){ VehiclePlate = "37A923048", Address = "Thái Bình", Position = new Position(16.102384, 107.95843085) ,Src="Red0.png"},
                new Vehicles(){ VehiclePlate = "38A923048", Address = "Hà Nam", Position = new Position(16.502384, 108.55843085),Src="Orange0.png" },
                new Vehicles(){ VehiclePlate = "39A923048", Address = "Thanh Hóa", Position = new Position(17.902384, 106.95843085) ,Src="Red0.png"},
            };
        }

        public Task<bool> AddItemAsync(Vehicles item)
        {
            LstVehicles.Add(item);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteItemAsync(string vehiclePlate)
        {
            var oldItem = LstVehicles.Where((Vehicles arg) => arg.VehiclePlate == vehiclePlate).FirstOrDefault();
            LstVehicles.Remove(oldItem);
            return Task.FromResult(true);
        }

        public Task<Vehicles> GetItemAsync(string vehiclePlate)
        {
            var oldItem = LstVehicles.Where((Vehicles arg) => arg.VehiclePlate == vehiclePlate).FirstOrDefault();
            return Task.FromResult(oldItem);
        }

        public async Task<IEnumerable<Vehicles>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(LstVehicles);
        }

        public Task<bool> UpdateItemAsync(Vehicles item)
        {
            throw new NotImplementedException();
        }
    }
}
