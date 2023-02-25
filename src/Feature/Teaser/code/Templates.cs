using Sitecore.Data;

namespace Feature.Teaser
{
  public struct Templates
  {
    public struct Teaser
    {
      public struct Fields
      {
        public static ID Title { get; } = new ID("{A060B0A8-B9C5-474D-AD8E-A11CEBB60477}");
        public static ID SubTitle { get; } = new ID("{BC36B10E-C874-4E44-8261-5AB7F2061D4D}");
        public static ID Summary { get; } = new ID("{C2AE4DF0-CDEE-4BF3-93FC-E9F1BC31B55C}");

      }
    }
  }
}