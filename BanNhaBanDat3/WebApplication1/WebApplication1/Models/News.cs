namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(100)]
        public string Header { get; set; }

        [StringLength(100)]
        public string Alias { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? CateId { get; set; }

        public virtual Category Category { get; set; }
    }
}
