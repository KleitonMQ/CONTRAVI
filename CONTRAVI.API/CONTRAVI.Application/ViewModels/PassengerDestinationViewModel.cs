
namespace CONTRAVI.Application.ViewModels
{
    public class PassengerDestinationViewModel
    {
        public int Id { get; set; }
        public string Procedure { get; set; }
        public string Destination { get; set; }
        public DateTime ScheduledTime { get; set; }

        public PassengerDestinationViewModel(int id, string procedure, string destination, DateTime scheduledTime)
        {
            Id = id;
            Procedure = procedure;
            Destination = destination;
            ScheduledTime = scheduledTime;
        }
    }
}
