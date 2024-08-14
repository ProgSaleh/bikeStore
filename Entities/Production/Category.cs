namespace bikeStore.Entities.Production
{
  [Table("categories", Schema = "production")]
  public class Category
  {
    [Key]
    [Column("category_id")]
    public int Id { get; set; }

    [Column("category_name")]
    [Required]
    [MaxLength(255)]
    public required string CategoryName { get; set; }

    [Column("created_at")]
    [Required]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    [Required]
    public DateTime UpdatedAt { get; set; }
  }
}
