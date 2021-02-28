package Exam;

import java.util.Scanner;

public class P01_WireNet_Solution {

    // 100/100

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int length = Integer.parseInt(scanner.nextLine());
        int width = Integer.parseInt(scanner.nextLine());
        double heigth = Double.parseDouble(scanner.nextLine());
        double pricePerMeter = Double.parseDouble(scanner.nextLine());
        double weigthPerSquareMeter = Double.parseDouble(scanner.nextLine());

        int perimeter = 2*length + 2*width;
        double surface = perimeter*heigth;

        double totalPrice = perimeter*pricePerMeter;
        double totalWeigth = surface*weigthPerSquareMeter;

        System.out.println(perimeter);
        System.out.printf("%.2f%n", totalPrice);
        System.out.printf("%.3f%n", totalWeigth);

        scanner.close();
    }

}
