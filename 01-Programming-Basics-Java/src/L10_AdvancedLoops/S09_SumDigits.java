package L10_AdvancedLoops;

import java.util.Scanner;

public class S09_SumDigits {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String number = scanner.nextLine();

        int length = number.length()-1;
        int sum = 0;
        while(length >= 0){
            sum  = sum + (number.charAt(length)-48);
            length --;
        }
        System.out.println(sum);
    }

}
