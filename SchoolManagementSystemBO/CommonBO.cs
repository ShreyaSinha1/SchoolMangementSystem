using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
   
    public class SrvListParams
     {
        public int UserId { get; set; }
        public string SearchText { get; set; }

        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public long StartingPos { get; set; }

        public int PageRecords { get; set; }
                
        }
    public class SrvListData
    {

        private long lngTotalRecords { get; set; }
        public SrvMessage Message { get; set; }
        public int sEcho { get; set; }
        public long iTotalRecords { get; set; }
        public long iTotalDisplayRecords { get; set; }
         public SrvListData()
        {
            Message = new SrvMessage();
        }

    }
    public class SrvRenderSelect
    {
        public string ItemText { get; set; }

        public string ItemValue { get; set; }
        public string ItemGroup { get; set; }
        public string ItemAlternateText { get; set; }

    }
    public enum ActionMode
    {
        None = 0,
        List = 1,
        View = 2,
        Add = 3,
        Edit = 4,
        Clone = 5
    }

    public enum Status
    {
        Active = 1,
        Pending = 2,
        Paused = 3,
        Expired = 4,
        Incomplete_Green = 5,
        Incomplete_Red = 6,
        Disabled = 7,
        Need_Approval = 8,
        Declined = 9,
        Inactive = 10,
        Cap_Hit = 11,
        Deleted = 12,
        Requestes = 13,
        Inreview = 17

    }

    public enum AssignedRole
    {
        Super_Admin = 1,
        Admin = 2,
        Users = 3
    }

}
