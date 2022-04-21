var AcceptAndRejectionViewModal = function () {
    self.StudentID = ko.observable();
    self.StudentName = ko.observable();
    self.StudentAge = ko.observable();
    self.StudentClass = ko.observable();
    self.StudentRoll = ko.observable();

    self.SaveStudent = function () {
        
        var Student = {
            'Id': self.StudentID(),
            'StudentName': self.StudentName(),
            'StudnetClass': self.StudentClass(),
            'StudentAge': self.StudentAge(),
            'StudentRoll': self.StudentRoll()
        }
        
        $.ajax({
            type: "POST",
            url: '/Student/Entry/AddStudent',
            data: { "student": Student },
            datatype: "json",
            success: function (result) {
                if (result.isSuccess) {
                    alert(result.message)
                } else {
                    alert(result.message)
                }
            },
            error: function (error) {
                alert('error', error.message)
            }
        })
    }
}


$(document).ready(function () {
    ko.applyBindings(new AcceptAndRejectionViewModal());

});