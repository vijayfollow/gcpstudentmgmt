var APIurl = "";

var APISiteUrl = "http://localhost:53041/";

var APIUrl = APISiteUrl + "api/";


var Controller = {
    Student: "Student/",
}

var StudentURL = {
    InsertRegistration: APIUrl + Controller.Student + "InsertRegistration",
    GetStudentDetailsById: APIUrl + Controller.Student + "GetStudentDetailsById"
    //InsertRegistration: Controller.Student + "InsertRegistration",
    //GetStudentDetails: Controller.Student + "GetStudentDetails",
    //GetStudentDetailsById: Controller.Student + "GetStudentDetailsById"
}