using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ContentSearch.Linq;
using Sitecore.Data;

namespace SampleTagSearching.ContentType
{
    public class CustomSearchResults<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Results { get; set; }

        public IEnumerable<Facet> Facets { get; set; }


        public CustomSearchResults(SearchResults<T> results)
        {
            Total = results.TotalSearchResults;
            Results = results.Hits.Select(h => h.Document).ToList();
            Facets = results.Facets.Categories[0].Values               
                .Select(fv => new Facet() { Count = fv.AggregateCount, Value =  fv.Name})
                .ToList();
        }

        public CustomSearchResults<T> ToggleFacets(string[] facets)
        {
            foreach (var facet in Facets)
            {
                facet.Enabled = facets.Contains(facet.Value) ? "selected" : "";
            }

            return this;
        }
    }
}
