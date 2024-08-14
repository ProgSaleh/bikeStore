namespace bikeStore.Entities.Production
{
  [Table("stocks", Schema = "production")]
  public class Stock
  {
	// store_id INT,
  [Column("store_id")]
  public int StoreId { get; set; }

	// product_id INT,
  [Column("product_id")]
  public int ProductId { get; set; }

	// quantity INT,
  [Column("quantity")]
  public int Quantity { get; set; }

  [Column("created_at")]
  [Required]
  public DateTime CreatedAt { get; set; }

  [Column("updated_at")]
  [Required]
  public DateTime UpdatedAt { get; set; }
  }
}
