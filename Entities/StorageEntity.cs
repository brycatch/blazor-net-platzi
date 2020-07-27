using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        public int StorageId { get; set; }
        public DateTime LastUpdate { get; set; }
        public int PartialQuantity { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }
        public ICollection<InOutEntity> InOuts { get; set; }

    }
}
