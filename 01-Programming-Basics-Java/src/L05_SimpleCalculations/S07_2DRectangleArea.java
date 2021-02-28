package L05_SimpleCalculations;

import java.util.Scanner;

public class S07_2DRectangleArea {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double x1 = Double.parseDouble(scanner.nextLine());
        double y1 = Double.parseDouble(scanner.nextLine());
        double x2 = Double.parseDouble(scanner.nextLine());
        double y2 = Double.parseDouble(scanner.nextLine());

        double a = Math.abs(x1-x2);
        double b = Math.abs(y1-y2);

        double area = a*b;
        double perim = 2*a+2*b;

        System.out.println(area);
        System.out.println(perim);
    }

}
