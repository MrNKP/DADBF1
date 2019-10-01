namespace DADBF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("season")]
    public partial class season
    {
        public int id { get; set; }

        public int? tournamentId { get; set; }

        public virtual tournament tournament { get; set; }
    }
}
