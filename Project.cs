public class Project
{
    public string Title = "", Description = "";
    public bool isShown = false;

    public Project(string title)
    {
        Title = title;
    }

    public Project(string title, string desc)
    {
        Title = title;
        Description = desc;
    }

    public Project(string title, string desc, bool show)
    {
        Title = title;
        Description = desc;
        isShown = show;
    }
}
