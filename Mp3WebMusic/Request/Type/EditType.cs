using Mp3WebMusic.DOMAIN.Reponse.Songs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3WebMusic.DOMAIN.Request.Songs
{
    public class EditType
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }                
        public DateTime UpLoadDate { get; set; }
    }
}
