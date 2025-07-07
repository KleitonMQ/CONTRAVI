namespace CONTRAVI.core.Entities
{
    public class PassengerDestination : BaseEntity
    {
        public PassengerDestination(int passengerId, string procedure, string destination, DateTime scheduledTime)
        {
            PassengerId = passengerId;
            Procedure = procedure;
            Destination = destination;
            ScheduledTime = scheduledTime;
        }

        public PassengerDestination()
        {
            
        }

        public int TripId { get; private set; }
        public int PassengerId { get; private set; }
        public Passenger Passenger { get; private set; }
        public string Procedure {  get; private set; }
        public string Destination { get; private set; }
        public DateTime ScheduledTime { get; private set; }


        public void Update(string procedure, string destination, DateTime scheuledTime)
        {
            this.Procedure = procedure;
            this.Destination = destination;
            this.ScheduledTime = scheuledTime;
        }
    }
}
