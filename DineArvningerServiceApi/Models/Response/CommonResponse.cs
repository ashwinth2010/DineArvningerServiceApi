using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DineArvningerServiceApi.Models.Response
{
    public class CommonResponse
    {
        public string sessionId { get; set; }

        public bool IsSuccess { get; set; }
    }
}