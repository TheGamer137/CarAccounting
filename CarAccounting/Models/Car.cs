using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarAccounting.Models
{
    public class Car
    {
        
        [DisplayName("Идентификатор машины")]
        public int CarId { get; set; }

        [DisplayName("Марка машины")]
        [Required(ErrorMessage = "Введите марку машины")]
        public string CarMark { get; set; }

        [DisplayName("Модель машины")]
        [Required(ErrorMessage = "Введите модель машины")]
        public string CarModel { get; set; }

        [DisplayName("Государственный номер машины")]
        [Required(ErrorMessage = "Введите государственный номер машины")]
        public string CarNumberPlate { get; set; }

        [DisplayName("Дата проведенных работ")]
        public string DateOfWork { get; set; }

        [DisplayName("Тип двигателя")]
        public string EngineId { get; set; }
        //public EngineType EngineType { get; set; }

        [DisplayName("Тип проведенных работ")]
        public string ServicesId { get; set; }
        //public Service Services { get; set; }

    }
}
