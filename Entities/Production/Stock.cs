using bikeStore.Entities.Sales;

namespace bikeStore.Entities.Production
{
  [Table("stocks", Schema = "production")]
  public class Stock
  {
  [Column("store_id")]
  public int StoreId { get; set; }

  public required Store Store { get; set; }

  [Column("product_id")]
  public int ProductId { get; set; }

  public Product? Product { get; set; }

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
