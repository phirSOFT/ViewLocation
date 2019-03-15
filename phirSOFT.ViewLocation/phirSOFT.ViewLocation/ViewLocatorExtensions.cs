using System;
using System.Collections.Generic;
using System.Text;

namespace phirSOFT.ViewLocation
{
    public static class ViewLocatorExtensions
    {
        public static void RegisterViewForModel<TView, TModel>(this IViewLocator viewLocator)
        {
            viewLocator.RegisterViewForModel(typeof(TView), typeof(TModel));
        }
    }
}
