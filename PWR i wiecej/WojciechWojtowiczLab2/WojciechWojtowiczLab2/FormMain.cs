using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab2
{
    public partial class Form1 : Form
    {
        //lista pojazdów
        private List<Vehicle> vehiclesList = new List<Vehicle>();
        private int listIndex;

        private Vehicle vehicle;

        public Form1()
        {
            InitializeComponent();
            listIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// przycisk dodajacy pojazd do listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            //utowrzenie obiektu vehicle ktory bedzie tramwajem
            if(radioButtonTram.Checked ==true)
            {
                vehicle = new Tram(Int32.Parse(textBoxVehicleNumber.Text), Int32.Parse(textBoxYearProduction.Text), textBoxName.Text);
            }
            //utowrzenie obiektu vehicle ktory bedzie autobusem
            else
            {
                vehicle = new Bus(Int32.Parse(textBoxVehicleNumber.Text), Int32.Parse(textBoxYearProduction.Text), textBoxName.Text);
            }
            //dodajemy do listy
            vehiclesList.Add(vehicle);
            //czyscimy pola
            textBoxVehicleNumber.Text = "";
            textBoxYearProduction.Text = "";
            textBoxName.Text = "";
        }

        /// <summary>
        /// przejscie na następny elment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // pobieranie danych z listy.
            vehicle = vehiclesList[Math.Abs(listIndex++ % vehiclesList.Count)];

            //pobieranie parametrow obiektu z vehicle 
            labelActualNumberDesctription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearDescription.Text = vehicle.GetYearOfProduction().ToString();
            labelActualModelDesctription.Text = vehicle.GetName();

            //jeśli vehicle "wskazuje" na tramwaj
            if (vehicle is Tram)
            {
                labelActualVehicleDesctription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDesctription.Text = "Autobus";
            }
        }

        /// <summary>
        /// przejscie na poprzedni element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // pobieranie danych z listy.
            vehicle = vehiclesList[Math.Abs(listIndex-- % vehiclesList.Count)];

            //pobieranie parametrow obiektu z vehicle 
            labelActualNumberDesctription.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearDescription.Text = vehicle.GetYearOfProduction().ToString();
            labelActualModelDesctription.Text = vehicle.GetName();

            //jeśli vehicle "wskazuje" na tramwaj
            if(vehicle is Tram)
            {
                labelActualVehicleDesctription.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDesctription.Text = "Autobus";
            }
        }

        /// <summary>
        /// funckja startuje pojazd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StartVehicle());
        }

        /// <summary>
        /// funckja zatrzymuje pojazd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StopVehicle());
        }

        /// <summary>
        /// funckja wlączajaca dzwonek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBell_Click(object sender, EventArgs e)
        {
            if(vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.Bell());
            }
            else
            {
                MessageBox.Show("obiekt nie jest tramwajem");
            }
        }

        /// <summary>
        /// funkcja tankujaca autobus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if (vehicle is Bus)
            {
                Bus bus = (Bus)vehicle;
                MessageBox.Show(bus.Refuel());
            }
            else
            {
                MessageBox.Show("obiekt nie jest autobusem");
            }
        }

        /// <summary>
        /// funkcja opuszczajaca pantograf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPantographDown_Click(object sender, EventArgs e)
        {
            if(vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.PantographDown());
            }
            else
            {
                MessageBox.Show("obiekt nie jest tramwajem");
            }
        }

        /// <summary>
        /// funckja podnoszaca pantograf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPantographUp_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.PantographUp());
            }
            else
            {
                MessageBox.Show("obiekt nie jest tramwajem");
            }
        }
    }
}
