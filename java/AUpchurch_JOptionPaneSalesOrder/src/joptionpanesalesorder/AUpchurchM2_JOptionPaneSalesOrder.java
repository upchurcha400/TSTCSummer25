/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package joptionpanesalesorder;
import javax.swing.JOptionPane;
/**
 *
 * @author upchu
 */
public class AUpchurchM2_JOptionPaneSalesOrder {

    public static void main(String[] args) {
        String businessName = "Western Treasure Bag";
        String itemName = "American Darling Handbag";
        int itemsPerCase = 6;
        double casePrice = 379.99;
        double individualPrice = 69.99;
        double taxRate = 0.075;
        int totalItemsOrdered = Integer.parseInt(userInput);
        int numCases = totalItemsOrdered / itemsPerCase;
        int numIndividuals = totalItemsOrdered % itemsPerCase;
        double subtotalCases = numCases * casePrice;
        double subtotalIndividuals = numIndividuals * individualPrice;
        double subtotal = subtotalCases + subtotalIndividuals;
        double taxAmount = subtotal * taxRate;
        double totalAmount = subtotal + taxAmount;
        
        
        //Add Welcome message and input prompting from user.
        String welcomeMessage = "=========================================\n"
                + "        " + businessName + "\n"
                + "=========================================\n"
                + "Welcome to " + businessName + "!\n"
                + "We sell the " + itemName + ".\n"
                + "Each case contains " + itemsPerCase + " " + itemName + "s at $" + String.format("%.2f", casePrice) + " per case.\n"
                + "Individual " + itemName + "s are $" + String.format("%.2f", individualPrice) + " each.\n\n"
                + "How many " + itemName + "s would you like to order?";
        
        String userInput = JOptionPane.showInputDialog(null, welcomeMessage, "Order " + itemName + "s", JOptionPane.QUESTION_MESSAGE);

        
        
        // Build the receipt with separator lines for aesthetics 
        String receipt = "=========================================\n"
                + businessName + "\n"
                + "=========================================\n"
                + "Total number of " + itemName + "s ordered: " + totalItemsOrdered + "\n"
                + numCases + " cases of " + itemsPerCase + " " + itemName + "s @ $" + String.format("%.2f", casePrice) + " each = $" + String.format("%.2f", subtotalCases) + "\n"
                + numIndividuals + " individual " + itemName + "s @ $" + String.format("%.2f", individualPrice) + " each = $" + String.format("%.2f", subtotalIndividuals) + "\n"
                + "Subtotal: $" + String.format("%.2f", subtotal) + "\n"
                + "Tax: $" + String.format("%.2f", taxAmount) + "\n"
                + "Total amount due: $" + String.format("%.2f", totalAmount) + "\n"
                + "=========================================\n"
                + "Thank you for shopping at " + businessName + "!\n"
                + "=========================================";

        JOptionPane.showMessageDialog(null, receipt, businessName + " Receipt", JOptionPane.INFORMATION_MESSAGE);
    }
}