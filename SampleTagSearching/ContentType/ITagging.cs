using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.ContentSearch;
using Sitecore.Data;

namespace SampleTagSearching.ContentType
{
    public interface ITagging : ISitecoreResult
    {
        IEnumerable<ID> Tagging { get; set; }

        [IndexField("_section")]
        string Section { get; set; }
    }
}
