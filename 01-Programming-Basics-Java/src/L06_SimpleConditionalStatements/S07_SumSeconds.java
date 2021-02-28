package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S07_SumSeconds {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int sec = Integer.parseInt(scanner.nextLine());
        sec = sec + Integer.parseInt(scanner.nextLine());
        sec = sec + Integer.parseInt(scanner.nextLine());

        int minutes = sec/60;
        int seconds = sec%60;

        String secondsString = "";
        if (seconds <= 9){
            secondsString = "0" + seconds;
        }else{
            secondsString = seconds + "";
        }

        System.out.printf("%d:%s", minutes, secondsString   );
    }

}
