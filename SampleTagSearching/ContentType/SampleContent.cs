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
    public class SampleContent : SearchResultItem, ITagging
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IEnumerable<ID> Tagging { get; set; }        
    }
}
