using CalorieApp.Entities;
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
    }
}
