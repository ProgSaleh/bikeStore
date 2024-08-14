namespace bikeStore.Entities.Production
{
  [Table("products", Schema = "production")]
  public class Product
  {
	// product_id INT IDENTITY (1, 1) PRIMARY KEY,
  [Key]
  [Column("product_id")]
  public int Id { get; set; }


	// product_name VARCHAR (255) NOT NULL,
  [Column("product_name")]
  [MaxLength(255)]
  [Required]
  public required string ProductName { get; set; }

	// brand_id INT NOT NULL,
  [Column("brand_id")]
  [Required]
  // [ForeignKey]
  public int BrandId { get; set; }

	// category_id INT NOT NULL,
  [Column("category_id")]
  [Required]
  public required int CategoryId { get; set; }

  
	// model_year SMALLINT NOT NULL,
  [Column("model_year")]
  [Required]
  public required short ModelYear { get; set; }


	// list_price DECIMAL (10, 2) NOT NULL,
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
