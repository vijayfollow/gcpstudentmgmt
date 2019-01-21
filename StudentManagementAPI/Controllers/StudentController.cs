using DataAccessLayer.DTO;
using DataAccessLayer.Interface;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentManagementAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {
        IStudent _IStudentRepository = new RegistrationRepository();

        [HttpPost]
        public HttpResponseMessage InsertRegistration(Registration regData)
        {
            int status = _IStudentRepository.StudentRegistration(regData);
            return Request.CreateResponse(HttpStatusCode.OK, status);
        }

        [HttpPost]
        public HttpResponseMessage GetStudentDetailsById(Registration regData)
        {
            DataTable stdTable = new DataTable();
            stdTable = _IStudentRepository.GetStudentDetailsById(regData.StudentId);
            return Request.CreateResponse(HttpStatusCode.OK, stdTable);
        }

    }
}
