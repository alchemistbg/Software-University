package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S06_PointOnRectangleBorder {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double x1 = Double.parseDouble(scanner.nextLine());
        double y1 = Double.parseDouble(scanner.nextLine());
        double x2 = Double.parseDouble(scanner.nextLine());
        double y2 = Double.parseDouble(scanner.nextLine());
        double x = Double.parseDouble(scanner.nextLine());
        double y = Double.parseDouble(scanner.nextLine());

        boolean isXonBorder = (x == x1 || x == x2) && y >= y1 && y <= y2;
        boolean isYonBorder = (y == y1 || y == y2) && x >= x1 && x <= x2;

        if(isXonBorder || isYonBorder){
            System.out.println("Border");
        }else{
            System.out.println("Inside / Outside");
        }
    }

}
