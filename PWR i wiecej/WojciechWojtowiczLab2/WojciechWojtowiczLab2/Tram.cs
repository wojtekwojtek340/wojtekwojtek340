using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojciechWojtowiczLab2
{
    class Tram : Vehicle, IPantograph
    {
        bool pantographIsDown;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="nr"></param>
        /// <param name="year"></param>
        /// <param name="mod"></param>
        public Tram(int nr, int year, string mod)
        {
            vehicleNumber = nr;
            yearOfProduction = year;
            name = mod;
            pantographIsDown = false;
        }

        /// <summary>
        /// deklaracja interfejsu
        /// </summary>
        /// <returns></returns>
        public string PantographDown()
        {
            if(pantographIsDown == false)
            {
                pantographIsDown = true;
                return "Opuszczono pantograf";
            }
            else
            {
                return "pantograf jest juz opuszczony";
            }
        }

        /// <summary>
        /// deklaracja interfejsu
        /// </summary>
        /// <returns></returns>
        public string PantographUp()
        {
            if(pantographIsDown ==true)
            {
                pantographIsDown = false;
                return "podniesiono pantograf";
            }
            else
            {
                return "pantograf jest juz podniesiony";
            }
        }

        /// <summary>
        /// dzwonienie tramwajem
        /// </summary>
        /// <returns></returns>
        public string Bell()
        {
            return "Tramwaj dzwoni!";
        }
        /// <summary>
        /// implementacja metody odziedziczonej w klasie abstrakcyjne vehicle
        /// </summary>
        /// <returns></returns>
        public override string StartVehicle()
        {
            if(pantographIsDown == false)
            {
                return "tramwaj odjezdza";
            }
            else
            {
                return "pantograf jest podniesiony!";
            }
        }

        /// <summary>
        /// implementacja metody odziedziczonej w klasie abstrakcyjne vehicle
        /// </summary>
        /// <returns></returns>
        public override string StopVehicle()
        {
            return "tramwaj sie zatrzymal";
        }


    }
}
