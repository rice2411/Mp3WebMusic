using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Type
{
    public class Types
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public bool IsDelete { get; set; }
        public string Message { get; set; }
        public string Poster { get; set; }
    }
}
