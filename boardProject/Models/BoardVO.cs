using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace boardProject.Models
{
    public class BoardVO
    {
        public int seq { get; set; }
        public int boardNum { get; set; }
        public string title { get; set; }
        public string contents { get; set; }
        public int hit { get; set; }
        public int reply { get; set; }
        public string writer { get; set; }
        
    }
}