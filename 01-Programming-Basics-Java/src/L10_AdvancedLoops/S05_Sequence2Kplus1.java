package L10_AdvancedLoops;

import java.util.Scanner;

public class S05_Sequence2Kplus1 {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int sum = 1;

        for (int i = 1; sum <= n; i++) {
            System.out.println(sum);
            sum = 2*sum +1;
        }
    }

}
