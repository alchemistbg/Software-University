package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S03_SquareOfStars {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int repeats = Integer.parseInt(scanner.nextLine());
        for(int i = 0; i < repeats; i++){
            System.out.println(str("* ", repeats));
        }

    }

    public static String str(String str, int repeats){
        StringBuilder sb = new StringBuilder();
        String result = "";
        for (int i = 0; i < repeats; i++) {
            sb.append(str);
        }
        if(sb.toString().endsWith(" ")){
            sb.deleteCharAt(sb.toString().length()-1);
        }
        return sb.toString();
    }

}
