package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S04_TriangleOfDollars {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int repeats = Integer.parseInt(scanner.nextLine());

        for(int row = 1; row <= repeats; row++){
            for (int col = 1; col <= row; col++) {
                System.out.print("$ ");
            }
            System.out.println();
        }
    }

}
