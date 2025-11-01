using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Hospital_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplayPatient_Click(object sender, EventArgs e)
        {
            try
            {
                Patient patient = new Patient(textBoxName.Text, Convert.ToInt32(numericUpDownAge.Value), textBoxDisease.Text);

                string patientDetails = patient.GetDetails();

                MessageBox.Show(patientDetails, "Patient Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
