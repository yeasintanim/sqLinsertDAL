using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using pStudentApp.DAL.Model;

namespace pStudentApp.DAL.GateWay
{
    public class StudentGateway
    {
        public int Save(Student aStudent)
        {
            string connectionString = @"Data Source=YEASIN_TANIM_PC;Initial Catalog=UniDB;Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);


            string query = "INSERT INTO StuTable (RegNO, Name,Email,Address, Department)" +
                           "VALUES (@RegNO, @Name, @Email, @Address, @Department)";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RegNO", aStudent.Regno);
            command.Parameters.AddWithValue("@Name", aStudent.Name);
            command.Parameters.AddWithValue("@Email", aStudent.Email);
            command.Parameters.AddWithValue("@Address", aStudent.Address);
            command.Parameters.AddWithValue("@Department", aStudent.Department);

            connection.Open();
            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            return rowAffect;
        }


    }
}