using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleTagSearching.ContentType;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.Data;

namespace SampleTagSearching.SearchService
{
    public class TagSearchService<T> where T:ITagging,new()
    {
        private string _indexname;
        public TagSearchService(string databasename)
        {         
            _indexname = string.Format("sitecore_{0}_index",databasename);
        }

        public CustomSearchResults<T> ContentWithTag(ID tag, params string[] facets)
        {
            var index = ContentSearchManager.GetIndex(_indexname);

            using (var context = index.CreateSearchContext())
            {
                var results = context.GetQueryable<T>()
                    .Where(sc => sc.Tagging.Contains(tag))
                    .Where(sc => sc.Paths.Contains(ID.Parse("{110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9}"))) // only content underneath HOME item. Discard Standard Values
                    .FacetOn(sc=> sc.Section);
                foreach (var facet in facets)
                {
                    results = results.Filter(sc => sc.Section == facet);
                }
                    
                return new CustomSearchResults<T>(results.GetResults()).ToggleFacets(facets);
            }            
        }

        public IEnumerable<Tag> GetTags()
        {
             var index = ContentSearchManager.GetIndex(_indexname);

            using (var context = index.CreateSearchContext())
            {
                return context.GetQueryable<Tag>()
                    .Where(sc => sc.Paths.Contains(ID.Parse("{AC8F7637-37E9-4A64-9D59-83738867A477}")))                    
                    .ToList();                
            }                       
        }
    }
}
