using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ContentSearch.Pipelines.TranslateQuery
{
    using Sitecore.ContentSearch.Pipelines.TranslateQuery;
    using Sitecore.ContentSearch.Utilities;
    using System;
    using System.Linq;

    public class TrimmingSearchQuery : TranslateQueryProcessor
    {
        public override void Process(TranslateQueryArgs args)
        {
            if ((args != null) && (args.SearchStringModel != null))
            {
                for (int i = 0; i < args.SearchStringModel.Count<SearchStringModel>(); i++)
                {
                    if (args.SearchStringModel.ElementAt<SearchStringModel>(i).Type.StartsWith(" _"))
                    {
                        args.SearchStringModel.ElementAt<SearchStringModel>(i).Type = args.SearchStringModel.ElementAt<SearchStringModel>(i).Type.Trim();
                    }
                }
            }
        }
    }
}
