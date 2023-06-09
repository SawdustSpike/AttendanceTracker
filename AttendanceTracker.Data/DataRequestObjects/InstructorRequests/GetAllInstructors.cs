namespace AttendanceTracker.Data.DataRequestObjects.InstructorRequests
{
    public class GetAllInstructors : Parameterless_DataRequest<Instructor_DTO>
    {
        public override string GetSql() => Select.FromTable(TableNames.Instructor);
    }
}
