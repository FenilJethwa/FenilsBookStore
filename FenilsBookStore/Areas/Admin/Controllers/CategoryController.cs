﻿using Microsoft.AspNetCore.Mvc;
using FenilsBookStore.Area;
using FenilsBookStore.DataAccess;
using FenilsBooks.DataAccess.Repository.IRepository;
using FenilsBooks.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FenilsBooks.Models;

namespace FenilsBookStore.Areas.Admin.Controllers
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
            // return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
