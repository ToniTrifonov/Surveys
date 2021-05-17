﻿namespace OceniTest.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using OceniTest.Services.Data;
    using OceniTest.Web.ViewModels.Quizzes;

    public class QuizzesController : BaseController
    {
        private readonly IQuizzesService quizzesService;

        public QuizzesController(IQuizzesService quizzesService)
        {
            this.quizzesService = quizzesService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateQuizInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.quizzesService.CreateAsync(input);
            return this.RedirectToAction("All");
        }

        public IActionResult All()
        {
            var quizzesList = this.quizzesService.GetAll();

            return this.View(quizzesList);
        }
    }
}