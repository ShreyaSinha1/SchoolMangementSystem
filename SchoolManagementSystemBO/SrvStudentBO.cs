using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
    public class SrvStudentParam
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string Address { get; set; }

        public string Image { get; set; }
    }

    public class SrvStudentMessage
    {
        public SrvMessage Message { get; set; }
        public SrvStudentMessage()
        {
            Message = new SrvMessage();
        }
    }

}
