/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package upchurchquizshow;

/**
 *
 * @author upchu
 */
public class Question {
    private String questionText;
    private String answerA;
    private String answerB;
    private String answerC;
    private String answerD;
    private char correctAnswer;

    // Default Constructor
    public Question() {
        this.questionText = "";
        this.answerA = "";
        this.answerB = "";
        this.answerC = "";
        this.answerD = "";
        this.correctAnswer = ' ';
    }

    // Overloaded Constructor
    public Question(String questionText, String answerA, String answerB, String answerC, String answerD, char correctAnswer) {
        this.questionText = questionText;
        this.answerA = answerA;
        this.answerB = answerB;
        this.answerC = answerC;
        this.answerD = answerD;
        this.correctAnswer = correctAnswer;
    }

    // Method to display the question and answers to the console
    public void displayQuestion() {
        System.out.println("\n" + this.questionText);
        System.out.println("a) " + this.answerA);
        System.out.println("b) " + this.answerB);
        System.out.println("c) " + this.answerC);
        System.out.println("d) " + this.answerD);
    }

    // Getter method for the correct answer
    public char getCorrectAnswer() {
        return this.correctAnswer;
    }
}
