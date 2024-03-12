public class Project
{
    public string Title = "", Description = "";
    public string Link = "";
    public bool isShown = false;

    public Project(string title)
    {
        Title = title;
    }

    public Project(string title, string desc, bool show)
    {
        Title = title;
        Description = desc;
        isShown = show;
    }

    public Project(string title, string link)
    {
        Title = title;
        Link = link;
    }
}
