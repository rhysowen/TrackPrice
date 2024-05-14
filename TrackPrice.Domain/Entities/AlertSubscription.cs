namespace TrackPrice.Domain.Entities;

public class AlertSubscription
{
    public int Id { get; set; }
    public string Email { get; set; }
    public decimal TargetPrice { get; set; }
    public string ProductUrl { get; set; }
    public bool IsAlertSent { get; set; }
}