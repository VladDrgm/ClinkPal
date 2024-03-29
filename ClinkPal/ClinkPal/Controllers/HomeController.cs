﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClinkPal.Models;
using ClinkPal.Services;

namespace ClinkPal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<ActionResult<DbDataProvider>> Index()
    {
        var data = new DbDataProvider();
        return data;
    }
}