using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab2
{
    abstract class Vehicle
    {
        protected int vehicleNumber, yearOfProduction;
        protected string name;

        /// <summary>
        /// metoda pobierajaca numer pojazdu
        /// </summary>
        /// <returns></returns>
        public virtual int GetVehicleNumber()
        {
            return vehicleNumber;
        }

        /// <summary>
        /// metoda pobierajaca rok produkcji.
        /// </summary>
        /// <returns></returns>
        public virtual int GetYearOfProduction()
        {
            return yearOfProduction;
        }

        /// <summary>
        /// metoda pobierająca nazwe pojazdu.
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            return name;
        }

        /// <summary>
        /// metoda ustawia nr pojazdu.
        /// </summary>
        /// <param name="n"></param>
        public virtual void SetVehicleNumber(int n)
        {
            vehicleNumber = n;
        }

        //metody abstrakcyjne do zdefiniowana w klasach dzieciach!!!
        abstract public string StartVehicle();
        abstract public string StopVehicle();
    }
}
