using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiveTunes.WebAPI.Models
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Display(Name = "Latitude")]
        public double Latitude { get; set; }
        [Display(Name = "Longitude")]
        public double Longitude { get; set; }
        [Display(Name = "Event Name")]
        public string EventName { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
    }
}