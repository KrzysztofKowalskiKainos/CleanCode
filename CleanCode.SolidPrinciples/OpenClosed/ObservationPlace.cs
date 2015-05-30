namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; set {
            string message;
            switch (message)
            {
                case PlaceType.Forest:
                     
                     message = "<Forest Sounds>";
                     break;
                case PlaceType.Ocean:
                     message = "bul bul bul";
                     
                     break;
            }

            }
        } }


        //    case PlaceType.Forest:
        //        ignoredSightings = new[] { "|", "@" };
        //        Console.WriteLine("<Forest Sounds>");

        //    case PlaceType.Ocean:
        //        ignoredSightings = new[] { "~" };
        //        Console.WriteLine("bul bul bul");
    }
}