namespace Website.layouts.TagSearching
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI.WebControls;
    using SampleTagSearching;
    using SampleTagSearching.ContentType;
    using SampleTagSearching.SearchService;
    using System.Linq;


    public partial class Search : System.Web.UI.UserControl
    {
        private TagSearchService<SampleContent> _tagSearchService;

        private void Page_Load(object sender, EventArgs e)
        {
            _tagSearchService = new TagSearchService<SampleContent>(Sitecore.Context.Database.Name);
        }

        public IEnumerable<Tag> ddSearch_GetData()
        {
            return _tagSearchService.GetTags();
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void DoSearch(params string[] facets)
        {
            var results = _tagSearchService.ContentWithTag(Sitecore.Data.ID.Parse(ddSearch.SelectedValue), facets);

            if (results.Results.Any())
            {
                litTotal.Text = string.Format("Found {0} results", results.Total);
            }
            else
            {
                litTotal.Text = "No results";
            }
            rptSearchResults.DataSource = results.Results;
            rptSearchResults.DataBind();

            rptFacets.DataSource = results.Facets;
            rptFacets.DataBind();
        }

        protected void lkFacet_Click(object sender, EventArgs e)
        {
            //only filters on the facet that has just been clicked. 
            //this would need to be improved so it remembers which facets are currently turned on
            var linkbutton = sender as LinkButton;
            if (linkbutton == null) return;
            
            DoSearch(linkbutton.Text);
            
        }
    }
}