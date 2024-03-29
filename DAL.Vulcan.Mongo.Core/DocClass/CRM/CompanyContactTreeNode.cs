using System.Collections.Generic;

namespace DAL.Vulcan.Mongo.Core.DocClass.CRM
{
    public class CompanyContactTreeNode
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string Data { get; set; }
        public ContactRef Contact { get; set; }
        public string Position { get; set; }
        public string ExpandedIcon { get; set; } = "fa fa-folder-open";
        public string CollapsedIcon { get; set; } = "fa fa-folder";
        public List<CompanyContactTreeNode> Children { get; set; } = new List<CompanyContactTreeNode>();

    }
}