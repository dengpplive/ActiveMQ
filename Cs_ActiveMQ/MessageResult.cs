using Apache.NMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_ActiveMQ
{
    public class MessageResult
    {
        public object custom { get; set; }
        public IMessage IMessage { get; set; }
    }
}
