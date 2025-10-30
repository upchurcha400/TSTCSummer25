/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package consolesalesorder;
import java.util.Scanner;
/**
 *
 * @author upchu
 */
public class AUpchurchM2_ConsoleSalesOrder {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        //Set business name and define variables program.
        String businessName;
        String itemName;
        int itemsPerCase;
        double casePrice;
        double individualPrice;
        double taxRate;
        int totalItemsOrdered;
        int numCases;
        int numIndividuals;
        double subtotalCases;
        double subtotalIndividuals;
        double subtotal;
        double taxAmount;
        double totalAmount;
                
        //Scanner set up.  
        Scanner scanner = new Scanner(System.in);
                      
        //Assign vales that do not change;
        itemsPerCase = 6;
        casePrice = 379.99;
        individualPrice = 69.99;
        taxRate = 0.075;
        totalItemsOrdered = 0;
        businessName = "Western Treasure Bag";
        itemName = "American Darling Veronica Handbag";
        
        //Order section iormation
        System.out.println("=========================================");
        System.out.println("        " + businessName);
        System.out.println("=========================================");
        System.out.println("\nWelcome to " + businessName + "!");
        System.out.println("We sell the exclusive " + itemName + ".");
        System.out.println("Each case contains " + itemsPerCase + " of the " + itemName + "s at $" + String.format("%.2f", casePrice));
        System.out.println("Individual " + itemName + "s are $" + String.format("%.2f", individualPrice) + " each.");
        
        //Ask for user input 
        System.out.print("\nHow many " + itemName + "s would you like to order? ");
         totalItemsOrdered = scanner.nextInt();

         //Calulate the values for output 
        numCases = totalItemsOrdered / itemsPerCase;
        numIndividuals = totalItemsOrdered % itemsPerCase;
        subtotalCases = numCases * casePrice;
        subtotalIndividuals = numIndividuals * individualPrice;
        subtotal = subtotalCases + subtotalIndividuals;
        taxAmount = subtotal * taxRate;
        totalAmount = subtotal + taxAmount;
         
        //Receipt section output
        System.out.println("=========================================");
        System.out.println(businessName);
        System.out.println("=========================================");
        System.out.println("Total number of " + itemName + "s ordered: " + totalItemsOrdered);
        System.out.println(numCases + " cases of " + itemsPerCase + " " + itemName + "s @ $" + String.format("%.2f", casePrice) + " each = $" + String.format("%.2f", subtotalCases));
        System.out.println(numIndividuals + " individual " + itemName + "s @ $" + String.format("%.2f", individualPrice) + " each = $" + String.format("%.2f", subtotalIndividuals));
        System.out.println("Subtotal: $" + String.format("%.2f", subtotal));
        System.out.println("Tax: $" + String.format("%.2f", taxAmount));
        System.out.println("Total amount due: $" + String.format("%.2f", totalAmount));
        System.out.println("=========================================");
        System.out.println("Thank you for shopping at " + businessName + "!");
        System.out.println("=========================================");
      
    }
    
}
