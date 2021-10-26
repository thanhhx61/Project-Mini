﻿using AminLogin.Models;
using AminLogin.Models.Product;
using AminLogin.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AminLogin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [Microsoft.AspNetCore.Mvc.Route("/User/Index/{pageNumber=1}/{pageSize=10}/{keyword=''}")]

        public async Task<IActionResult> Index(int? pageNumber, int? pageSize, string keyword)
        {
            int count = 1;
            var users = await userService.GetUsers();
            var pagination = new Pagination(users.Count, pageNumber, pageSize, null);
            keyword = keyword == "''" ? string.Empty : keyword;
            var usersss = string.IsNullOrEmpty(keyword) ? users : users.Where(b => b.Email.Contains(keyword)).ToList();
            var listUser = new ListUser()
            {
                Pagination = pagination,
                appIdentityUser = usersss.Skip((pagination.CurrentPage - 1) * pagination.PageSize).Take(pagination.PageSize).ToList()
            };
            ViewBag.Count = count;
            return View(listUser);
        }

    }
}