namespace CONTRAVI.core.Entities
{
    public class RoadMap : BaseEntity
    {
        public RoadMap(string departure, string destination, string arrival) 
        { 
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
        }

        public RoadMap(string departure, string destination, string arrival, int roadMapOrigemId)
        {
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
            RoadMapOrigemId = roadMapOrigemId;
        }

        public RoadMap() { }
        public string Departure {  get; private set; }
        public string Destination { get; private set; }
        public string Arrival { get; private set; }
        public int? RoadMapOrigemId { get; private set; }

        public void Update(string departure, string destination, string arrival)
        {
            Departure = departure;
            Destination = destination;
            Arrival = arrival;
        }
    }
}
