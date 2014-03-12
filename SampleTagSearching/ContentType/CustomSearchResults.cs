using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ContentSearch.Linq;

namespace SampleTagSearching.ContentType
{
    public class CustomSearchResults<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Results { get; set; }

        public CustomSearchResults(SearchResults<T> results)
        {
            Total = results.TotalSearchResults;
            Results = results.Hits.Select(h => h.Document).ToList();
        }
    }
}
