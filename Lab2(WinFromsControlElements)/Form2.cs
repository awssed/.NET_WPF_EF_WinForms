using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_WinFromsControlElements_
{
    public partial class Form2 : Form
    {
        private List<CrewMember> crewMembers;
        public event EventHandler CrewMembersChanged;
        public Form2(List<CrewMember> crew)
        {
            crewMembers = crew;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFIO_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string pattern = @"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$";
            if (Regex.IsMatch(tb.Text, pattern) && tb.Text.Length != 0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            else
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((bool)textBoxFIO.Tag && comboBoxPos.SelectedIndex!=-1)
            {
                CrewMember.positionOfMember pos=CrewMember.positionOfMember.none;
                switch (comboBoxPos.SelectedIndex)
                {
                    case 0:
                        pos = CrewMember.positionOfMember.pilot;
                        break;
                    case 1:
                        pos=CrewMember.positionOfMember.pilot;
                        break;

                }

                crewMembers.Add(new CrewMember(textBoxFIO.Text,(int)numeriсAge.Value,(int)numericExp.Value,pos));
                CrewMembersChanged.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private void comboBoxPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCrew.Visible = false;
        }
    }
}
