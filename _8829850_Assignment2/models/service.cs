public class service : person
{
    public string serviceName;
    public double servicePrice;


    public override string ToString(){
        if(clientName != null){
            return $"Client Name: {clientName}, CLient Number: XXX{clientNumber.Substring(3,7)}, client Phone Number: {clientPhoneNumber}, Client Type: {clientType}";
        }else{
             return $"Service Name: {serviceName}, Service Price: {servicePrice}";
        }
    }
}