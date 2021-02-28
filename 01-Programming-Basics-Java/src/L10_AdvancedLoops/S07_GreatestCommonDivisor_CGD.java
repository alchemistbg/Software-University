package L10_AdvancedLoops;

import java.util.Scanner;

public class S07_GreatestCommonDivisor_CGD {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int num1 = Integer.parseInt(scanner.nextLine());
        int num2 = Integer.parseInt(scanner.nextLine());

        int bigger = Math.max(num1, num2);
        int smaller = Math.min(num1, num2);

        int residual = bigger % smaller;

        while(residual > 0){
            bigger = smaller;
            smaller = residual;
            residual = bigger % smaller;
        }
        System.out.println(smaller);
    }

}
