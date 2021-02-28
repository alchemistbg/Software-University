package L05_SimpleCalculations;

import java.util.Scanner;

public class S02_InchesToCentimeters {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("inches: ");
        double d = Double.parseDouble(scanner.nextLine());
        double cm = d*2.54;
        System.out.println(cm);
    }

}
