using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriveTimeOffice.WebService.Models
{
    public class Settings
    {
        public int DriveBeforeMinutes { get; set; }
        public int DriveAfterMinutes { get; set; }
    }
}