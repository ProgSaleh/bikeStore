namespace bikeStore.Entities.Production
{
  [Table("brands", Schema = "production")]
  public class Brand
  {
      [Key]
      [Column("brand_id")]
      public int Id { get; set; }

      [Column("brand_name")]
      [MaxLength(255)]
      [Required]
      public required string BrandName { get; set; }

      [Column("created_at")]
      [Required]
      public DateTime CreatedAt { get; set; }

      [Column("updated_at")]
      [Required]
      public DateTime UpdatedAt { get; set; }

      public ICollection<Product>? Products { get; set; }
  }
}
