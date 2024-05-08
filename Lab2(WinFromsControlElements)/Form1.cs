using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2_WinFromsControlElements_
{
    public partial class Form1 : Form
    {
        List<Flight> flights = new List<Flight>();
        Flight newFlight=new Flight();
        Manufacturer Boeing = new Manufacturer("Boeing", 2000, "America", new Flight.typeOfPlane[] { Flight.typeOfPlane.civilian, Flight.typeOfPlane.freight });
        Manufacturer Airbus = new Manufacturer("Airbus", 1995, "America", new Flight.typeOfPlane[] { Flight.typeOfPlane.civilian});
        Manufacturer Embraer = new Manufacturer("Emraer", 1990, "America", new Flight.typeOfPlane[] { Flight.typeOfPlane.civilian, Flight.typeOfPlane.freight,Flight.typeOfPlane.military });
        Manufacturer CRJ = new Manufacturer("CRJ", 1990, "America", new Flight.typeOfPlane[] { Flight.typeOfPlane.military});
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void addedMember(object sender, EventArgs e)
        {
            labelCrew.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2(newFlight.members);
            form2.CrewMembersChanged += addedMember;
            form2.Show();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            newFlight.id =textBoxId.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    newFlight.model =Boeing;
                    break;
                case 1:
                    newFlight.model =Airbus;
                    break;
                case 2:
                    newFlight.model =Embraer;
                    break;
                case 3:
                    newFlight.model = CRJ;
                    break;
            }
            newFlight.numberOfSeats = (int)numericSeats.Value;
            newFlight.yearOfReales = (int)numericYear.Value;
            if(radioButton1.Checked)
            {
                newFlight.type = Flight.typeOfPlane.civilian;
            }
            if (radioButton2.Checked)
            {
                newFlight.type = Flight.typeOfPlane.freight;
            }
            if (radioButton3.Checked)
            {
                newFlight.type = Flight.typeOfPlane.military;
            }
            newFlight.lastTecServ = TechServ.SelectionRange.Start;
            newFlight.weight = (int)numericWeight.Value;
            flights.Add(newFlight);
            newFlight = new Flight();
            clearForm();
            ImportList.Clear();
            foreach (Flight f in flights)
            {
                ImportList.Text += f.ToString();
            }
            toolStripStatusLabel1.Text="Count:"+flights.Count.ToString()+" action:added";

        }
        private void clearForm()
        {
            textBoxId.Clear();
            comboBox1.SelectedIndex = -1;
            numericSeats.Value = 0;
            numericYear.Value = 1980;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            TechServ.SelectionRange.Start = DateTime.Now;
            numericWeight.Value = 0;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.Visible = true;
                }
            }

        }
        private void textBoxEmpty(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                if (tb.Text.Length == 0)
                {
                    tb.BackColor = Color.Red;
                    tb.Tag = false;
                }
                else
                {
                    tb.BackColor = System.Drawing.SystemColors.Window;
                    tb.Tag = true;
                }
        }
        public bool IDValidation(Flight flight)
        {
            Type type = typeof(Flight);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (Attribute attr in attributes)
            {

                if (attr is AircraftIDAtribute iDAtribute)
                    return iDAtribute.pattern.IsMatch(flight.id);
            }
            return true;

        }
        private void textBoxId_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            newFlight.id = tb.Text;
            if (IDValidation(newFlight) && tb.Text.Length!=0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
                if(flights.Count!=0)
                {
                    foreach(var f in flights)
                    {
                        if(f.id.Equals(tb.Text))
                        {
                            tb.BackColor = Color.Red;
                            tb.Tag = false;
                        }
                    }
                }
            }
            else
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            changeEnable();
        }

        private void trackBarSeats_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar tb = (System.Windows.Forms.TrackBar)sender;
            numericSeats.Value = tb.Value;
            if(tb.Value==0)
            {
                labelSeats.Visible = true;
            }
            else
            {
                labelSeats.Visible = false;
            }
            changeEnable();

        }

        private void numericSeats_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            trackBarSeats.Value =(int) num.Value;
            changeEnable();

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void changeEnable()
        {
            if((bool)textBoxId.Tag==true && labelModel.Visible==false && 
                trackBarSeats.Value!=0 &&
                labelCrew.Visible==false&&
                labelSeats.Visible==false &&
                labelYear.Visible==false&&
                labelDate.Visible==false&&
                labelDate.Visible==false&&
                labelWeight.Visible==false&&
                groupBox1.Controls.OfType<RadioButton>().Any(rb => rb.Checked)
                )
            {
                buttonAccept.Enabled = true;
            }
            else
            {
                buttonAccept.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelModel.Visible = false;
            groupBox1.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    break;
                case 1:
                    radioButton1.Enabled = true;
                    break;
                case 2:
                    radioButton1.Enabled= true;
                    radioButton2.Enabled= true;
                    radioButton3.Enabled= true;
                    break;
                 case 3:
                    radioButton3.Enabled = true;
                    break;

            }

            changeEnable();
        }

        private void TechServ_DateSelected(object sender, DateRangeEventArgs e)
        {
            labelDate.Visible = false;
            changeEnable();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericWeight.Value == 0)
            {
                labelWeight.Visible = true;
            }
            else
            {
                labelWeight.Visible = false;

            }
            changeEnable();
        }

        private void numericYear_ValueChanged(object sender, EventArgs e)
        {
            labelYear.Visible = false;
            changeEnable();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter fs = new StreamWriter("airport.json"))
            {
                string str = JsonConvert.SerializeObject(flights);
                fs.Write(str);
            }
            toolStripStatusLabel1.Text = "Count:" + flights.Count.ToString() + " action:exported";

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                ImportList.Text = "";
                List<Flight> list = new List<Flight>();
                string str2 = File.ReadAllText("airport.json");
                list = JsonConvert.DeserializeObject<List<Flight>>(str2);
                foreach (Flight f in list)
                {
                    ImportList.Text += f.ToString();
                }
                flights = list;
                toolStripStatusLabel1.Text = "Count:" + flights.Count.ToString() + " action:imported";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла JSON: " + ex.Message);
            }
        }

        private void ImportList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Десериализовать содержимое каждого файла JSON и добавить в TextBox
            foreach (string file in files)
            {
                try
                {
                    string json = File.ReadAllText(file);
                    // Десериализовать JSON и добавить в TextBox
                    List<Flight> deserializedObject = JsonConvert.DeserializeObject<List<Flight>>(json);
                    foreach (Flight f in deserializedObject)
                    {
                        ImportList.Text = f.ToString();
                    }    
                    flights = deserializedObject;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла JSON: " + ex.Message);
                }
            }
        }

        private void ImportList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Проверить каждый файл на тип JSON
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (extension?.ToLower() != ".json")
                    {
                        // Если найден файл, не являющийся JSON, отклонить перетаскивание
                        e.Effect = DragDropEffects.None;
                        return;
                    }
                }

                // Разрешить перетаскивание, если все файлы JSON
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if(flights.Count>1)
            {
                var sortedFlights = flights.OrderBy(p => p.yearOfReales).ToList();
                flights = sortedFlights;
                ImportList.Text = "";
                foreach (Flight f in flights)
                {
                    ImportList.Text += f.ToString();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(flights);
            form3.Show();
        }

        private void buttonHIdeTool_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
                buttonHideTool.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                buttonHideTool.Refresh();
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Safonov Eugene\n v1", "Airport", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TechServ_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ImportList.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (flights.Count > 1)
            {
                var sortedFlights = flights.OrderBy(p => p.lastTecServ).ToList();
                flights = sortedFlights;
                ImportList.Text = "";
                foreach (Flight f in flights)
                {
                    ImportList.Text += f.ToString();
                }
            }
        }
    }
}
