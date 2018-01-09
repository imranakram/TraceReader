using System;
using System.Collections.Generic;

namespace CrmTraceReader
{
    public class OrganizationData
    {
        public OrganizationData()
        {
            Users = new Dictionary<Guid, string>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Dictionary<Guid, string> Users { get; set; }
    }
}
