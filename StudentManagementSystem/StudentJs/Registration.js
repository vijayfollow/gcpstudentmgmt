

function InsertRegistration() {
    var studentId = $("#stdId").val();
    var firstName = $("#fName").val();
    var lastName = $("#lName").val();
    var clgName = $("#clgName").val();

    if (studentId)
        $("#stdId").css("border-color", "");
    else
        $("#stdId").css("border-color", "red");

    if (firstName)
        $("#fName").css("border-color", "");
    else
        $("#fName").css("border-color", "red");

    if (lastName)
        $("#lName").css("border-color", "");
    else
        $("#lName").css("border-color", "red");

    if (clgName)
        $("#clgName").css("border-color", "");
    else
        $("#clgName").css("border-color", "red");


    if (firstName && lastName && clgName) {

        var regData = {
            StudentId: studentId,
            FirstName: firstName,
            LastName: lastName,
            CollegeName: clgName
        }

        $.ajax({
            url: StudentURL.InsertRegistration,
            type: 'Post',
            dataType: 'json',
            data: regData,
            success: function (data) {
                ClearFields();
                if (data == 1)
                    alert("Record Inserted Successfully");
                else
                    alert("Record Already Exists");
            }, error: function (err) {
                alert(err);
            }
        });
    }
}

function GetStudent() {
    var studentId = $("#stdId").val();
    if (studentId)
        $("#stdId").css("border-color", "");
    else
        $("#stdId").css("border-color", "red");

    if (!studentId)
        return false;

    var regData = {
        StudentId: studentId
    }

    $.ajax({
        url: StudentURL.GetStudentDetailsById,
        type: 'Post',
        dataType: 'json',
        data: regData,
        success: function (data) {
            $("#stdId").val(data[0].StdId);
            $("#fName").val(data[0].FirstName);
            $("#lName").val(data[0].LastName);
            $("#clgName").val(data[0].CollegeName);
        }, error: function (err) {
            alert(err);
        }
    });
}


function ClearFields() {
    $("#stdId").val('');
    $("#fName").val('');
    $("#lName").val('');
    $("#clgName").val('');
}