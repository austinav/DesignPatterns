using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApp1.Patterns.Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override string description
        {
            get
            {
                if (this.beverage.GetType().BaseType == (typeof(Beverage)))
                {
                    return $"{this.beverage.description} with {this.GetType().Name}";
                }
                else
                {
                    return $"{this.beverage.description} and {this.GetType().Name}";
                    //var allDesc = new List<string> { this.GetType().Name };
                    //allDesc.AddRange(this.beverage.description.Split(",").ToList());
                    //return string.Join(", ", allDesc.OrderBy(s => s));
                    //.GroupBy(item => item)
                    //.Select(group => group.Count() + " " + group.Key.ToString()).ToString()
                    // and {this.GetType().Name}";
                    //.Select(group => new
                    // {
                    //     group.Key,
                    //     Count = group.Count()
                    // });
                }
            }
        }

        public Beverage beverage;
 
    }
}