using DataAccessLayer.DTO;
using DataAccessLayer.Interface;

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class RegistrationRepository : IStudent
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public int StudentRegistration(Registration regData)
        {
            int status = 0;
            //using (SqlConnection conn = new SqlConnection(_connectionString))
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(Common.StoreProcedure.InsertUserRegistration, conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@UserName", userData.UserName);
            //    cmd.Parameters.AddWithValue("@FirstName", userData.FirstName);
            //    cmd.Parameters.AddWithValue("@LastName", userData.LastName);
            //    cmd.Parameters.AddWithValue("@EmailId", userData.EMailId);
            //    cmd.Parameters.AddWithValue("@Password", userData.Password);
            //    status = Convert.ToInt16(cmd.ExecuteNonQuery());
            //}
            return status;
        }

        public DataTable GetStudentDetails(int studentId)
        {
            DataTable studentData = new DataTable();

            return studentData;
        }
    }
}
