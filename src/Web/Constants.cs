namespace Microsoft.eShopWeb.Web; // Defines the namespace for the web application code.

public static class Constants // Declares a static class that stores shared application configuration values.
{
    public const string BASKET_COOKIENAME = "eShop"; // The name of the cookie used to store the user's shopping basket.
    public const int ITEMS_PER_PAGE = 10; // The default number of catalog items to display on each page.
    public const string DEFAULT_USERNAME = "Guest"; // The fallback username used when the user is not signed in.
    public const string BASKET_ID = "BasketId"; // The key used to identify the basket in session or request data.
}
