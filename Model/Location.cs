namespace dawns_shop.Model
{
  public class Location
  {
    public int Id { get; set; }
    public string Address { get; set; }
    public string ManagerName { get; set; }
    public string PhoneNumber { get; set; }

    public int ItemId { get; set; }

    public Location item { get; set; }
  }
}

