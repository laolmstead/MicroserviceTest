namespace MaterialsApi.Models
{
    public class Material
    {
        public Material(string? name, 
                        string? description, 
                        double quantity, 
                        double unitPrice, 
                        string? unit,
                        DateTime dateCreated,
                        DateTime dateModified)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Unit = unit;
            DateCreated = dateCreated;
            DateModified = dateModified;
        }

        public Guid Id { get; }
        public string? Name { get; }
        public string? Description { get; }
        public double Quantity { get; }
        public double UnitPrice { get; }
        public string? Unit { get; }
        public DateTime DateCreated { get; }
        public DateTime DateModified { get; }
    }
}
