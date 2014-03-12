using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Converters;
using Sitecore.Data;

namespace SampleTagSearching.ContentType
{
    public interface ISitecoreResult
    {
        [IndexField("_path")]
        IEnumerable<ID> Paths { get; set; }

        [IndexField("_group"), TypeConverter(typeof(IndexFieldIDValueConverter))]
        ID ItemId { get; set; }
    }
}
