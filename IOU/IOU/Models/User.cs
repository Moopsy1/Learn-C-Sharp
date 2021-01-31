using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOU.Models
{
    public enum userTypeEnum
    {

    admin,
    user
};

    public class User
    {

        public int ID { get; set; }

        public string userName { get; set; }
        public string password { get; set; }

        public userTypeEnum userType { get; set; }

    }
}
