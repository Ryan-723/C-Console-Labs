  class Grocery{

    public int productQuantity;
    public string productPurchased;
    public double totalWeight;
    public Grocery(){

    }

    // Function to output the quantity and name of food purchased
    public String purchasedOutput(){
      return productQuantity + " "  + productPurchased;
    }

    // Function to calculate the average weight of food purchased
    public double averageWeight(){

      double avgweight = totalWeight/productQuantity;
      return avgweight;
    
    }


}  

