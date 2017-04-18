using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using System.Collections.Generic;
using CheeseMVC.ViewModels;
using CheeseMVC.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<CheeseMenu> CheeseMenus { get; set; }
        
    }

}
