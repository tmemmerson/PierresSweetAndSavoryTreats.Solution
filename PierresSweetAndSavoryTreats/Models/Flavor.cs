using System.Collections.Generic;

namespace PierresSweetAndSavoryTreats.Models
{
  public class Flavor
    {
        public Flavor()
        {
            this.Items = new HashSet<FlavorItem>();
        }

        public int FlavorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FlavorItem> Items { get; set; }
    }
}