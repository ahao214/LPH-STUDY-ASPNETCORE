using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreBase
{
    public class IocShow
    {
        public void Show()
        {
            //IPerson person = new Student();
            //person.PlayGames();

            IPerson person = Factory.CreateInstance();
            person.PlayGames();
        }

    }


    class Factory
    {
        public static IPerson CreateInstance()
        {
            return new Teacher();
        }
    }


    interface IPerson
    {
        void PlayGames();

    }

    public class Student : IPerson
    {
        public void PlayGames()
        {
            Console.WriteLine("Castle is playing games");
        }
    }


    public class Teacher : IPerson
    {
        public void PlayGames()
        {
            Console.WriteLine("Sky Teacher is playing games");
        }
    }

    public class Message
    {
        public void SendMsg(string person, string msg)
        {
            Console.WriteLine($"{person}发送的消息是{msg}");
        }
    }
}
