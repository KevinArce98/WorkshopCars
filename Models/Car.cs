using System;
using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
    public class Car
    {
        public int Id { get; set; }
        public virtual Make Make { get; set; }
        public int  MakeId { get; set; }
        
        public string Model { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }
        public int Cylinders { get; set; }
        
        public Car()
        {
            
        }
        
        
    }
}
