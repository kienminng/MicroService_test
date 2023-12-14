using System.ComponentModel.DataAnnotations;

namespace ProductManager.Entity;

public class PhieuXemNhas
{
    [Key]
    public int Id { get; set; }
    public string CustumerName { get; set; }
    public string CustumerPhoneNumber { get; set; }
    public int CustumerId { get; set; }
    public string CustumerIdImg1 { get; set; }
    public string CustumerIdImg2 { get; set; }
    public string Descreption { get; set; }
    public int NhaId { get; set; }
    public int NhanVienId { get; set; }
    public DateTime CreateTime { get; set; }
    public bool BanThanhCong { get; set; } = false;
    public bool IsActive { get; set; } = false;
}