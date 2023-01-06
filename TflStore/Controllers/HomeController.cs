using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TflStore.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using TflStore;

namespace TflStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         Console.WriteLine("Invoking Home Controller index method  ");
        return View();
    }

    public IActionResult Privacy()
    { Console.WriteLine("Invoking Home Controller PRIVACY method  ");
        return View();
    }
    public IActionResult Login(){
         Console.WriteLine("Invoking Home Controller LOGIN method. ");
       

        return View();
    }
      public IActionResult Register(){
         Console.WriteLine("Invoking Home ControllerR REGISTER method. ");
       

        return View();
    }
    public IActionResult Client(string Firstname,string Lastname,string ContactNumber,string Email,string Password){
    
       List<Employ> emp=new List<Employ>();
       Employ e1=new Employ( Firstname,Lastname, ContactNumber, Email, Password);
       emp.Add(e1);
       var options=new JsonSerializerOptions {IncludeFields=true};
       var RegJson=JsonSerializer.Serialize<List<Employ>>(emp,options);
    string Filename=@"D:\New folder\day 8\TflStore\tfl.json";
    System.IO.File.WriteAllText(Filename,RegJson);
     Console.WriteLine("Your data is stored successfully");
            string jsonString =   System.IO.File.ReadAllText(Filename);
            List<Employ> emp1 = JsonSerializer.Deserialize<List<Employ>>(jsonString);

        return Redirect("/home/Index");

    }
    



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
