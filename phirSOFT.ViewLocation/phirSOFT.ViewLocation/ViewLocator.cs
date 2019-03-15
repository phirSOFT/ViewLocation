using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace phirSOFT.ViewLocation
{
    public class ViewLocator : IViewLocator
    {
        private readonly Dictionary<Type, Type> _viewMappings = new Dictionary<Type, Type>();

        public void RegisterViewForModel(Type viewType, Type modelType)
        {
            _viewMappings.Add(viewType, modelType);
        }

        public object ResolveView(object targetModel)
        {
            var targetModelType = targetModel.GetType();
            var currentAncestor = targetModelType;
            Type viewType;

            while (!_viewMappings.TryGetValue(currentAncestor, out viewType))
            {
                currentAncestor = currentAncestor.BaseType;
                if(currentAncestor == typeof(object))
                    break;
            }

            if(viewType == null)
            {
                foreach (var item in collection)
                {

                }
            }

            return ServiceLocator.Current.GetInstance(viewType);
        }
    }
}
