using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiscp.Core.Models
{
    public class ReceiverResponse
    {
        public ReceiverInfo ReceiverInfo { get; private set; }
        public byte[] Message { get; private set; }

        public ReceiverResponse(ReceiverInfo receiverInfo, byte[] message) 
        {
            this.ReceiverInfo = receiverInfo;
            this.Message = message;
        }
    }
}