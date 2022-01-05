namespace OOP_Homework
{
    internal static class Extensions
    {
        public static string Print(this Building building)
        {
            var id = building.GetId();
            var height = building.GetHeight();
            var floor = building.GetFloorCount();
            var apartment = building.GetTotalApartmentCount();
            var entrance = building.GetEntranceCount();
            return $"Building: {id}, Height:{height}, Floor: {floor}, Apartment: {apartment}, Entrance: {entrance}";
        }
    }
}