using Feature.Teaser.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;

namespace Feature.Teaser.Controllers
{
  public class TeaserComponentController : StandardController 
  {
    private readonly ITeaserComponentRepository _teaserComponentRepository;

    public TeaserComponentController(ITeaserComponentRepository teaserComponentRepository)
    {
      _teaserComponentRepository = teaserComponentRepository;
    }

    protected override object GetModel()
    {
      return _teaserComponentRepository.GetModel();
    }
  }
}
