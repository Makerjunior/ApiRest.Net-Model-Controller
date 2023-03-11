namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Endress { get; set; }
    public string? Status { get; set; }
  
    public bool IsComplete { get; set; }
}