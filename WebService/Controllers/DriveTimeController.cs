using DriveTimeOffice.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DriveTimeOffice.WebService.Controllers
{
    public class DriveTimeController : ApiController
    {
        public GetDriveTimeResult GetDriveTime(string id)
        {
            return new GetDriveTimeResult
            {
                Appointment = id,
                Result = ResultBase.Results.Success
            };
        }

        public UpsertDriveTimeResult UpsertDriveTime(string id, int minutes)
        {
            return new UpsertDriveTimeResult
            {
                Appointment = id,
                Result = ResultBase.Results.Success,
            };
        }

        public DeleteDriveTimeResult DeleteDriveTime(string id)
        {
            return new DeleteDriveTimeResult
            {
                Appointment = id,
                Result = ResultBase.Results.Success,
            };
        }
    }
}
