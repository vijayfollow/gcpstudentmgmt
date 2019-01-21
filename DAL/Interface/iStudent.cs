using DataAccessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer.Interface
{
    public interface IStudent
    {
        int StudentRegistration(Registration regData);
        DataTable GetStudentDetails();
        DataTable GetStudentDetailsById(int studentId);
    }
}
