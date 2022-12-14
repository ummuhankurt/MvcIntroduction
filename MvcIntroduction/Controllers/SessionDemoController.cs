using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcIntroduction.Entites;
using MvcIntroduction.ExtensionMetods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcIntroduction.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetObject("student", new Student {FirstName = "Mehmet",LastName= "Yılmaz",Email = "memet@gmail.com" });
            HttpContext.Session.SetInt32("age", 23);
            HttpContext.Session.SetString("name", "ümmühan");
            return "session created";
        }

        public string GetSessions()
        {
            return String.Format("First Name:  {0} " +
                "Last Name : {1} , Email : {2}",HttpContext.Session.GetObject<Student>("student").FirstName, HttpContext.Session.GetObject<Student>("student").LastName, HttpContext.Session.GetObject<Student>("student").Email);
        }
    }
}
