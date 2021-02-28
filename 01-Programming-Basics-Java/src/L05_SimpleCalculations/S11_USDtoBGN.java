package L05_SimpleCalculations;

import java.util.Scanner;

public class S11_USDtoBGN {

    public static void main(String[] args) {

        Scanner s = new Scanner(System.in);

        double usd = Double.parseDouble(s.nextLine());
        double bgn = usd*1.79549;

        System.out.printf("%.2f", bgn);
    }

}
