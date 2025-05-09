﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    // Invoker
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void PressButton() => _command.execute();

        public void PressUndoButton() => _command.undo();
    }
}
