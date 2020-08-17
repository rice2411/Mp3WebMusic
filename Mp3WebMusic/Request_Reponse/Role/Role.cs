using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Role
{
    public class Role
    {
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public string  RolePassword{ get; set; }
        public int IsDelete { get; set; }

        public string Message { get; set; }


    }
}
