using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public ICollection<StorageEntity> StorageEntities { get; set; }
    }
}
