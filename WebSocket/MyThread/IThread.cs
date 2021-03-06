﻿namespace WebSocket.MyThread
{
    public interface IThread
    {
        void Run();
        bool IsRunning { get; }

        void Stop();
        void Stop(bool forceStop);
        void Start();
    }
}
