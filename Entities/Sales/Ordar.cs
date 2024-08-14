using bikeStore.Enums;

namespace bikeStore.Entities.Sales
{
  [Table("orders", Schema = "sales")]
  public class Order
  {
    
  [Key]
  [Column("order_id")]
  public int Id { get; set; }

  [Column("customer_id")]
  // [ForeignKey("CustomerId")]
  public int CustomerId { get; set; }

  [Column("order_status")]
  [Required]
  public required OrderState OrderState { get; set; }

  [Column("order_date")]
  [Required]
  public required DateTime OrderDate { get; set; }

  [Column("required_date")]
  [Required]
  public required DateTime RequiredDate { get; set; }

  [Column("shipped_date")]
  public DateTime? ShippedDate { get; set; }

  [Column("store_id")]
  [Required]
  // [ForeignKey("StoreId")]
  public required int StoreId { get; set; }

  [Column("staff_id")]
  [Required]
  // [ForeignKey("StaffId")]
  public required int StaffId { get; set; }

  [Column("created_at")]
  [Required]
  public DateTime CreatedAt { get; set; }

  [Column("updated_at")]
  [Required]
  public DateTime UpdatedAt { get; set; }
  }
}
