using System;
using System.Linq;
using System.Collections.Generic;
using DriveTimeOffice.WebService.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DriveTimeOffice.WebService.Models
{
    public class GetDriveTimeResult : ResultBase
    {
        public string Appointment { get; set; }
        public Appointment PrefixAppointment { get; set; }
        public Appointment SuffixAppointment { get; set; }
    }
}