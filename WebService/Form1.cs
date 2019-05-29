using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebService.practica;
using System.Data;

namespace WebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PracticaSoapClient s = new PracticaSoapClient();
            DateTime fecha=DateTime.Today;
            string actual = fecha.ToString("MM");
            int mes = fecha.Month;
            string dia = DateTime.Now.DayOfWeek.ToString();
            int day = mesEsp(dia);
            label3.Text = "Hoy es "+s.DiaSemana(day)+" del mes de " + s.mes(mes);


        }
        public int mesEsp(string m)
        {
            int resp=0;
            switch (m)
            {
                case "Monday":
                    resp = 1;
                    break;
                case "Tuesday":
                    resp = 2;
                    break;
                case "Wednesday":
                    resp = 3;
                    break;
                case "Thursday":
                    resp = 4;
                    break;
                case "Friday":
                    resp = 5;
                    break;
                case "Saturday":
                    resp = 6;
                    break;
                case "Sunday":
                    resp = 7;
                    break;

            }
            return resp;
        }
    }
}
