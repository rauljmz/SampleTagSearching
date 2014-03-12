using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;

namespace SampleTagSearching.ContentType
{
    public interface ITagging : ISitecoreResult
    {
        IEnumerable<ID> Tagging { get; set; }
    }
}
