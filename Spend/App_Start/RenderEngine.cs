using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spend
{
    public class RenderEngine : RazorViewEngine
    {
        private static readonly string[] newLocationOfPatrials = new[]
        {
            "~/Views/Patrial/{0}.cshtml"
        };

        public RenderEngine()
        {
            PartialViewLocationFormats = base.PartialViewLocationFormats.Union(newLocationOfPatrials).ToArray();
        }
    }
}