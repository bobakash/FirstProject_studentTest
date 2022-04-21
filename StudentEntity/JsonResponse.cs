using System;
using System.Collections.Generic;
using System.Text;

namespace StudentEntity
{
    public class JsonResponse
    {
        public bool IsSuccess { get; set; }
        public bool IsValidSubmissionNO { get; set; }
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
        public string Token { get; set; }
        public object ResponseData { get; set; }
        public object Records { get; set; }
        public string OutputParam { get; set; }
        public object TotalRecords { get; set; }
        public string CallBack { get; set; }
        public bool IsToken { get; set; }
        public string ProfileImage { get; set; }
        public string ChangePassword { get; set; }
        public bool HasError { get; set; }
        public bool HasPasswordChange { get; set; }
        public bool ErrorTrap { get; set; }
     
    }
}
