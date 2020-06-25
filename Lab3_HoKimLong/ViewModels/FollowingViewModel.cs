using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab3_HoKimLong.Models;

namespace Lab3_HoKimLong.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}