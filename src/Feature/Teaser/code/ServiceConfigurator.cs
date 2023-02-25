using Feature.Teaser.Controllers;
using Feature.Teaser.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Feature.Teaser
{
  public class ServiceConfigurator : IServicesConfigurator
  {
    public void Configure(IServiceCollection serviceCollection)
    {
      serviceCollection.AddTransient<ITeaserComponentRepository, TeaserComponentRepository>();
      serviceCollection.AddTransient<TeaserComponentController>();
    }
  }
}
