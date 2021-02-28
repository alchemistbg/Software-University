package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S05_SquareFrame {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int repeats = Integer.parseInt(scanner.nextLine());

        for(int i = 0; i < repeats; i++){
            if(i == 0 || i == repeats-1){
                System.out.print("+ ");
                for (int j = 0; j < repeats - 2; j++) {
                    System.out.print("- ");
                }
                System.out.println("+");
            }else {
                System.out.print("| ");
                for (int j = 0; j < repeats - 2; j++) {
                    System.out.print("- ");
                }
                System.out.println("|");
            }
        }
    }

}
