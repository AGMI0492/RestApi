using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APPDB
{
    public class AG_PULLTEST
    {
        public string TIPO { get; set; }
        public string CALIBRE { get; set; }
        public string FUERZA_MINIMA { get; set; }
        // public List<Post> Posts { get; set; }
    }

}