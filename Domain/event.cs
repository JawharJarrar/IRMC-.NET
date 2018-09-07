namespace hack
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("base.evenement")]
    public  class evenement
    {
        [Key]
        public int idEvent { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public float? altitude { get; set; }

        [Column(TypeName = "bit")]
        public bool approved { get; set; }

        public DateTime? debut { get; set; }

        [StringLength(255)]
        public string file { get; set; }

        public DateTime? fin { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        public float? longitude { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string resume { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public int? category_idCategory { get; set; }

        public virtual category category { get; set; }
    }
}
