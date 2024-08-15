
namespace bikeStore.Entities.Sales
{
  /*
    The first value passed to the Table is by default the same name of the class but pluralized.
    So in this case it's redundent; I had to add it so I can specify the schema of this table.
  */
  [Table("stores", Schema = "sales")]
  public class Store
  {
    [Key]
    [Column("store_id")]
    public int Id { get; set; }

    [Required]
    [Column("store_name")]
    [MaxLength(255)]
    public required string StoreName { get; set; }
    
    [Column("phone")]
    [MaxLength(25)]
    public string? Phone { get; set; }

    [Column("email")]
    [MaxLength(255)]
    [EmailAddress]
    public string? Email { get; set; }

    [Column("street")]
    [MaxLength(255)]
    public string? Street { get; set; }

    [Column("city")]
    [MaxLength(255)]
    public string? City { get; set; }

    [Column("state")]
    [MaxLength(10)]
    public string? State { get; set; }

    [Column("zip_code")]
    [MaxLength(5)]
    public string? ZipCode { get; set; }

    [Column("created_at")]
    [Required]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    [Required]
    public DateTime UpdatedAt { get; set; }

    public ICollection<Order>? Orders { get; set; }
  }
}
