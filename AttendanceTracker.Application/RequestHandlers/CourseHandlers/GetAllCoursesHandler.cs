using AttendanceTracker.Data.DataRequestObjects.CourseRequests;

namespace AttendanceTracker.Application.RequestHandlers.CourseHandlers
{
    public class GetAllCoursesRequest : IRequest<IEnumerable<Course>> { }

    internal class GetAllCoursesHandler : DataHandler<GetAllCoursesRequest, IEnumerable<Course>>
    {
        public GetAllCoursesHandler(IDataAccess dataAccess) : base(dataAccess) { }

        public override async Task<IEnumerable<Course>> HandleRequestAsync(GetAllCoursesRequest request)
        {
            var dto = await _dataAccess.FetchListAsync(new GetAllCourses());

            return dto.Any() ? dto.Select(_ => _.AsCourse()) : Enumerable.Empty<Course>();
        }
    }
}
