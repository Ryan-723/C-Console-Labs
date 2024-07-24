class luggage : person{
   public int bagsQuantity;
   public double totalWeight;  

   public luggage(){
   }

   public double averageWeight(){
    return totalWeight/bagsQuantity;
   }

}