using Dapper;
using Microsoft.Extensions.Options;
using StudentEntity;
using StudentInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace StudentRepository
{
    public class StudentRepo : IStudent
    {
        IOptions<ReadConfig> _connectionString;
        public StudentRepo(IOptions<ReadConfig> connectinString) 
        {
            _connectionString = connectinString;        
        }
        public JsonResponse AddStudent(Student student)
        {
          JsonResponse jsonResponse = new JsonResponse();
            using (SqlConnection connection = new SqlConnection(_connectionString.Value.DefaultConnection))
            {
                try
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add("@Id", student.Id);
                        parameters.Add("@StudentName", student.StudentName);
                        parameters.Add("@StudentAge", student.StudentAge);
                        parameters.Add("@StudentRoll", student.StudentRoll);
                        parameters.Add("@StudentClass", student.StudentClass);
                        jsonResponse = connection.Query<JsonResponse>(sql: "AddStudent", param: parameters,
                            transaction: transaction, commandType: CommandType.StoredProcedure).FirstOrDefault();
                        if(jsonResponse.IsSuccess)
                            transaction.Commit();
                        else
                            transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    jsonResponse.Message = ex.Message;
                }
            }
            return jsonResponse;
        }

       
    }
}
