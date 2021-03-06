﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiInitializer.cs" company="Sitecore A/S">
//   Copyright (C) 2014 by Sitecore A/S
// </copyright>
// <summary>
//   Defines the WebApiInitializer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.MediaFramework.Pipelines.Initialize
{
  using System.Web.Http;
  using Sitecore.Pipelines;

  public class WebApiInitializer
  {
    public void Process(PipelineArgs args)
    {
      GlobalConfiguration.Configure(Configure);
    }

    protected void Configure(HttpConfiguration configuration)
    {
      var routes = configuration.Routes;
      routes.MapHttpRoute(
        "Reports",
        "sitecore/api/mediaframework/reports/{datasource}/{sitename}",
        new
          {
            controller = "Reports",
            action = "Get"
          });
    }
  }
}