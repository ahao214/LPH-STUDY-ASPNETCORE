using System;

namespace _01_单一职责原则
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    /*
     给每个方法提炼成一个接口，抽象成一种能力，然后分别写类，去实现接口，最终在Telephone类中进行调用
     */


    public interface IDial
    {
        void DialNumber(string phoneNumber);
    }

    public interface IHangUp
    {
        void HangUp(string phoneNumber);
    }

    public interface ISendMessage
    {
       void SendMessage(string message);
    }

    public interface IReceiveMessage
    {
        void ReceiveMessage(string message);
    }







}
