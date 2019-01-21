using DataAccessLayer.DTO;
using DataAccessLayer.Interface;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        IStudent _IStudentRepository = new RegistrationRepository();
        // GET: Student
        public ActionResult Registration()
        {                      
            return View();
        }

        //public JsonResult InsertRegistration(Registration regData)
        //{
        //    int status = _IStudentRepository.StudentRegistration(regData);
        //    return Json(status, JsonRequestBehavior.AllowGet);
        //}

        public JsonResult GetStudentDetails()
        {
            DataTable stdTable = new DataTable();
            stdTable = _IStudentRepository.GetStudentDetails();
            List<Registration> lstStudents = new List<Registration>();

            if (stdTable.Rows.Count > 0)
            {
                foreach(DataRow dr in stdTable.Rows)
                {
                    Registration obj = new Registration();
                    obj.StudentId = Convert.ToInt32(dr["stdId"]);
                    obj.FirstName = Convert.ToString(dr["FirstName"]);
                    obj.LastName = Convert.ToString(dr["LastName"]);
                    obj.CollegeName = Convert.ToString(dr["CollegeName"]);
                    lstStudents.Add(obj);
                }
            }

            return Json(lstStudents, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStudentDetailsById(int studentId)
        {
            DataTable stdTable = new DataTable();
            stdTable = _IStudentRepository.GetStudentDetailsById(studentId);
            List<Registration> lstStudents = new List<Registration>();
            if (stdTable.Rows.Count > 0)
            {
                foreach (DataRow dr in stdTable.Rows)
                {
                    Registration obj = new Registration();
                    obj.StudentId = Convert.ToInt32(dr["stdId"]);
                    obj.FirstName = Convert.ToString(dr["FirstName"]);
                    obj.LastName = Convert.ToString(dr["LastName"]);
                    obj.CollegeName = Convert.ToString(dr["CollegeName"]);
                    lstStudents.Add(obj);
                }
            }
            return Json(lstStudents, JsonRequestBehavior.AllowGet);
        }

    }
}