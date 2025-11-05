using Exception_Sealed_Practice.Services;
using Exception_Sealed_Practice.Services.Interfaces;

ITransportService transportService = new TransportService();

transportService.CreateTransport("", "", 0, "");
transportService.GetAllTransports();
