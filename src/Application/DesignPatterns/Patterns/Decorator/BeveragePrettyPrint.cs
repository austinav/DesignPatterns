using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1.Patterns.Decorator;

using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Patterns.Decorator
{
    public class BeveragePrettyPrint //: CondimentDecorator
    {
        //public List<string> UpdateCondimentCountInList(List<string> descList, string currentCondiment)
        //{
        //    descList[descList.IndexOf(currentCondiment)].Insert(0, "1");
        //    descList[descList.IndexOf(currentCondiment)].Insert(0, "1");


        //    List<string> test = new List<string>() { "Item1", "Item2", "Item3" };
        //    var testWhere = test.Aggregate(test.GetRange(0, 1), (descList, next)
        //             => descList.Contains(next)
        //                 ? descList[descList.IndexOf(next)].Insert(0, "1")
        //                 : descList);
        //}

        //public BeveragePrettyPrint(Beverage beverage)
        //{
        //    this.beverage = beverage;
        //}

        //public override decimal cost()
        //{
        //    return this.beverage.cost();
        //}
    }
}
