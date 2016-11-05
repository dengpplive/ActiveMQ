using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using System.Threading;
using Cs_ActiveMQ;

namespace ConsoleCustomer
{
    /// <summary>
    /// 消费者
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int userCount = 0;
            while (userCount < 10)
            {
                string strUser = "dengjiyuan" + new Random().Next(1, 30);
                ActiveMQHelper.SubscriberTopic(new AQConfig()
                {
                    ActiveMQName = "testaq"
                },
                strUser,
                (m) =>
                {
                    var msg = ((ITextMessage)m.IMessage);
                    Console.WriteLine(m.custom + "Receive: " + msg.Text);
                });
                Console.WriteLine("用户: " + strUser + "订阅");
                Thread.Sleep(5 * 1000);
            }
            Console.ReadLine();

        }
    }
}
