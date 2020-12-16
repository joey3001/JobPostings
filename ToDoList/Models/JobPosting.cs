using System.Collections.Generic;

namespace ToDoList.Models
{
  public class JobPosting
  {
    public string Description { get; set; }
    public string ContactInfo { get; set; }
    public string Title { get; set; }
    public int Id { get; }
    private static List<JobPosting> _instances = new List<JobPosting> { };

    public JobPosting(string description, string contactInfo, string title)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      ContactInfo = ContactInfo;
      Title = title; 
    }

    public static List<JobPosting> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static JobPosting Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}
