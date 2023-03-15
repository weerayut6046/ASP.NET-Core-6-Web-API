using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETLIVE.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        //[Column(TypeName = "ntext")] //ชนิดของข้อมูล
        [Required(ErrorMessage = "ชื่อประเภทสินค้า ห้ามว่าง")]
        public string CategoryName { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
}
