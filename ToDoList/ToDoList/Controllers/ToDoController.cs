using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.ToDoList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ToDoItem item)
        {
            if (ModelState.IsValid)
            {
                item.Id = Guid.NewGuid();
                Data.ToDoList.Add(item);

                return RedirectToAction("List");
            }
            else
            {
                return View(item);
            }
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var item = Data.ToDoList.SingleOrDefault(x => x.Id == id);

            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(ToDoItem item)
        {
            if (ModelState.IsValid)
            {
                var originalItem = Data.ToDoList.SingleOrDefault(x => x.Id == item.Id);
                originalItem.Title = item.Title;

                return RedirectToAction("List");
            }
            else
            {
                return View(item);
            }
        }
    }
}
