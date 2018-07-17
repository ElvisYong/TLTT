using Amazon.CognitoIdentityProvider;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TLTT.Models
{
    public class CognitoUser : IdentityUser
    {
        public string Password { get; set; }
        public UserStatusType Status { get; set; }
    }
}