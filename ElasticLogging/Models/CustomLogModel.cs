namespace ElasticLogging.Models;

public class CustomLogModel
{
    public string Level { get; set; }
    public string Message { get; set; }
    public string UserId { get; set; }
    public DateTime Timestamp { get; set; }
}