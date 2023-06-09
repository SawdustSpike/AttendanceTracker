using AttendanceTracker.Data.DataRequestObjects.InstructorRequests;


namespace AttendanceTracker.Application.RequestHandlers.InstructorHandlers
{
    public class GetAllInstructorsRequest : IRequest<IEnumerable<Instructor>> { }

    internal class GetAllInstructorsHandler : DataHandler<GetAllInstructorsRequest, IEnumerable<Instructor>>
    {
        public GetAllInstructorsHandler(IDataAccess dataAccess) : base(dataAccess) { }

        public override async Task<IEnumerable<Instructor>> HandleRequestAsync(GetAllInstructorsRequest request)
        {
            var dto = await _dataAccess.FetchListAsync(new GetAllInstructors());

            return dto.Any() ? dto.Select(_ => _.AsInstructor()) : Enumerable.Empty<Instructor>();
        }
    }
}
