using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crud2.Models;

namespace Crud2.Models
{
    public class ViewModel
    {
        public IEnumerable<Crud2.Models.Externos> ieExternos { get; set; }
        public Crud2.Models.Externos mExternos { get; set; }
    }
}