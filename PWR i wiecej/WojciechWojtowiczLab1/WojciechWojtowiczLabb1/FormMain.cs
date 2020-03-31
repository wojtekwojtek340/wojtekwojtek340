using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLabb1
{
    public partial class FormMain : Form
    {
        int number = 0;
        int number2 = 0;

    

        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funkcja zmienia kolor tła
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColour_Click(object sender, EventArgs e)
        {
            BackColor = Color.Gold;
        }
        /// <summary>
        /// funkcja uruchamiajaca obliczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            //zamiana typu zmiennych
            number = Int32.Parse(textBoxCount.Text);
            number += 7;
            MessageBox.Show(number.ToString());
            if (number > 30)
            {
                BackColor = Color.DeepPink;
            }
        }
        /// <summary>
        /// funkcja zmienia kolor napisu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLabelColour_Click(object sender, EventArgs e)
        {
            labelName.ForeColor = Color.Orange;
        }
        /// <summary>
        /// funkcja dodaje 2 wartosci z toolboxa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            number = Int32.Parse(textBoxCount.Text);
            number2 = Int32.Parse(textBoxValue.Text);

            number = number + number2;

            MessageBox.Show(number.ToString());

            if(number > 50)
            {
                BackColor = Color.Olive;
            }
        }
        /// <summary>
        /// funkcja zamieniajaca kolejnosc imienia i nazwiska
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLabelInvert_Click(object sender, EventArgs e)
        {

            labelName.Text = "Wojtowicz Wojciech";
        }
        /// <summary>
        /// funckja uruchamiajaca licznik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //ilosc milisekund miedzy zdarzeniami
            timerCount.Interval = 1000;
            //uruchomienia licznika
            timerCount.Start();
        }
        /// <summary>
        /// funkcja timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            //inkrementacja zmiennej number
            number++;
            //wyswietlanie zmiennej number
            textBoxCount.Text = number.ToString();
            buttonStart.Left += number;
            
        }
        /// <summary>
        /// funckja textboxa 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            if(number > 10)
            {
                BackColor = Color.Aqua;
            }

            if(number %2 ==0)
            {
                BackColor = Color.Chartreuse;
            }
            else if(number %2 == 1)
            {
                BackColor = Color.HotPink;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            //tworzenie obiektu nowego okienka
            FormAbout formAbout = new FormAbout();
            //wywietlanie okienka
            formAbout.formName = "Wojciech Wojtowicz";
            formAbout.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
