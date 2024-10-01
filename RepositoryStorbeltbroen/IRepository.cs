using TicketClassLibrary;

namespace RepositoryStorbeltbroen
{
    public interface IRepository
    {
        void AddTicket(Vehicle vehicle);
        List<Vehicle> GetAll();
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}