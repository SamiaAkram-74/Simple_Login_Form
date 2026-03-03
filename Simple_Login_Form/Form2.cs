using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simple_Login_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        //Data of left panel will show(display) on right panel
        //Right Panel textbox    Left Panel textbox
            txtNameShow.Text = textNameIn.Text;
            txtAgeShow.Text = txtAgeIn.Text;
            txtDegreeShow.Text = txtDegreeIn.Text;
            txtGenderShow.Text = txtGenderIn.Text;

            // Create instance(object) of Student class
            Student std = new Student
            {
                Name = textNameIn.Text,
                Age = txtAgeIn.Text
            };

            //Clear Textboxes of left panel where we enter data
            textNameIn.Text = String.Empty;
            txtAgeIn.Text = String.Empty;
            txtDegreeIn.Text = String.Empty;
            txtGenderIn.Text = String.Empty;

            MessageBox.Show("Record added successfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear textboxes of left panel
            textNameIn.Text = String.Empty;
            txtAgeIn.Text = String.Empty;
            txtDegreeIn.Text = String.Empty;
            txtGenderIn.Text = String.Empty;

            //Clear textboxes of right panel
            txtNameShow.Text = String.Empty;
            txtAgeShow.Text = String.Empty;
            txtDegreeShow.Text = String.Empty;
            txtGenderShow.Text = String.Empty;
        }
    }
}
