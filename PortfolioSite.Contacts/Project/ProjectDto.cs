namespace PortfiloSite.Contacts.Project;

public class ProjectDto
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public string? ShortDescription { get; set;}
    public string? Description {get; set;}
    public string? Url { get; set; }
    public bool IsFinished { get; set; } = false;
}
