using System.Collections.Generic;

namespace HFSclient.Models
{
  public class League 
  {
    public League() 
    {
      this.Groups = new HashSet<Group>();
    }
    public int LeagueId { get; set; }
    public string LeagueName { get; set; }
    public int CurrentSeason { get; set; }
    public int CurrentWeek { get; set; }
    public virtual ICollection<Group> Groups { get; }  
  }
}