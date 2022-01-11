using System;
using System.Collections.Generic;

namespace Library.Models
{
    public class KhModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class UserMoreInfo
        {
            public string bio { get; set; }
            public string twitter { get; set; }
            public string snapchat { get; set; }
            public string instagram { get; set; }
            public string tiktok { get; set; }
            public string image { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string title_ar { get; set; }
            public string title_en { get; set; }
            public string code { get; set; }
            public string total_codes { get; set; }
            public string remain_codes { get; set; }
            public string is_visible { get; set; }
            public string winner_name { get; set; }
            public string prize { get; set; }
            public int user_id { get; set; }
            public string user_name { get; set; }
            public UserMoreInfo user_more_info { get; set; }
            public string date_to_drow { get; set; }
            public string time_to_drow { get; set; }
            public string date_to_show { get; set; }
            public string time_to_show { get; set; }
            public string visitor { get; set; }
            public int status { get; set; }
        }

        public class Data
        {
            public List<Datum> data { get; set; }
        }

        public class Root
        {
            public bool success { get; set; }
            public Data data { get; set; }
            public string message { get; set; }
        }



    }
}
