namespace IFrameWithTimer.Models
{
	public class TimerLinks
	{
        public int Id { get; set; }
        public List<string> Urls { get; set; } = new List<string>();
        public int Duration { get; set; }
    }
}
