
//  TODO: add navigation props after building all data models.
namespace bikeStore.Entities.Sales
{
  /*
    The first value passed to the Table is by default the same name of the class but pluralized.
    So in this case it's redundent; I had to add it so I can specify the schema of this table.
  */
  [Table("staffs", Schema = "sales")]
  public class Staff
  {
    [Key]
    [Column("staff_id")]
    public int Id { get; set; }

    [Column("first_name")]
    [MaxLength(50)]
    [Required]
    public required string FirstName { get; set; }

    [Column("last_name")]
    [MaxLength(50)]
    [Required]
    public required string LastName { get; set; }

    [Column("email")]
    [MaxLength(255)]
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Column("phone")]
    [MaxLength(25)]
    [Required]
    public required string Phone { get; set; }

    [Column("active")]
    [Required]
    public required byte Active { get; set; }

    [Column("store_id")]
    [Required]
    // [ForeignKey("StoreId")]
    public required int StoreId { get; set; }

    [Column("manager_id")]
    // [ForeignKey("ManagerId")]
    public int ManagerId { get; set; }

    [Column("created_at")]
    [Required]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    [Required]
    public DateTime UpdatedAt { get; set; }
  }
}
