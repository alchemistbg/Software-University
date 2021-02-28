package L10_AdvancedLoops;

import java.util.Scanner;

public class S03_PowersOfTwo {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i <= n; i++) {
            System.out.println((int)Math.pow(2, i));
        }
    }

}
