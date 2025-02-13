namespace K6.UI.Theming;

public class Theme(string name, IList<string> scripts, IList<string> styles)
{
    public string Name { get; } = name;
    public IList<string> Scripts { get; } = scripts;
    public IList<string> Styles { get; } = styles;
}