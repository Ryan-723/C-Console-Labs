public class Boat : Vehicle
{
    public Double? maxSpeed;

    public override string ToString(){
        return $"Vehicle Name: {vehicleName}, Max Speed: {maxSpeed}";
    }
}