namespace Rapture.Common.Models
{
    public class RaptureModel
    {
        public int Id { get; set; }

        public DateTime RaptureStartDate { get; set; }

        public DateTime RaptureEndDate { get; set; }

        public string Predictor { get; set; }

        public string Details { get; set; }

        public string WhoGotRaptured { get; set; }

        public bool MonthOnly { get; set; }

        public bool YearOnly { get; set; }
    }
}
