using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    public class CultureRouteModelConvention : IPageRouteModelConvention
    {
        public string RouteDataStringKey { get; init; } = "culture";
        public void Apply(PageRouteModel model)
        {
            foreach (var selector in model.Selectors)
            {
                selector.AttributeRouteModel.Template = AttributeRouteModel.CombineTemplates($"{{{RouteDataStringKey}?}}", selector.AttributeRouteModel.Template);
                //var selectorToAdd = new SelectorModel()
                //{
                //    AttributeRouteModel = new AttributeRouteModel
                //    {
                //        Template = ,
                //        Order = -10,
                //    }
                //};
                //model.Selectors.Add(selectorToAdd);
            }
        }
    }
}
