using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Converters;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data;

namespace SampleTagSearching.ContentType
{
    public class Tag : ISitecoreResult
    {
        public string Name { get; set; }

        [TypeConverter(typeof(IndexFieldIDValueConverter)), IndexField("_group")]
        public ID ItemId { get; set; }

        [TypeConverter(typeof(IndexFieldEnumerableConverter)), IndexField("_path")]
        public IEnumerable<ID> Paths { get; set; }
    }
}
