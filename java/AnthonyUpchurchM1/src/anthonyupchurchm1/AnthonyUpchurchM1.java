/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package anthonyupchurchm1;

/**
 *
 * @author upchu
 */
public class AnthonyUpchurchM1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //Making a frame
        
        char topLeft = 218;
        char topRight = 191;
        char bottomLeft = 192;
        char bottomRight = 217;
        char horizonal = 196;
        char verticle = 179;
        
        //Starting with the Frame for Rocket
        System.out.print(topLeft);
        for (int i = 0; i < 22; i++) System.out.print(horizonal);
        System.out.println(topRight);
        
        //Start Rocket
        System.out.println(verticle + "         /\\           " + verticle);
        System.out.println(verticle + "        /^^\\          " + verticle);
        System.out.println(verticle + "       /----\\         " + verticle);
        System.out.println(verticle + "      / |^^| \\        " + verticle);
        System.out.println(verticle + "     /__|__|__\\       " + verticle);
        System.out.println(verticle + "        |^^|          " + verticle);
        System.out.println(verticle + "       /____\\         " + verticle);
        //Adding second output method
        System.out.print(verticle + "       |    |        ");
        System.out.println(" " + verticle);
        System.out.print(verticle + "       |____|        ");
        System.out.println(" " + verticle);
        System.out.print(verticle + "         ||          ");
        System.out.println(" " + verticle);
        System.out.print(verticle + "         **          ");
        System.out.println(" " + verticle);
        
        //Finish with bottom border
        System.out.print(bottomLeft);
        for (int i = 0; i < 22; i++) System.out.print(horizonal);
        System.out.println(bottomRight);
    }
    
}
