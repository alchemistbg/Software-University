package L05_SimpleCalculations;

import java.util.Scanner;

public class S10_RadiansToDegrees {

    public static void main(String[] args) {

        Scanner s = new Scanner(System.in);

        double rad = Double.parseDouble(s.nextLine());
        double deg = rad*180/Math.PI;


        System.out.printf("%.0f", deg);

    }

}
