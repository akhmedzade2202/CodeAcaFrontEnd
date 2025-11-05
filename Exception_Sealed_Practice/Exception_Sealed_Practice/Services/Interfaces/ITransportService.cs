namespace Exception_Sealed_Practice.Services.Interfaces
{
    internal interface ITransportService
    {
        void CreateTransport(string model, string brand, int year, string title);
        void GetAllTransports();
    }
}
