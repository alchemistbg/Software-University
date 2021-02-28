package L05_SimpleCalculations;

import java.util.Scanner;

public class S08_TriangleArea {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double a = Double.parseDouble(scanner.nextLine());
        double h = Double.parseDouble(scanner.nextLine());

        double area = a*h/2;

        System.out.printf("Triangle area = %.2f", area);
    }

}
