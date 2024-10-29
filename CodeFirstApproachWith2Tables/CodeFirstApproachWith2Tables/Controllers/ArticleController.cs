﻿using CodeFirstApproachWith2Tables.Models;
using CodeFirstApproachWith2Tables.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeFirstAppWith2Table.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly TutorialDbContext _context;
        public ArticleController(IArticleRepository articleRepository, TutorialDbContext context)
        {
            _articleRepository = articleRepository;
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_articleRepository.GetAllArticle());
        }
        public IActionResult Details(int id)
        {
            return View(_articleRepository.GetArticleById(id));
        }

        public IActionResult Create()
        {
            ViewData["TutorialId"] = new SelectList(_context.Tutorials, "TutorialId", "TutorialId");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ArticleId,ArticleTitle,ArticleContent,TutorialId")] Article article)
        {
            if (ModelState.IsValid)
            {
                _articleRepository.AddArticle(article);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            return View(_articleRepository.GetArticleById(id));
        }
        [HttpPost]
        public IActionResult Edit(Article article)
        {
            _articleRepository.UpdateArticle(article);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            return View(_articleRepository.DeleteArticle(id));
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _articleRepository.DeleteArticle(id);
            return RedirectToAction("Index");
        }



    }
}
