using FactorioCalculator.Pages;

namespace FactorioCalculator.Services;

public class PageManager
{
    // singleton
    private static PageManager _instance;
    public static PageManager Instance => _instance ??= new PageManager();
    private PageManager() { }

    private Home CurrentPage { get; set; }

    public void SetCurrentPage(Home page)
    {
        CurrentPage = page;
    }

    public void RefreshCurrentPage()
    {
        CurrentPage.Refresh();
    }
}