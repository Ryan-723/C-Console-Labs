public class Car : Vehicle
{
    public Double? fuelEfficiency;

    public override string ToString(){
        return $"Vehicle Name: {vehicleName}, Fuel Efficiency: {fuelEfficiency}";
    }
}