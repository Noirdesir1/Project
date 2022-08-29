using System;

namespace TollboothClient
{
    public interface ITollboothData
    {
        string HostName { get; set; }
        int HostPort { get; set; }
        IProgress<Tollbooth> Progress { get; set; }

        void Close(int TollboothId);
        void Create();
        void Get(int TollboothId);
        void NonPayingCar(int TollboothId);
        void PayingCar(int TollboothId);
        void Reset(int TollboothId);
    }
}