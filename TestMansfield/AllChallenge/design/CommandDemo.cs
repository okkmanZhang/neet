using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChallenge.design
{
    public interface ICommand
    {
        void Exec();
    }

    public interface ICommandConsole
    {
        ICommand _command { get; set; }

        void Action();
        void SetCommand(ICommand command);
    }

    public class Command1 : ICommand
    {
        public void Exec()
        {
            Console.WriteLine($"{nameof(Command1)}.{nameof(Exec)}");
        }
    }

    public class Command2 : ICommand
    {
        public void Exec()
        {
            Console.WriteLine($"{nameof(Command2)}.{nameof(Exec)}");
        }
    }

    public class CommandConsole
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Action()
        {
            _command.Exec();
        }
    }

    public class CommandClient
    {
        public static void Run()
        {
            var commandConsole = new CommandConsole();
            ICommand com1 = new Command1();
            ICommand com2 = new Command2();

            commandConsole.SetCommand(com1);
            commandConsole.Action();

            commandConsole.SetCommand(com2);
            commandConsole.Action();
        }
    }

}
