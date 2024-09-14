using System;

namespace DesignPatterns.Patterns.Visitor
{
    public interface IComputerPart
    {
        void accept(IComputerPartVisitor computerPartVisitor);
    }
}

