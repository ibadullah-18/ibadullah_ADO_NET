

using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=True;Trust Server Certificate=True;");

#region Sclar Valued Queue - ExcuteScalar
var result = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Students");


#endregion