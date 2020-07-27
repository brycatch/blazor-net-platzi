using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InOutEntity
    {
        [Key]
        public int InOutId { get; set; }

        public DateTime InOutDate { get; set; }

        public int Quantity { get; set; }

        public bool IsInput { get; set; }

        public int StorageId { get; set; }
    }
}
