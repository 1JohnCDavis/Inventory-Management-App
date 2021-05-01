using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace John_Davis_Inventory_App
{
    static class Inventory
    {
        private static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts
        {
            get
            {
                return allParts;
            }
            set
            {
                allParts = value;
            }
        }

        private static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int productID)
        {
            var productToRemove = Products.Where(p => p.ProductID == productID).FirstOrDefault();
            if (productToRemove == null)
                throw new Exception(message: $"A product with ID #{productID} is not available to be removed.");

            Products.Remove(productToRemove);
            return true;
        }

        public static Product LookupProduct(int productID)
        {
            var productToLookup = Products.Where(p => p.ProductID == productID).FirstOrDefault();

            if (productToLookup == null)
                throw new Exception(message: $"A product with ID #{productID} is not available for look-up.");

            return productToLookup;
        }

        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }

        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.InStock = updatedProduct.InStock;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }


        public static void AddPart(Part part)
        {
            AllParts.Add(part);

        }

        public static bool DeletePart(Part part)
        {
            var partToDelete = AllParts.FirstOrDefault();
            if (partToDelete == null)
                throw new Exception(message: "There are no parts available to be deleted.");

            AllParts.Remove(partToDelete);
            return true;
        }



        public static Part LookupPart(int partID)
        {
            var partToLookup = AllParts.Where(p => p.PartID == partID).FirstOrDefault();

            if (partToLookup == null)
                throw new Exception(message: $"A part with ID #{partID} is not available for look-up.");

            return partToLookup;
        }

        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }

        public static void UpdatePart(int partID, Part updatedPart)
        {
            foreach (Part currentPart in AllParts)
            {
                if (currentPart.PartID == partID)
                {
                    currentPart.Name = updatedPart.Name;
                    currentPart.InStock = updatedPart.InStock;
                    currentPart.Price = updatedPart.Price;
                    currentPart.Min = updatedPart.Min;
                    currentPart.Max = updatedPart.Max;
                    currentPart.PartID = updatedPart.PartID;
                    return;
                }
            }

        }
        public static void UpdateInHouse(int partID, Inhouse inhouse)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(John_Davis_Inventory_App.Inhouse))
                {
                    Inhouse newPart = (Inhouse)AllParts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = inhouse.Name;
                        newPart.InStock = inhouse.InStock;
                        newPart.Price = inhouse.Price;
                        newPart.Min = inhouse.Min;
                        newPart.Max = inhouse.Max;
                        newPart.MachineID = inhouse.MachineID;
                    }
                }
            }
        }
        public static void UpdateOutsourced(int partID, Outsourced outsourced)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].GetType() == typeof(John_Davis_Inventory_App.Outsourced))
                {
                    Outsourced newPart = (Outsourced)AllParts[i];

                    if (newPart.PartID == partID)
                    {
                        newPart.Name = outsourced.Name;
                        newPart.InStock = outsourced.InStock;
                        newPart.Price = outsourced.Price;
                        newPart.Min = outsourced.Min;
                        newPart.Max = outsourced.Max;
                        newPart.CompanyName = outsourced.CompanyName;
                    }
                }
            }
        }
    }
}
