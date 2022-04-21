using System;
using System.Collections.Generic;
using System.Text;
using StudentEntity;

namespace StudentInterface
{
    public interface IStudent
    {
        JsonResponse AddStudent(Student student);
    }
}
