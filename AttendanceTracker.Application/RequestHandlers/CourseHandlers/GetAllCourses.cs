using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceTracker.Application.RequestHandlers.CourseHandlers
{
    internal class GetAllCourses : IRequest<IEnumerable<Course>>
    {
        public GetAllCourses() {  }
        
    }
}
