using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public struct timeStruct
{
    public int Hours;
    public int Minutes;
    public int Seconds;
}

namespace FussySharp
{
    public partial class Form1 : Form
    {
        timeStruct ti = new timeStruct();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void StartStop(object sender, EventArgs e)
        {

        }

        private void hour_TextChanged(object sender, EventArgs e)
        {
            string hours = hour.Text;
            //captured text changed MessageBox.Show(hours);
            try
            {
                ti.Hours = Convert.ToInt32(hours);
                hour.BackColor = Color.White;
            }
            catch
            {
                hour.BackColor = Color.Red;
                //do nothing until try to start timer because typing an incorrect character to have it immeadiatly crash is a bad experience.
            }
        }

        private void min_TextChanged(object sender, EventArgs e)
        {
            string mins = min.Text;
            try
            {
                ti.Minutes = Convert.ToInt32(mins);
                min.BackColor = Color.White;
            }
            catch
            {
                min.BackColor = Color.Red;
                //do nothing until try to start timer because typing an incorrect character to have it immeadiatly crash is a bad experience.
            }
        }

        private void secs_TextChanged(object sender, EventArgs e)
        {
            string seconds = secs.Text;
            //lol secs

            try
            {
                ti.Seconds = Convert.ToInt32(seconds);
                secs.BackColor = Color.White;
            }
            catch
            {
                secs.BackColor = Color.Red;
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            //Form2 Settings = new Form2();
            //Settings.Show();
        }
    }
    public class Clocky
    {

    }
}
