namespace DADBF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tournament")]
    public partial class tournament
    {
        public int id { get; set; }

        public int race { get; set; }

        public int result { get; set; }

        public int season { get; set; }

        public virtual race race1 { get; set; }

        public virtual result result1 { get; set; }
    }
}
