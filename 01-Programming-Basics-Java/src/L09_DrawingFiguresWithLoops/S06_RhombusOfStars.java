package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S06_RhombusOfStars {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        String firstHalf = "";

        for(int row = 1; row <= n; row++) {
            for (int col = 1; col <= n - row; col++) {
                firstHalf = firstHalf + " ";
            }

            for(int col = 1; col <= row; col++) {
                firstHalf = firstHalf + "* ";
            }
            if(firstHalf.endsWith(" ")) {
                firstHalf = firstHalf.substring(0, firstHalf.lastIndexOf(" "));
            }
            firstHalf = firstHalf + "\n";
        }
        System.out.print(firstHalf);

        String[] rows = firstHalf.split("\n");

        for (int i = rows.length-2; i >= 0; i--) {
            System.out.println(rows[i]);
        }
    }

}
