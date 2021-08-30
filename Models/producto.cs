using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laboratorio_PC01.Models{
  [Table("t_producto")]
   public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("nombre")]
        public string nombre { get; set; }
        [Column("categoria")]
        public string categoria { get; set; }
        [Column("precio")]
        public string precio {get; set;}
        [Column("descuento")]
        public double descuento {get; set; }     


    }
}