using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fm8910
{
   public class Canciones
    {
        public Album album { get; set; }
        public int status { get; set; }
        public int copyrightId { get; set; }
        public string name { get; set; }
        public int rtype { get; set; }
        public int mvid { get; set; }
        public List<object> alias { get; set; }
        public int fee { get; set; }
        public int ftype { get; set; }
        public List<Artista> artists { get; set; }
        public int duration { get; set; }
        public object rUrl { get; set; }
        public int id { get; set; }

    }
}
