using Microsoft.AspNetCore.Mvc;
using System;

namespace Solution.CrossCutting.AspNetCore
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class RouteControllerAttribute : RouteAttribute
    {
        public RouteControllerAttribute() : base("[controller]")
        {
        }
    }
}
