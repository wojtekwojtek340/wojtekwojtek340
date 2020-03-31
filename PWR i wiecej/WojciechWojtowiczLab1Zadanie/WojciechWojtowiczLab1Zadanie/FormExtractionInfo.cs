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
    public partial class FormExtractionInfo : Form
    {
        int level = 0;
        int extraction = 0;

        public FormExtractionInfo()
        {
            InitializeComponent();
        }

        public FormExtractionInfo(int _level, int _extraction)
        {
            InitializeComponent();
            level = _level;
            extraction = _extraction;
            labelGoldMineLevel.Text = "Poziom " + level;
            labelGoldMineExtraction.Text = "Aktualne wydobycie " + extraction;
            labelGoldMineExtractionNext.Text = "Kolejne wydobycie " + (extraction + 10);
        }

        private void FormGoldMine_Load(object sender, EventArgs e)
        {

        }
    }
}
