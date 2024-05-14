namespace TrackPrice.Domain.Entities;

public class AlertSubscription
{
    public int Id { get; set; }
    public required string Email { get; set; }
    public decimal TargetPrice { get; set; }
    public required string ProductUrl { get; set; }
    public bool IsAlertSent { get; set; }
}