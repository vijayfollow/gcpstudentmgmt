using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MySqlRepository
    {
        public int StudentRegistration(Registration regData)
        {
            int status = 0;
            using (MySqlCommand conn = new MySqlCommand(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Common.Constants.InsertRegistration, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StdId", regData.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", regData.FirstName);
                cmd.Parameters.AddWithValue("@LastName", regData.LastName);
                cmd.Parameters.AddWithValue("@CollegeName", regData.CollegeName);
                cmd.Parameters.AddWithValue("@IsActive", 1);
                status = Convert.ToInt16(cmd.ExecuteNonQuery());
            }
            return status;
        }
    }
}
