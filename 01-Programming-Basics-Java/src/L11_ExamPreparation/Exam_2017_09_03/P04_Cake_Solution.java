package L11_ExamPreparation.Exam_2017_09_03;

import java.util.Scanner;

public class P04_Cake_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int cakeWidth = Integer.parseInt(scanner.nextLine());
        int cakeLength = Integer.parseInt(scanner.nextLine());
        int totalPieces = cakeLength*cakeWidth;

        String s = scanner.nextLine();
        boolean cakeShortage = false;

        String messageShortage = "";
        String messageStopped = "";

        while (!"STOP".equals(s)){
            int piecesToTake = Integer.parseInt(s);

            if(totalPieces < piecesToTake){
                messageShortage = "No more cake left! You need " + (piecesToTake - totalPieces) + " pieces more.";
                cakeShortage = true;
                break;
            }

            totalPieces = totalPieces - piecesToTake;
            s = scanner.nextLine();
        }

        messageStopped = totalPieces + " pieces are left.";

        if(cakeShortage){
            System.out.println(messageShortage);
        }else{
            System.out.println(messageStopped);
        }
    }

}
