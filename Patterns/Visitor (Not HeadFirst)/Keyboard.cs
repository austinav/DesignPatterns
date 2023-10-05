using System;

namespace DesignPatterns.Patterns.Visitor
{
    public class Keyboard : IComputerPart
    {
        public void accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.visit(this);
        }
    }
}