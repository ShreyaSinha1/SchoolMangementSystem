﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemBO
{
    
    /// <summary>
    /// Student Properties
    /// </summary>
    public class SrvSectionProperties
    {
        public int SectionID { get; set; }

        public string Section { get; set; }
    }
    public class SrvSectionReturnMessage
    {
        public SrvMessage Message { get; set; }

        public SrvSectionReturnMessage()
        {
            Message = new SrvMessage();
        }

    }

    public class SrvSectionInfo
    {
        public SrvMessage Message { get; set; }

        public int SectionID { get; set; }

        public string Section { get; set; }
        public SrvSectionInfo()
        {
            Message = new SrvMessage();
        }
    }

    public class SrvSectionParams : SrvListParams
    {
        public string Filter { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }

    /// <summary>
    /// Displaying List Items
    /// </summary>
    public class SrvSectionInfoListData : SrvListData
    {
        public List<SrvSection> aaData { get; set; }
    }

    public class SrvSection
    {
        public int SectionID { get; set; }

        public string Section { get; set; }
    }


}
