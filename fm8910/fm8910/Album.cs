using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fm8910
{
   public class Album
    {
        public int status { get; set; }
        public int copyrightId { get; set; }
        public string name { get; set; }
        public Artist artist { get; set; }
        public object publishTime { get; set; }
        public object picId { get; set; }
        public int id { get; set; }
        public int size { get; set; }
    }
}
