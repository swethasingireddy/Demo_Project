using Microsoft.AspNetCore.Mvc;
using CourseFeedback.Models;
using System.Collections.Generic;
using System.Linq;

namespace CourseFeedback.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>
        {
            new Feedback { Id = 1, StudentName = "Harsha", Course = "Data Engineering", Rating = 5, Comment = "Excellent!", Semester = "Fall 2024", Instructor = "Dr. Smith", IsAnonymous = false },
            new Feedback { Id = 2, StudentName = "Sai", Course = "Machine Learning", Rating = 4, Comment = "Good but tough.", Semester = "Fall 2024", Instructor = "Dr. Jane", IsAnonymous = true }
        };

        public IActionResult Index()
        {
            return View(feedbackList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Id = feedbackList.Count + 1;
                feedbackList.Add(feedback);
                return RedirectToAction("Index");
            }
            return View(feedback);
        }

        public IActionResult Charts()
        {
            return View(feedbackList);
        }

        public IActionResult Crud()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}