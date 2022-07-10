﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Environment = System.Environment;


namespace PlanAndRide.BusinessLogic
{
    public class RideRepository : IRepository<Ride>
    {
        private static List<Ride>
             Rides = new List<Ride>
            {
                new Ride
                {
                    Id = 1,
                    Name ="Ride1",
                    Date=DateTime.Now,
                    Route="Route1",
                    Description="Ala ma kota",
                    IsPrivate=true,
                    ShareRide=true,
                },
                new Ride
                {
                    Id = 2,
                    Name ="Ride2",
                    Date=DateTime.Now,
                    Route="Route1",
                    Description="Kot ma Ale",
                    IsPrivate=false,
                    ShareRide=true,
                },
                new Ride
                {
                    Id = 3,
                    Name ="Ride3",
                    Date=DateTime.Now,
                    Route="Route2",
                    Description="Ale kod to kot",
                    IsPrivate=true,
                    ShareRide=true,
                }
            };

      
        public  RideRepository()
        {
           
        }
        public Ride? Get(int id)
        {
            try
            {
                return Rides.FirstOrDefault(r => r.Id == id);
            }
            catch
            {
                throw new InvalidOperationException($"Unique key violaton: Ride Id:{id}");
            }
        }
        public IEnumerable<Ride> GetAll()
        {
            return Rides;
        }        
        public void Add(Ride ride)
        {
            if(Rides.Count > 0)
            {
                ride.Id = Rides.Max(r=>r.Id)+1;
            }
            else
            {
                ride.Id = 1;
            }
            Rides.Add(ride);
        }
        public void Update(int id, Ride ride)
        {
            var existingRide= Get(id);
            if(existingRide == null)
            {
                throw new RecordNotFoundException($"Ride Id:{id} not found in repository");
            }
            existingRide.Name = ride.Name;
            existingRide.Date = ride.Date;
            existingRide.IsPrivate = ride.IsPrivate;
            existingRide.Route = ride.Route;
        }
        public void Delete(int id)
        {
            _=Rides.Remove(Get(id));
        }
        
        //private static List<Ride> rides = new List<Ride>();

        //static RideRepository()
        //{
        //    var json = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "data.json"));
        //    rides = JsonConvert.DeserializeObject<List<Ride>>(json);
        //}

        //public static List<Ride> GetAllRides()
        //{
        //    return rides;
        //}

        //public static void AddRide(Ride ride)
        //{
        //    rides.Add(ride);
        //}


    }
}
