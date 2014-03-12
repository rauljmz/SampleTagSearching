using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;

namespace SampleTagSearching.ComputedFields
{
    public class SectionComputedField : IComputedIndexField
    {
        public string TemplateKey { get { return "sample content"; } }

        public object ComputeFieldValue(Sitecore.ContentSearch.IIndexable indexable)
        {
            var sitecoreIndexable = indexable as SitecoreIndexableItem;
            if (sitecoreIndexable == null || !sitecoreIndexable.Item.TemplateName.Equals(TemplateKey,StringComparison.InvariantCultureIgnoreCase)) return null;
                     
            return sitecoreIndexable.Item.Axes.SelectSingleItem("./ancestor-or-self::*[@@templatekey='folder']").Name + " content";
        }

        public string FieldName
        {
            get;
            set;
        }

        public string ReturnType
        {
            get;
            set;
        }
    }
}
