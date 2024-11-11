namespace DatabaseProject.Test.Helper
{
    internal class HttpHelper
    {
        internal static class Urls
        {
            public readonly static string GetAllStudents = "/api/Student/GetAllAsync";
            public readonly static string GetStudent = "/api/Student/GetAsync";
            public readonly static string AddStudent = "/api/Student/AddAsync";
            public readonly static string EditStudent = "/api/Student/UpdateAsync";
            public readonly static string DeleteStudent = "/api/Student/DeleteAsync";
        }
    }
}
