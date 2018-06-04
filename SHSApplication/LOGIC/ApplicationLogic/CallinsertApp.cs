using DATALAYER.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.ApplicationLogic
{
    public class CallinsertApp
    {
        public bool CallInsert(string receiver, string sender, string duration, DateTime log)
        {
            Messaging messaging = new Messaging
            {
               
                Sender = sender,
                Receiver = receiver,
                Log = log,
                Msg = duration
            };
            BusinessLogic.CallInsertProcess callInsertProcess = new BusinessLogic.CallInsertProcess();
            callInsertProcess.InsertMessaging(messaging);
            return true;
        }
    }
}
