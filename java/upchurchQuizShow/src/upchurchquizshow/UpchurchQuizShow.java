/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package upchurchquizshow;

import java.util.Scanner;
import java.util.ArrayList;

/**
 *
 * @author upchu
 */
public class UpchurchQuizShow {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Use an ArrayList to store the questions
        ArrayList<Question> questions = new ArrayList<>();

        // Question objects with overloaded constructor
        questions.add(new Question("The default access specifier for a class is __________?",
            "public", "private", "package", "protected", 'c'));

        questions.add(new Question("Which of the following is not a valid switch case?",
            "case a:", "case 'a':", "case \"a\":", "default:", 'a'));
            
        questions.add(new Question("When several if/else statements are chained together, what does the program do with the remaining if/else statements when the first if statement is true?",
            "Ignores them", "Checks each if/else statement for all true conditions", "Checks the final else statement and executes that code", "Checks the final else statement but does not execute that code", 'a'));
            
        questions.add(new Question("Which operator only returns true if both conditions are true?",
            "!=", "||", "^", "&&", 'd'));
            
        questions.add(new Question("Which is an acceptable value for a char variable?",
            "65", "'a'", "'\u2764'", "All of the above.", 'b'));

        Scanner scanner = new Scanner(System.in);
        int score = 0;
        int totalQuestions = questions.size();

        System.out.println("Welcome to the Java Programming Quiz!");
        System.out.println("Answer each question by typing the letter (a, b, c, or d).");

        // Loop through each question
        for (Question q : questions) {
            // Display the current question
            q.displayQuestion();

            // Prompt for user input using nextLine()
            System.out.print("Your answer: ");
            String userAnswer = scanner.nextLine();

            // Check if the user's answer is correct
            // Handle both uppercase and lowercase input
            if (!userAnswer.isEmpty() && userAnswer.toLowerCase().charAt(0) == q.getCorrectAnswer()) {
                System.out.println("Correct!");
                score += 20;
            } else {
                System.out.println("Incorrect. The correct answer was " + q.getCorrectAnswer() + ".");
            }
        }

        // Calculate and display the final score as a percentage
        double scorePercent = (double) score / (totalQuestions * 20) * 100;
        System.out.println("\nQuiz complete!");
        System.out.println("Your final score is " + score + " out of " + (totalQuestions * 20) + ".");
        System.out.printf("That's %.2f%%.\n", scorePercent);
        
           }
}