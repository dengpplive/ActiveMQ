using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apache.NMS.ActiveMQ;
using Apache.NMS;
using Cs_ActiveMQ;

namespace ConsoleProcucer
{
    /// <summary>
    /// 生产者
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("命令：");
            Console.WriteLine("1. cancel 用户1 用户2   ");
            Console.WriteLine("2. exit     ");
            Console.WriteLine("3. >内容     ");
            Console.WriteLine("请输入发送的消息内容:");
            while (true)
            {
                string textMsg = Console.ReadLine();
                if (textMsg.StartsWith(">"))
                {
                    ActiveMQHelper.SendTopicMessage(new AQConfig()
                    {
                        ActiveMQName = "testaq"
                    }, textMsg.TrimStart('>'));
                }
                else
                {
                    string[] strArr = textMsg.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    switch (strArr[0].ToLower())
                    {
                        case "exit":
                            break;

                        case "cancel":
                            if (strArr.Length > 1)
                            {
                                for (int i = 1; i < strArr.Length; i++)
                                {
                                    ActiveMQHelper.CancelSubscriberTopic(strArr[i], (m) =>
                                    {
                                        Console.WriteLine(m.custom + "已取消订阅");
                                    });
                                }
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
