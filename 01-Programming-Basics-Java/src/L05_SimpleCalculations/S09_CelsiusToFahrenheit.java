package L05_SimpleCalculations;

import java.util.Scanner;

public class S09_CelsiusToFahrenheit {

    public static void main(String[] args) {

        Scanner s = new Scanner(System.in);

        double c = Double.parseDouble(s.nextLine());
        double f = 1.8*c + 32;

        System.out.printf("%.2f", f);

    }

}
