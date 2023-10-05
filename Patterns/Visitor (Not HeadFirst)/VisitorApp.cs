using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Visitor
{
    //https://www.tutorialspoint.com/design_pattern/visitor_pattern.htm
    class VisitorApp : App
    {
        public override void MainProgram()
        {
            IComputerPart computer = new Computer();
            computer.accept(new ComputerPartDisplayVisitor());
        }
    }
}
