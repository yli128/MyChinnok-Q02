using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
    #endregion
namespace ChinookSystem.data.Entities
{
          [Table("Artists")]
    public class Artists
    {
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set;}

        public virtual ICollection<Album> Albums { get; set; }
    }

}
