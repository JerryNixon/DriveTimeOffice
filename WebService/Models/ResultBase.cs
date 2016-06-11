using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriveTimeOffice.WebService.Models
{
    public class ResultBase
    {
        public enum Results: int
        {
            Unknown = 0, Success = 1, Unauthorized = 2, Error = 3
        }
        public Results Result { get; set; } = Results.Unknown;
        public string ResultString => Result.ToString();

        public enum Errors
        {
            Unknown = 0, None = 1
        }
        public Errors Error { get; set; } = Errors.None;
    }
}