﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanAndRide.BusinessLogic;

namespace PlanAndRide.GUI
{
    internal class FindUserRides
    {
        public void UserRides(Ride ride)
        {
            do
            {
                Console.WriteLine("Wprowadź login szukanego użytkownika\n");
                var input = Console.ReadLine();
                var findUserRides = ride.Name.SelectMany(r => ride.RideMembers.Where(r => r.Login == input)).ToList();
                if (findUserRides != null || !string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nie znaleziono podanego użytkownika\n");
                }
            }
            while (true) ;
        }
        
    }
}
