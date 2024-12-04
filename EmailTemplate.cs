using System;
using System.Collections.Generic;

namespace LastCShapSession
{
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? EmailBody { get; set; }
    }
}
