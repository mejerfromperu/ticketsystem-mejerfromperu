using TicketClassLibrary;

namespace RepositoryStorbeltbroen
{
    public interface IRepository
    {
        /// <summary>
        /// public metode for at tilføje tickets/vehicles til den statiske liste
        /// </summary>
        /// <param name="vehicle"></param>
        void AddTicket(Vehicle vehicle);
        /// <summary>
        /// public metode for at få fal i alle tickets/vehicles
        /// </summary>
        /// <returns>retunere en liste</returns>
        List<Vehicle> GetAll();
        /// <summary>
        /// public metode for at få fat i alle de køretøjer med den givne licensplate
        /// </summary>
        /// <param name="licensePlate">den ønskede licenseplate</param>
        /// <returns>retunere en liste med de kørertøjer</returns>
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}