using System;
using System.Collections.Generic;
using System.Text;

namespace Codelab.Models
{
    public class ListUsersModel
    {
        public string login { get; set; }

        public string avatar_url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string starred_url { get; set; }
        public string repos_url { get; set; }
    }

    public class RootObject
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<ListUsersModel> items { get; set; }
    }
}
