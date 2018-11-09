using System;
using pStudentApp.BLL;
using pStudentApp.DAL.Model;

namespace pStudentApp.UI
{
    public partial class StudentUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Regno = regTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addTextBox.Text;
            aStudent.Department = deptTextBox.Text;

            string message = StudentManager.Save(aStudent);
            outputLabel.Text = message;


        }


       
    }
}