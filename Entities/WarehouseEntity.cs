using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        public int WarehouseId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<StorageEntity> StorageEntities { get; set; }
    }
}
