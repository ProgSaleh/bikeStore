namespace bikeStore.Entities.Sales
{
  [Table("order_items", Schema = "sales")]
  public class OrderItem
  {
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("item_id")]
    public int ItemId { get; set; }

    [Column("product_id")]
    [Required]
    public required int ProductId { get; set; }

    [Column("quantity")]
    [Required]
    public required int Quantity { get; set; }
    
    [Column("list_price")]
    [Required]
    [Precision(10, 2)]
    public required decimal ListPrice { get; set; }

    [Column("discount")]
    public decimal Discount { get; set; } = 0;

    [Column("created_at")]
    [Required]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    [Required]
    public DateTime UpdatedAt { get; set; }
  }
}
