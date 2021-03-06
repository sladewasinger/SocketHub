﻿namespace HubSockets
{
    public class Hub : IHub
    {
        public HubSocketClients Clients { get; set; }
        public HubSocketContext Context { get; set; }

        public Hub() { }

        public virtual void OnConnectedAsync() {
        }

        public virtual void OnDisconnectedAsync() { }
    }
}
