using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaCalendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creación de variables

        double SalarioBasico = 0;
        double HorasOrdinarios = 0, HorasExtrasDiurnas = 0, HorasExtrasNoct = 0, RecargoNoctrunoOrd = 0, RecargoNoctunoFest = 0;
        double ValorT1 = 0, ValorT2 = 0, ValorT3 = 0, ValorT4 = 0, ValorT5 = 0;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Dia1.Text = dateTimePicker1.Text.ToString();
        }

        int T1, T2, T4, T5;
            
        /*private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
                {
                new DateTime(2020,4,12),
                new DateTime(2020,4,29),
            DateTime.Today.AddDays(3)
                };
        }*/

        //Para día 1

       /* private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Dia1.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            if (comboBox1.SelectedItem.ToString() == "Turno 1")
            {
                Dia1.Text = Convert.ToString(ValorT1);
                T1 = T1 + 1;
            }
        }

        private void Dia1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        //Para día 2         

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;
        }
    }
}
