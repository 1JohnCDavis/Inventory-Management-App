using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace John_Davis_Inventory_App
{
    class Product
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public BindingList<Part> AssociatedParts
        {
            get
            {
                return associatedParts;
            }
            set
            {
                associatedParts = value;
            }
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public Part LookupAssociatedPart(int partID)
        {
            var part = AssociatedParts.Where(p => p.PartID == partID).FirstOrDefault();

            if (part == null)
                throw new Exception(message: $"A part with ID #{partID} is not associated with this product.");

            return part;
        }
        

    }
}
