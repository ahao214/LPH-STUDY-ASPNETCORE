using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_单一职责原则
{
    public class Telephton
    {
        private IDial _idial;
        private IHangUp _ihangUp;
        private ISendMessage _isendMessage;
        private IReceiveMessage _ireceiveMessage;


        public Telephton(IDial dial, IHangUp handUp, ISendMessage sendMessage, IReceiveMessage receiveMessage)
        {
            _idial = dial;
            _ihangUp = handUp;
            _isendMessage = sendMessage;
            _ireceiveMessage = receiveMessage;
        }

        public void DialPhoneNumber(string phoneNumber)
        {
            _idial.DialNumber(phoneNumber);
        }

        public void HangUpNumber(string phoneNumber)
        {
            _ihangUp.HangUp(phoneNumber);
        }

        public void SendMessge(string msg)
        {
            _isendMessage.SendMessage(msg);
        }

        public void ReceiveMessage(string msg)
        {
            _ireceiveMessage.ReceiveMessage(msg);
        }





    }
}
