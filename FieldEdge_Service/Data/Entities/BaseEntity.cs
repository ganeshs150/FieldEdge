using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int is_active { get; set; }
        public int? created_by { get; set; }
        public DateTime? created_at { get; set; }
        public int? updated_by { get; set; }
        public DateTime? updated_at { get; set; }
    }
}
