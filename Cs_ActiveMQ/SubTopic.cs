using Apache.NMS;
using Apache.NMS.ActiveMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_ActiveMQ
{
    public class SubTopic
    {
        public ConnectionFactory ConnectionFactory { get; set; }
        public IConnection connection { get; set; }
        public ISession session { get; set; }
    }
}
