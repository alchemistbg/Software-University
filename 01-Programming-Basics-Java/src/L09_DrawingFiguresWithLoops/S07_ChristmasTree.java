package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S07_ChristmasTree {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        String header = new String(new char[n]).replace("\0", " ") + " |";
        System.out.println(header);
        for (int i = 0; i < n; i++) {

            for(int j = 1; j < n-i; j++) {
                System.out.print(" ");
            }

            for(int k = 0; k < i+1; k++){
                System.out.print("*");
            }

            System.out.print(" | ");

            for(int l = 0; l < i+1; l++) {
                System.out.print("*");
            }

            System.out.println();
        }
    }

}
