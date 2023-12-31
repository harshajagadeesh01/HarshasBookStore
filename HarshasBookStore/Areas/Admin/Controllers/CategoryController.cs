﻿using HarshasBooks.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarshasBookStore.Areas.Admin.Controllers
{


    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        // API calls here
        #region API CALLS 
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj }); 
        }
        #endregion
    }
}