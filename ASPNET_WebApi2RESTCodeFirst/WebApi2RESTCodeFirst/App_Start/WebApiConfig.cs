using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi2RESTCodeFirst
{

    /*
        Routing in ASP.NET Web API

        Web API uses routing to match uniform resource identifiers (URIs) to various actions. 
        The WebApiConfig file, located inside the App_Start node in Solution Explorer, defines 
        the default routing mechanism used by Web API. The mechanism is based on a combination 
        of HTTP method, action, and attribute. However, we can define our own routing mechanism 
        to support meaningful URIs. 

        The default route template begins with the keyword "api" so as to avoid any conflicts with MVC routing.

        Understanding how routing works in Asp.Net Web API 

        When the Web API receives an Http request, it tries to first match with the default route template i.e 
        "api/{controller}/{id}". If there is no match then it returns a 404 not found error.

        Once the request is matched:

        The request is forwarded to the Controller defined in the request. Let's say we have a request for 
        "api/products" then the "ProductsController" is invoked.
        To find the action WebAPI looks for the requested method and then looks for the action whose name begins 
        with the HttpMethod name.
        Say for example: For a GET request "api/products", web API looks for an action starting with Get Http verb 
        like GetProducts(). The same applies for all verbs POST, PUT and DELETE.
        For the other placeholder {id} these are mapped to actions parameter.
        Like for a requested url "api/products/1" this is mapped to action method GetProductById(int id)
    */

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
