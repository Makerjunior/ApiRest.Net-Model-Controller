namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Emdress { get; set; }
    public bool IsComplete { get; set; }
}