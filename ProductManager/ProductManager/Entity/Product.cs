using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManager.Entity;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string HostName { get; set; }
    public string HostPhoneNumber { get; set; }
    public string Build { get; set; }
    public string CertificateOfLand1 { get; set; }
    public string CertificateOfLand2 { get; set; }
    public int StatusId { get; set; }
    [ForeignKey(nameof(StatusId))]
    public ProductStatus ProductStatus { get; set; }
    [Required]
    public int DauChuId { get; set; }
    public DateTime BatDauBan { get; set; } = DateTime.Now;
    public double GiaBan { get; set; } = 0;
    public double HoaHong { get; set; } = 0;
    public double PhanTramChiaNv { get; set; } = 0; 
    public string Address { get; set; }
    public bool IsActive { get; set; } = false;
    
    public List<ProductImgs> ImgList { get; set; }
    public List<PhieuXemNhas> PhieuXemNhasList { get; set; }
}