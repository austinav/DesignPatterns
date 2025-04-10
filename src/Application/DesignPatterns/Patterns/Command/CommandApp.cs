using System;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.Command
{
    // Concrete Command
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light) => _light = light;

        public void execute() => _light.On();

        public void undo() => _light.Off();
    }

    // Receiver
    public class Light
    {
        public void On() => Console.WriteLine("The light is on.");

        public void Off() => Console.WriteLine("The light is off.");
    }

    public class CommandApp : App
    {
        public override void MainProgram()
        {
            // Create receiver
            Light light = new Light();

            // Create command and set its receiver
            ICommand lightOn = new LightOnCommand(light);

            // Create invoker and associate it with the command
            RemoteControl remote = new RemoteControl();
            remote.SetCommand(lightOn);

            // Execute command
            remote.PressButton();

            // Undo command
            remote.PressUndoButton();
        }
    }
}
