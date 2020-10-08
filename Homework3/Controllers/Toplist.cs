using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Homework3.Models;

namespace Homework3.Controllers
{
    public class Toplist : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Top 10 Programming Languages to Learn In 2020";
            ViewBag.title2 = "Top 10 Deeveloper Tools for 2020";
            ViewBag.title3 = "Top 10 Most visited Website Rank 2020";
            ViewBag.title4 = "Top 10 The best Programmer in the world";
            ViewData["langlist"] = Languagelist();
            ViewData["toollist"] = Toollist();
            ViewData["weblist"] = Websitelist();
            ViewData["gmerlist"] = Programmerlist();

            return View();
        }
        public IActionResult Language()
        {
            ViewBag.title1 = "Top 10 Programming Languages to Learn In 2020";
            ViewData["langlist"] = Languagelist();

            return View();
        }
        public IActionResult Tool()
        {

            ViewBag.title2 = "Top 10 Deeveloper Tools for 2020";
            ViewData["toollist"] = Toollist();

            return View();
        }
        public IActionResult Website()
        {
            ViewBag.title3 = "Top 10 Most visited Website Rank 2020";
            ViewData["weblist"] = Websitelist();

            return View();
        }
        public IActionResult Programmer()
        {
            ViewBag.title4 = "Top 10 The best Programmer in the world";
            ViewData["gmerlist"] = Programmerlist();

            return View();
        }

        public List<Languages> Languagelist()
        {
            List<Languages> listlang = new List<Languages>();
            listlang.Add(new Languages { LangId = "1", LangName = "Python", LangRate = "29.9%" });
            listlang.Add(new Languages { LangId = "2", LangName = "JavaScript", LangRate = "19.9%" });
            listlang.Add(new Languages { LangId = "3", LangName = "Java", LangRate = "7.3%" });
            listlang.Add(new Languages { LangId = "4", LangName = "Swift", LangRate = "6.2%" });
            listlang.Add(new Languages { LangId = "5", LangName = "GoLang", LangRate = "6.0%" });
            listlang.Add(new Languages { LangId = "6", LangName = "C#", LangRate = "5.9%" });
            listlang.Add(new Languages { LangId = "7", LangName = "C++", LangRate = "5.4%" });
            listlang.Add(new Languages { LangId = "8", LangName = "Scala", LangRate = "3.2%" });
            listlang.Add(new Languages { LangId = "9", LangName = "Kotlin", LangRate = "1.8%" });
            listlang.Add(new Languages { LangId = "10", LangName = "Ruby", LangRate = "0.9%" });

            return listlang;
        }

        public List<Tools> Toollist()
        {
            List<Tools> listtool = new List<Tools>();
            listtool.Add(new Tools { ToolId = "1", ToolName = "GitKraken", ToolRate = "25.6%" });
            listtool.Add(new Tools { ToolId = "2", ToolName = "Visual Studio Code", ToolRate = "25.5%" });
            listtool.Add(new Tools { ToolId = "3", ToolName = "Postman", ToolRate = "20.1%" });
            listtool.Add(new Tools { ToolId = "4", ToolName = "Visual Studio", ToolRate = "18.3%" });
            listtool.Add(new Tools { ToolId = "5", ToolName = "Docker", ToolRate = "15.9%" });
            listtool.Add(new Tools { ToolId = "6", ToolName = "Git", ToolRate = "14.7%" });
            listtool.Add(new Tools { ToolId = "7", ToolName = "GitHub", ToolRate = "13.8%" });
            listtool.Add(new Tools { ToolId = "8", ToolName = "Sublime Text", ToolRate = "8.4%" });
            listtool.Add(new Tools { ToolId = "9", ToolName = "IntelliJ IDEA", ToolRate = "5.1%" });
            listtool.Add(new Tools { ToolId = "10", ToolName = "Command Line", ToolRate = "3.7%" });

            return listtool;
        }

        public List<Websites> Websitelist()
        {
            List<Websites> listweb = new List<Websites>();
            listweb.Add(new Websites { WebId = "1", WebName = "Google.com", WebRate = "60.49 Billion" });
            listweb.Add(new Websites { WebId = "2", WebName = "Youtube.com", WebRate = "24.31 Billion" });
            listweb.Add(new Websites { WebId = "3", WebName = "Facebook.com", WebRate = "19.98 Billion" });
            listweb.Add(new Websites { WebId = "4", WebName = "	Baidu.com", WebRate = "	9.77 Billion" });
            listweb.Add(new Websites { WebId = "5", WebName = "Wikipedia.org", WebRate = "4.69 Billion" });
            listweb.Add(new Websites { WebId = "6", WebName = "Twitter.com", WebRate = "3.92 Billion" });
            listweb.Add(new Websites { WebId = "7", WebName = "	Yahoo.com", WebRate = "3.74 Billion" });
            listweb.Add(new Websites { WebId = "8", WebName = "pornhub.com", WebRate = "3.36 Billion" });
            listweb.Add(new Websites { WebId = "9", WebName = "Instagram.com", WebRate = "3.21 Billion" });
            listweb.Add(new Websites { WebId = "10", WebName = "xvideos.com", WebRate = "3.19 Billion" });

            return listweb;
        }

        public List<Programmers> Programmerlist()
        {
            List<Programmers> listprogrammer = new List<Programmers>();
            listprogrammer.Add(new Programmers { ProgrammerId = "1", ProgrammerName = "Bill Gates", ProgrammerCompany= "Microsoft co-founder" });
            listprogrammer.Add(new Programmers { ProgrammerId = "2", ProgrammerName = "James Gosling", ProgrammerCompany = "Java Creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "3", ProgrammerName = "Richard Stallman", ProgrammerCompany = "GNU Project Creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "4", ProgrammerName = "Bjarne Stroustrup", ProgrammerCompany = "C++ Creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "5", ProgrammerName = "Tim Berners-Lee", ProgrammerCompany = "HTML and WWW inventor" });
            listprogrammer.Add(new Programmers { ProgrammerId = "6", ProgrammerName = "Ken Thompson ", ProgrammerCompany = "UNIX Co-Creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "7", ProgrammerName = "Linus Torvalds", ProgrammerCompany = "Linux Kernel Creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "8", ProgrammerName = "Dennis Ritchie", ProgrammerCompany = "C Programming language creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "9", ProgrammerName = "Jack Dorsey", ProgrammerCompany = "Twitter Creator" });
            listprogrammer.Add(new Programmers { ProgrammerId = "10", ProgrammerName = "Ruchi Sanghvi", ProgrammerCompany = "FB’s first female engineer" });

            return listprogrammer;
        }
    }
}
