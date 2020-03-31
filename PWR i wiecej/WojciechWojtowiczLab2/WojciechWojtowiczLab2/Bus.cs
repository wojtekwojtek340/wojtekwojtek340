using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab2
{
    class Bus : Vehicle, IPantograph
    {
        int gasoilLevel;

        /// <summary>
        /// konstuktor klasy bus.
        /// </summary>
        /// <param name="rn"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        /// 
        public Bus(int rn, int year, string mod)
        {
            vehicleNumber = rn;
            yearOfProduction = year;
            name = mod;
        }

        /// <summary>
        /// deklaracja interfejsu
        /// </summary>
        /// <returns></returns>
        public string PantographDown()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// deklaracja interfejsu
        /// </summary>
        /// <returns></returns>
        public string PantographUp()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// metoda zwracajaca informacje o zatankowaniu autobusu.
        /// </summary>
        /// <returns></returns>
        public string Refuel()
        {
            gasoilLevel = 100;
            return "Autobus został zatankowany";
        }

        /// <summary>
        /// implementacja metody odziedziczonej w klasie abstrakcyjne vehicle
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            return "Autobus odjeżdża";
        }

        /// <summary>
        /// implementacja metody odziedziczonej w klasie abstrakcyjne vehicle
        /// </summary>
        /// <returns></returns>
        public override string StopVehicle()
        {
            return "autobus sie zatrzymuje";
        }
    }
}
