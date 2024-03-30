using CallForPapers.Domain.Enums;

namespace CallForPapers.Domain.Models;

public class Application
{
    public Guid Id { get; set; }
    public Guid Author { get; set; }
    public ActivityType ActivityType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Outline { get; set; }
    public ApplicationStatus Status { get; set; } = ApplicationStatus.Draft;
}
