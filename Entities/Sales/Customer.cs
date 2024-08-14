
//  TODO: add navigation props after building all data models.
namespace bikeStore.Entities.Sales
{
  [Table("customers", Schema = "sales")]
  public class Customer
  {
    [Key]
    [Column("customer_id")]
    public int Id { get; set; }

    [Column("first_name")]
    [MaxLength(255)]
    [Required]
    public required string FirstName { get; set; }

    [Column("last_name")]
    [MaxLength(255)]
    [Required]
    public required string LastName { get; set; }

    [Column("phone")]
    [MaxLength(25)]
    public string? Phone { get; set; }

    [Column("email")]
    [MaxLength(255)]
    [Required]
    public required string Email { get; set; }

    [Column("street")]
    [MaxLength(255)]
    public string? Street { get; set; }

    [Column("city")]
    [MaxLength(50)]
    public string? City { get; set; }

    [Column("state")]
    [MaxLength(25)]
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
  }
}
