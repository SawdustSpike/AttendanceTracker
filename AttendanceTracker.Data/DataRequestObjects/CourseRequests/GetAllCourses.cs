namespace AttendanceTracker.Data.DataRequestObjects.CourseRequests
{
    public class GetAllCourses : Parameterless_DataRequest<Course_DTO>
    {
        public override string GetSql() => Select.FromTable(TableNames.Course);
    }
}
