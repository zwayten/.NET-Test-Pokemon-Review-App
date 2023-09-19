namespace Domain.Models
{
    //Country may have no owner
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //public virtual ICollection<Owner>? Owners { get; set; }

        public Country()
        {
            //this.Owners = new List<Owner>();
        }
        
    }

    
}
