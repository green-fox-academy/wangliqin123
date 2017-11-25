using CalorieApp.Entities;
using CalorieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieApp.Repositories
{
    public class CalorieAppRepository
    {
        CalorieAppContext CalorieAppContext;

        public CalorieAppRepository(CalorieAppContext calorieAppContext)
        {
            CalorieAppContext = calorieAppContext;
        }

        public List<Food> GetFoodList()
        {
            return CalorieAppContext.Foods.ToList();
        }

        public void AddFood(string name, int amount, int calorie)
        {
            Food newFood = new Food
            {
                Name = name,
                Amount = amount,
                Calorie = calorie
            };
            CalorieAppContext.Foods.Add(newFood);
            CalorieAppContext.SaveChanges();
        }

        public void RemoveFood(string name)
        {
            Food deleted = CalorieAppContext.Foods.FirstOrDefault(x => x.Name.Equals(name));
            CalorieAppContext.Foods.Remove(deleted);
            CalorieAppContext.SaveChanges();
        }
    }
}
