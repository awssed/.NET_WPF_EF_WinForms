using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_WinFromsControlElements_
{
    public partial class Form3 : Form
    {
        List<Flight> listOfSearch ;
        public Form3(List<Flight> flights)
        {
            listOfSearch = flights;
            InitializeComponent();
        }

        private void Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            switch (ComboModel.SelectedIndex)
            {
                case 0:
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    break;
                case 1:
                    radioButton1.Enabled = true;
                    break;
                case 2:
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    break;
                case 3:
                    radioButton3.Enabled = true;
                    break;

            }
        }

        private void numericSeats_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Flight> result = listOfSearch.Where(p =>
            {
                if (ComboModel.SelectedIndex != -1)
                {
                    switch (ComboModel.SelectedIndex)
                    {
                        case 0:
                            return p.model.name == "Boeing";
                        case 1:
                            return p.model.name == "Airbus";
                        case 2:
                            return p.model.name == "Embraer";
                        case 3:
                            return p.model.name == "CRJ";
                    }
                    return false;
                }
                return true;
            }).Where(p =>
            {
                    if(radioButton1.Checked)
                    {
                        return p.type == Flight.typeOfPlane.civilian;
                    }if(radioButton2.Checked)
                    {
                        return p.type == Flight.typeOfPlane.freight;
                    }if(radioButton3.Checked)
                    {
                        return p.type == Flight.typeOfPlane.military;
                    }
                return true;
            }).Where(p =>
            {
                if(numericSeats.Value!=0)
                {
                    return p.numberOfSeats==numericSeats.Value;
                }
                return true;
            }).Where(p =>
            {
                if(numericWeight.Value!=0)
                {
                    return p.weight==numericWeight.Value;
                }
                return true;
            }).ToList();
            textBoxResult.Text = "";
            foreach(var item in result)
            {
                textBoxResult.Text += item.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter fs = new StreamWriter("reultsOfSearch.json"))
            {
                string str = JsonConvert.SerializeObject(listOfSearch);
                fs.Write(str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
