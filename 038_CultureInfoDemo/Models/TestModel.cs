namespace _038_CultureInfoDemo.Models
{
    public class TestModel
    {
        public double TestDouble { get; set; }
        public DateTime TestDateTime { get; set; }

        public string? TestDoubleDisplay => TestDouble.ToString("C2");
        public string? TestDateTimeDisplay => TestDateTime.ToShortDateString() + " " + TestDateTime.ToLongTimeString();
    }
}
