namespace DADBF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class team
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? driver1 { get; set; }

        public int? driver2 { get; set; }

        public int? car1 { get; set; }

        public int? car2 { get; set; }

        public int? points { get; set; }

        public virtual car car { get; set; }

        public virtual car car3 { get; set; }

        public virtual driver driver { get; set; }

        public virtual driver driver3 { get; set; }
    }
}
