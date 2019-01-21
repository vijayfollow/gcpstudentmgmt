using DataAccessLayer.DTO;
using DataAccessLayer.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
//using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class RegistrationRepository : IStudent
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public int StudentRegistration(Registration regData)
        {
            int status = 0;
            String sqlQuery = "SELECT 1 FROM Student WHERE StdId=" + regData.StudentId;
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (!sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    sqlQuery = "INSERT INTO Student (StdId, FirstName, LastName, CollegeName,IsActive) ";
                    sqlQuery += "VALUES('" + regData.StudentId + "', '" + regData.FirstName + "', '" + regData.LastName + "', '" + regData.CollegeName + "',1)";
                    cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                    status = 1;
                }
                else
                {
                    //sqlDataReader.Close();
                    //sqlQuery = "UDPATE Student SET StdId = '" + regData.StudentId + "', FirstName='" + regData.FirstName + "', LastName='" + regData.LastName + "', CollegeName='" + regData.CollegeName + "'";
                    //cmd = new MySqlCommand(sqlQuery, conn);
                    //cmd.ExecuteNonQuery();
                    status = 2;
                }
                //MySqlCommand cmd = new MySqlCommand(Common.Constants.InsertRegistration, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@StdId", regData.StudentId);
                //cmd.Parameters.AddWithValue("@FirstName", regData.FirstName);
                //cmd.Parameters.AddWithValue("@LastName", regData.LastName);
                //cmd.Parameters.AddWithValue("@CollegeName", regData.CollegeName);
                //cmd.Parameters.AddWithValue("@IsActive", 1);
                //status = Convert.ToInt16(cmd.ExecuteNonQuery());
            }
            return status;
        }

        public DataTable GetStudentDetails()
        {
            DataTable student = new DataTable();
            //using (SqlConnection conn = new SqlConnection(_connectionString))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(Common.Constants.GetStudentDetails, conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    sda.Fill(student);
            //}
            return student;
        }

        public DataTable GetStudentDetailsById(int studentId)
        {
            DataTable student = new DataTable();
            String sqlQuery = "SELECT * FROM Student WHERE StdId=" + studentId;
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@StdId", studentId);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(student);
            }
            return student;
        }
    }
}
