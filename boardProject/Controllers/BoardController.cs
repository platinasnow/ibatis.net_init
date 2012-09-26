using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBatisNet.DataMapper;
using boardProject.Models;

namespace boardProject.Controllers
{
    public class BoardController:Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        public ActionResult boardList()
        {
            ViewData.Model = Mapper.Instance().QueryForList<BoardVO>("getBoardList",null);
            return View();
        }
        
    }
}