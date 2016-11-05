using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_ActiveMQ
{
    public class AQConfig
    {
        public string _AQConfigConnectString = "tcp://localhost:61616/";
        public string AQConfigConnectString
        {
            get
            {
                return _AQConfigConnectString;
            }
            set
            {
                _AQConfigConnectString = value;
            }
        }
        public string ActiveMQName { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
    }
}
