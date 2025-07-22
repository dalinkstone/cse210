using System;

class Program
{
    static void Main(string[] args)
    {
      List<Activity> activityList = new List<Activity>();

      activityList.Add(new Running(DateTime.Now, 30, 3.0));
      activityList.Add(new Cycling(DateTime.Now, 45, 15.0));
      activityList.Add(new Swimming(DateTime.Now, 60, 40.0));

      foreach (Activity activity in activityList)
      {
        Console.WriteLine(activity.GetSummary());
      }
    }
}
