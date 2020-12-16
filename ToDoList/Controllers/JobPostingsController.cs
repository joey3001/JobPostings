using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class JobPostingsController : Controller
  {
    [HttpGet("/jobpostings")]
    public ActionResult Index()
    {
      List<JobPosting> allJobs = JobPosting.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobpostings/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/jobpostings")]
    public ActionResult Create(string description, string title, string contactInfo)
    {
      JobPosting myJob = new JobPosting(description, contactInfo, title);
      return RedirectToAction("Index");
    }

    [HttpPost("/jobpostings/delete")]
    public ActionResult DeleteAll()
    {
      JobPosting.ClearAll();
      return View();
    }

    [HttpGet("/jobpostings/{id}")]
    public ActionResult Show(int id)
    {
      JobPosting foundJob = JobPosting.Find(id);
      return View(foundJob);
    }
  }
}