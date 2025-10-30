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
        String businessName;
        String itemName;
        int itemsPerCase;
        double casePrice;
        double individualPrice;
        double taxRate;
        String welcomeMessage;
        String userInput;
        int totalItemsOrdered;
        int numCases;
        int numIndividuals;
        double subtotalCases;
        double subtotalIndividuals;
        double subtotal;
        double taxAmount;
        double totalAmount;
        String receipt;
        
        
        //Add value to variables. 
        businessName = "Western Treasure Bag";
        itemName = "American Darling Veronica Handbag";
        totalItemsOrdered = 0;
        itemsPerCase = 6;
        casePrice = 379.99;
        individualPrice = 69.99;
        taxRate = 0.075;
        welcomeMessage = "=========================================\n"
                + "        " + businessName + "\n"
                + "=========================================\n"
                + "Welcome to " + businessName + "!\n"
                + "We sell the " + itemName + ".\n"
                + "Each case contains " + itemsPerCase + " " + itemName + "s at $" + String.format("%.2f", casePrice) + " per case.\n"
                + "Individual " + itemName + "s are $" + String.format("%.2f", individualPrice) + " each.\n\n"
                + "How many " + itemName + "s would you like to order?";
                        
        userInput = JOptionPane.showInputDialog(null, welcomeMessage, "Order " + itemName + "s", JOptionPane.QUESTION_MESSAGE);
        totalItemsOrdered = Integer.parseInt(userInput);
        
        numCases = totalItemsOrdered / itemsPerCase;
        numIndividuals = totalItemsOrdered % itemsPerCase;
        subtotalCases = numCases * casePrice;
        subtotalIndividuals = numIndividuals * individualPrice;
        subtotal = subtotalCases + subtotalIndividuals;
        taxAmount = subtotal * taxRate;
        totalAmount = subtotal + taxAmount;
        
        receipt = "=========================================\n"
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