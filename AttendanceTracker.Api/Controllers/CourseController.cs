using AttendanceTracker.Application.RequestHandlers.CourseHandlers;
using AttendanceTracker.Application.RequestHandlers.SubjectHandlers;

namespace AttendanceTracker.Api.Controllers
{
    public class CourseController : BaseController
    {
        public CourseController(IOrchestrator orchestrator) : base(orchestrator) { }

        [HttpPost("GetallCourses")]
        public async Task<IEnumerable<Course>> GetAllCourses() =>
            await _orchestrator.GetResponseAsync<GetAllCoursesRequest, IEnumerable<Course>>(new());

        [HttpPost("InsertCourse")]
        public async Task<Course> InsertCourse(InsertCourseRequest request) =>
            await _orchestrator.GetResponseAsync<InsertCourseRequest, Course>(request);

        [HttpDelete("DeleteCourse")]
        public async Task DeleteCourse(string courseCode) =>
            await _orchestrator.ExecuteRequestAsync(new DeleteCourseRequest(courseCode));

        [HttpGet("GetCourseByCourseCode")]
        public async Task<Course> GetCourseByCourseCode(string courseCode) =>
            await _orchestrator.GetResponseAsync<GetCourseByCodeRequest, Course>(new(courseCode));

        [HttpGet("IsCourseCodeExisting")]
        public async Task<bool> IsCourseCodeExisting(string courseCode) =>
            await _orchestrator.GetResponseAsync<IsCourseCodeExistingRequest, bool>(new(courseCode));

        [HttpPost("UpdateCourse")]
        public async Task UpdateCourse(UpdateCourseRequest request) =>
            await _orchestrator.ExecuteRequestAsync(request);
    }
}
