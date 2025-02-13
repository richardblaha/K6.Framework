namespace K6.UI.Theming;

public static class Themes
{
    public static Theme Bootstrap { get; } = new(nameof(Bootstrap), [], ["_content/K6.UI/default.css"]);
    public static Theme K6 { get; } = new(nameof(Bootstrap), [], ["_content/K6.UI/k6.css"]);
    public static Theme FastBootstrap { get; } = new(nameof(FastBootstrap), [], ["_content/K6.UI/fastbootstrap.css"]);
    public static Theme Flatly { get; } = new(nameof(Flatly), [], ["_content/K6.UI/flatly.css"]);
    public static Theme Lumen { get; } = new(nameof(Lumen), [], ["_content/K6.UI/lumen.css"]);
    public static Theme Materia { get; } = new(nameof(Materia), [], ["_content/K6.UI/materia.css"]);
    public static Theme Minty { get; } = new(nameof(Minty), [], ["_content/K6.UI/minty.css"]);
    public static Theme Quartz { get; } = new(nameof(Quartz), [], ["_content/K6.UI/quartz.css"]);
    public static Theme Sketchy { get; } = new(nameof(Sketchy), [], ["_content/K6.UI/sketchy.css"]);
    public static Theme United { get; } = new(nameof(United), [], ["_content/K6.UI/united.css"]);

    public static IDictionary<string, Theme> All = new Dictionary<string, Theme>()
    {
        [nameof(Bootstrap)] = Bootstrap,
        [nameof(K6)] = K6,
        [nameof(FastBootstrap)] = FastBootstrap,
        [nameof(Flatly)] = Flatly,
        [nameof(Lumen)] = Lumen,
        [nameof(Materia)] = Materia,
        [nameof(Minty)] = Minty,
        [nameof(Quartz)] = Quartz,
        [nameof(Sketchy)] = Sketchy,
        [nameof(United)] = United
    };
}