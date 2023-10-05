using System;

namespace DesignPatterns.Patterns.Visitor
{
    public interface IComputerPartVisitor
    {
        public void visit(Computer computer);
        public void visit(Mouse mouse);
        public void visit(Keyboard keyboard);
        public void visit(Monitor monitor);
    }
}

