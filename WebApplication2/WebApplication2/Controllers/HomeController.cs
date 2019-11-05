using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models; //Добавление пространства имен из класса UserReviews.cs
using System.Linq;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("RsvpForm");           
        }
        
        [HttpGet] //Метод RsvpFrom должен применяться только для запросов GET
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost] //Метод Rsvp должен применяться только для запросов POST
        public ViewResult RsvpForm(UserReviews review)
        {
            if (ModelState.IsValid)
            {
                //Сохранить отзыв от пользователя
                Repository.AddComment(review);
                //Вернуть благодарность за отзыв
                return View("RsvpForm", review);
            }

            else
            {
                return View(); //Обнаружена ошибка проверки достоверности
            }
        }

        public ViewResult ListReviews() 
        {
            //Вызвать метод View(), используя свойство Repository.Comments в качестве аргумента
             return View(Repository.Comments); 
        }

    }
}