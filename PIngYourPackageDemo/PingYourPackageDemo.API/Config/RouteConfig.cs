﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing.Constraints;

namespace PingYourPackageDemo.API.Config
{
    public class RouteConfig
    {
        public static void RegisterRoutes(HttpConfiguration config)
        {

            var routes = config.Routes;

            // Pipelines
            //HttpMessageHandler affiliateShipmentsPipeline =
            //    HttpClientFactory.CreatePipeline(
            //        new HttpControllerDispatcher(config),
            //        new[] { new AffiliateShipmentsDispatcher() });

            //HttpMessageHandler shipmentStatesPipeline =
            //    HttpClientFactory.CreatePipeline(
            //        new HttpControllerDispatcher(config),
            //        new[] { new ShipmentStatesDispatcher() });

            // Routes
            //routes.MapHttpRoute(
            //    "AffiliateShipmentsHttpRoute",
            //    "api/affiliates/{key}/shipments/{shipmentKey}",
            //    defaults: new { controller = "AffiliateShipments", shipmentKey = RouteParameter.Optional },
            //    constraints: new { key = new GuidRouteConstraint(), shipmentKey = new GuidRouteConstraint() },
            //    handler: affiliateShipmentsPipeline);

            //routes.MapHttpRoute(
            //    "ShipmentStatesHttpRoute",
            //    "api/shipments/{key}/shipmentstates",
            //    defaults: new { controller = "ShipmentStates" },
            //    constraints: new { key = new GuidRouteConstraint() },
            //    handler: shipmentStatesPipeline);

            routes.MapHttpRoute(
                "DefaultHttpRoute",
                "api/{controller}/{key}",
                defaults: new { key = RouteParameter.Optional },
                constraints: new { key = new GuidRouteConstraint() });
        }
        }
}
