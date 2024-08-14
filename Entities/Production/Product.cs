namespace bikeStore.Entities.Production
{
  [Table("products", Schema = "production")]
  public class Product
  {
  [Key]
  [Column("product_id")]
  public int Id { get; set; }


  [Column("product_name")]
  [MaxLength(255)]
  [Required]
  public required string ProductName { get; set; }

  [Column("brand_id")]
  [Required]
  // [ForeignKey]
  public int BrandId { get; set; }

  [Column("category_id")]
  [Required]
  public required int CategoryId { get; set; }

  
  [Column("model_year")]
  [Required]
  public required short ModelYear { get; set; }


  [Column("list_price")]
  [Required]
  [Precision(10, 2)]
  public required decimal ListPrice { get; set; }

  [Column("created_at")]
  [Required]
  public DateTime CreatedAt { get; set; }

  [Column("updated_at")]
  [Required]
  public DateTime UpdatedAt { get; set; }
  }
}
