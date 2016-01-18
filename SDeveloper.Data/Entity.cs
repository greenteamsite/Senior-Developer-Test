using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SDeveloper.Data
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        [Index]
        [MaxLength(100)]
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
