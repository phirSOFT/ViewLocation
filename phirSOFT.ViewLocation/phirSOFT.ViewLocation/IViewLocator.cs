using System;

namespace phirSOFT.ViewLocation
{
    public interface IViewLocator
    {
        object ResolveView(object targetModel);

        void RegisterViewForModel(Type viewType, Type modelType);
    }
}
