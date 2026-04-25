using Programming_WinFormsApp.Model.Enums;
using Programming_WinFormsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_WinFormsApp.View.Panels
{
    public partial class SeasonsHandleControl : UserControl
    {
        public SeasonsHandleControl()
        {
            InitializeComponent();

            SeasonDropList.DataSource = Enum.GetValues(typeof(Season));

            this.GoButton.Click += GoButton_Click;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Season chooseSeason = (Season)SeasonDropList.SelectedItem;

            switch (chooseSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    this.BackColor = AppColors.SummerColor;
                    break;
                case Season.Autumn:
                    this.BackColor = AppColors.AutumnColor;
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    this.BackColor = AppColors.WinterColor;
                    break;
                case Season.Spring:
                    this.BackColor = AppColors.SpringColor;
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }
    }
}
