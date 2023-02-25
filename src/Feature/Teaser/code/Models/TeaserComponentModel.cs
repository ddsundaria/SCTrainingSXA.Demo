using Sitecore.Data.Items;
using Sitecore.XA.Foundation.Mvc.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Feature.Teaser.Models
{
  public class TeaserComponentModel : RenderingModelBase
  {
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string Summary { get; set; }
  }
}
