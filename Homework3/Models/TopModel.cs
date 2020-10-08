using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Homework3.Models;

namespace Homework3.Models
{
    public class Languages
    {
        public string LangId { get; set; }

        public string LangName { get; set; }

        public string LangRate { get; set; }
    }

    public class Tools
    {
        public string ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolRate { get; set; }
    }

    public class Websites
    {
        public string WebId { get; set; }
        public string WebName { get; set; }
        public string WebRate { get; set; }
    }
    public class Programmers
    {
        public string ProgrammerId { get; set; }
        public string ProgrammerName { get; set; }
        public string ProgrammerCompany { get; set; }
    }
}
