/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

/**
 *
 * @author upchu
 */
import javax.swing.JOptionPane;

public class OrdersWidget {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String strQuantity;
        int quantity;
        double total, cost = 5.95;
        
        strQuantity = JOptionPane.showInputDialog(null, "Widgets are $5.95 each. How many do you want?", "Enter Quantity here.");
        quantity = Integer.parseInt(strQuantity);
        total = quantity * cost;
        
        JOptionPane.showMessageDialog(null, "Your total is $" + String.format("%.2f", total));
    }
    
}
