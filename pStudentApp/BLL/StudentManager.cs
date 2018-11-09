using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pStudentApp.DAL.GateWay;
using pStudentApp.DAL.Model;

namespace pStudentApp.BLL
{
    public class StudentManager
    {
        static StudentGateway studentGateway = new StudentGateway();
        public static string Save(Student aStudent)
        {
            int rowAffect = studentGateway.Save(aStudent);

            if (rowAffect>0)
            {
                return "Saved!!!!!!";
            }
            else
            {
                return "Failed!";
            }
        }

    }
}