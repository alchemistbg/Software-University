package L10_AdvancedLoops;

import java.util.Scanner;

public class S01_Numbers_1_N_WithStep3 {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        System.out.println(1);
        for (int i = 3; i < n; i+=3) {
            System.out.println(1+i);
        }
    }

}
