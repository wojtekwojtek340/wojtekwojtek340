using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojciechWojtowiczLab1Zadanie
{
    public partial class FormMain : Form
    {
        //inicjalizacja zmiennych
        //ilosc zlota
        int gold = 100;
        //ilosc drewna
        int wood = 10;
        //ilosc wojska
        int myArmy = 10;
        //ilosc wrogiego wojska
        int enemyArmy = 0;
        // poziom tartaka
        int sawmillLevel = 1;
        //poziom kopalni zlota
        int goldMineLevel = 1;
        //poziom muru
        int wallLevel = 1;
        //poziom koszar
        int barrackLevel = 1;
        //wydobycie zlota
        int goldMineExtraction = 50;
        //wydobycie drewna
        int woodExtraction = 10;
        //godzina i dzien w grze
        int hour = 0;
        int day = 0;
        //zmienna liczaca przejsca zegara dla progress barow dla kopalni,muru,tartaku,koszar
        int timerTickGold = 0;
        int timerTickWall = 0;
        int timerTickBarrack = 0;
        int timerTickSawmill = 0;



        public FormMain()
        {
            InitializeComponent();
            timerCount.Interval = 1000;
            timerCount.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelGoldMine.Text = "Kopalnia poziom " + goldMineLevel.ToString();
            labelSawmill.Text = "Tartak poziom " + sawmillLevel.ToString();
            labelBarrack.Text = "Koszary poziom " + barrackLevel.ToString();
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            hour++;
            if(hour >24)
            {
                hour = 0;
                day++;
                gold += goldMineExtraction;
                wood += woodExtraction;
            }
            labelGlobalTime.Text = "Dzien " + day + " Godzina " + hour;
            labelMyArmy.Text = "Wojownicy " + myArmy;
            labelWood.Text = "Drewno " + wood;
            labelGold.Text = "Zloto " + gold;
        }

        private void timerGoldMineUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickGold++;
            progressBarGoldMineUpgrade.Increment(1);
            if (5 < timerTickGold)
            {
                timerGoldMineUpgrade.Stop();
                progressBarGoldMineUpgrade.Hide();
                timerTickGold = 0;
                progressBarGoldMineUpgrade.Value = 0;
                goldMineLevel++;
                goldMineExtraction += 10;
                labelGoldMine.Text = "Kopalnia poziom " + goldMineLevel.ToString();
            }
        }

        private void timerSawmillUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickSawmill++;
            progressBarSawmillUpgrade.Increment(1);
            if (5 < timerTickSawmill)
            {
                timerSawmillUpgrade.Stop();
                progressBarSawmillUpgrade.Hide();
                timerTickSawmill = 0;
                progressBarSawmillUpgrade.Value = 0;
                sawmillLevel++;
                woodExtraction += 10;
                labelSawmill.Text = "Tartak poziom " + sawmillLevel.ToString();
            }
        }

        private void timerBarrackUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickBarrack++;
            progressBarBarrackUpgrade.Increment(1);
            if (5 < timerTickBarrack)
            {
                timerBarrackUpgrade.Stop();
                progressBarBarrackUpgrade.Hide();
                timerTickBarrack = 0;
                progressBarBarrackUpgrade.Value = 0;
                barrackLevel++;
                labelBarrack.Text = "Koszary poziom " + barrackLevel.ToString();
            }
        }

        private void timerWallUpgrade_Tick(object sender, EventArgs e)
        {
            timerTickWall++;
            progressBarWallUpgrade.Increment(1);
            if (5 < timerTickWall)
            {
                timerWallUpgrade.Stop();
                progressBarWallUpgrade.Hide();
                timerTickWall = 0;
                progressBarWallUpgrade.Value = 0;
                wallLevel++;
                labelWallLevel.Text = "Mur poziom " + wallLevel.ToString();
            }
        }

        private void buttonWallUpgrade_Click(object sender, EventArgs e)
        {
            if (wood - 10 * wallLevel >= 0 && gold - 30 * wallLevel >= 0)
            {
                wood = wood - 10 * wallLevel;
                gold = gold - 30 * wallLevel;
                timerWallUpgrade.Start();
                progressBarWallUpgrade.Show();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        private void buttonBarrackUpgrade_Click(object sender, EventArgs e)
        {
            if(wood - 10 * barrackLevel >=0 && gold - 30 * barrackLevel >= 0)
            {
                wood = wood - 10 * barrackLevel;
                gold = gold - 30 * barrackLevel;
                timerBarrackUpgrade.Start();
                progressBarBarrackUpgrade.Show();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        private void buttonGoldMineUpgrade_Click(object sender, EventArgs e)
        {
            if(wood - 10 * goldMineLevel >=0 && gold - 30 * goldMineLevel >=0)
            {
                wood = wood - 10 * goldMineLevel;
                gold = gold - 30 * goldMineLevel;
                progressBarGoldMineUpgrade.Show();
                timerGoldMineUpgrade.Start();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        private void buttonSawmillUpgrade_Click(object sender, EventArgs e)
        {
            if(wood - 10 * sawmillLevel >= 0 && gold - 30 * sawmillLevel >= 0)
            {
                wood = wood - 10 * sawmillLevel;
                gold = gold - 30 * sawmillLevel;
                timerSawmillUpgrade.Start();
                progressBarSawmillUpgrade.Show();
            }
            else
            {
                MessageBox.Show("Brak surowców");
            }
        }

        private void buttonGoldMineInfo_Click(object sender, EventArgs e)
        {
            FormExtractionInfo formGoldMine = new FormExtractionInfo(goldMineLevel, goldMineExtraction);
            formGoldMine.Show();
        }

        private void buttonSawmillInfo_Click(object sender, EventArgs e)
        {
            FormExtractionInfo formGoldMine = new FormExtractionInfo(sawmillLevel, woodExtraction);
            formGoldMine.Show();
        }
    }
}
