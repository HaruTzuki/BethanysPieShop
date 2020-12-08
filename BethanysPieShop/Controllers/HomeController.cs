﻿using BethanysPieShop.Model;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
	public class HomeController : Controller
	{
		private readonly IPieRepository _pieRepository;

		public HomeController(IPieRepository pieRepository)
		{
			this._pieRepository = pieRepository;
		}

		public IActionResult Index()
		{
			var homeViewModel = new HomeViewModel()
			{
				PiesOfTheWeek = _pieRepository.PiesOfTheWeek
			};

			return View(homeViewModel);
		}
	}
}