using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LW1.Controllers
{
    public class Lab1Controller : Controller
    {
        // GET: Lab1

        public ActionResult FirstViewMethod()
        {
            List<string> vegetables = GetVegetablesList();
            return View(vegetables);
        }

        public ActionResult SecondViewMethod()
        {
            return View(GetVegetablesList().OrderBy(x=>x).ToList());
        }

        public ActionResult ThirdViewController()
        {
            return View(GetVegetablesList().OrderBy(x=>x).ToList());
        }
       public List<string> GetVegetablesList()
        {
            List<string> vegetables =  new List<string>();
            vegetables.Add("Томат");
            vegetables.Add("Картофель");
            vegetables.Add("Огурец");
            vegetables.Add("Капуста");
            vegetables.Add("Кабчок");
            return vegetables;
        }

        public List<Human> GetHumansList()
        {
            List<Human> humans = new List<Human>;
            humans.Add(Human("Кирилл", "Леонов", ["Волейбол", []]));
        }
        public class Human
        {
            Human(string name, string surname, List<string> hobby)
            {
                this.name = name;
                this.surname = surname;
                this.hobby = hobby;
            }
            string name;
            string surname;
            List<string> hobby;
        }
    }
}