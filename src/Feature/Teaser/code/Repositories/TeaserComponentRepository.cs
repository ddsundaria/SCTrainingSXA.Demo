using Feature.Teaser.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;

namespace Feature.Teaser.Repositories
{
  public class TeaserComponentRepository : ModelRepository, ITeaserComponentRepository
  {
    public override IRenderingModelBase GetModel()
    {
      // custom model generation method
      TeaserComponentModel model = new TeaserComponentModel();

      FillBaseProperties(model);

      model.Title = Rendering.DataSourceItem["Title"];
      model.SubTitle = Rendering.DataSourceItem["SubTitle"];
      model.Summary = Rendering.DataSourceItem["Summary"];

      return model;
    }
  }
}
