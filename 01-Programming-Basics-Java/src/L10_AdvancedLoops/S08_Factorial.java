package L10_AdvancedLoops;

import java.util.Scanner;

public class S08_Factorial {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int factoriel = 1;

        while (n > 0){
            factoriel = factoriel*n;
            n--;
        }
        System.out.println(factoriel);
    }

}
