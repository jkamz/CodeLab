using System;
using System.Collections.Generic;
using System.Text;

namespace Codelab.Models
{
    public class UserProfileModel
    {
        public string name { get; set; }
        public int public_repos { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
    }
}
