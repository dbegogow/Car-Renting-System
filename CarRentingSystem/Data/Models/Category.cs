using System.Collections.Generic;

namespace CarRentingSystem.Data.Models
{
    public class Category
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public IEnumerable<Car> Cars { get; init; } = new HashSet<Car>();
    }
}
                                                            