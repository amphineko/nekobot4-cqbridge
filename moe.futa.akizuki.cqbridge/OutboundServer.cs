﻿using System;
using moe.futa.akizuki.cqbridge.Messages;
using ZeroMQ;

namespace moe.futa.akizuki.cqbridge
{
    internal class OutboundServer : Server
    {
        public OutboundServer(String endpoint) : base(ZSocketType.PUB, endpoint)
        {
        }

        public void PushGroupMessage(GroupMessage message)
        {
            SendTopicMessage("message", message.ToJsonString());
        }

        public void PushPrivateMessage(PrivateMessage message)
        {
            SendTopicMessage("message", message.ToJsonString());
        }
    }
}