using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistrationn
{
    public partial class Form1 : Form
    {
        private object studentInfoClass;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.LastName = LastName.Text.ToString();
            StudentInfoClass.FirstName = FirstName.Text.ToString();
            StudentInfoClass.MiddleName = MiddleName.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt32(age.Text);
            StudentInfoClass.ContactNo = Convert.ToInt32(ContactNo.Text);
            StudentInfoClass.StudentNo = Convert.ToInt32(StudentNo.Text);
        }
    }
}
