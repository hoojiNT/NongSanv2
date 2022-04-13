using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSanv2.core.Entity
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ActionBy { get; set; }
        public bool Delete { get; set; } = false;
        public string? ActionName { get; set; }
        public string? Description { get; set; }

    }
    public class Manufacturer : Base
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
    public class Contact : Base
    {
        public bool Default { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
    public class ProductType : Base
    {
        public string Name { get; set; }
    }
    public class ProductImage : Base
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
        public int Order { get; set; } = 0;
    }
    public class Product:Base
    {
        public string? ProductName { get; set; }
        public string? ProductTypeId { get; set; }
        public DateTime? ExpriredDate { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public ProductType? ProductType { get; set; }
        public string ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string ProductImageId { get; set; }
        public IList<ProductImage>? ProductImages { get; set; }
    }
    public class Customer : Base
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
    
    public class Category : Base
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
    }

}
