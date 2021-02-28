package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S11_Cinema {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        String type = s.nextLine();
        int rows = Integer.parseInt(s.nextLine());
        int cols = Integer.parseInt(s.nextLine());

        double ticketPrice = 0.0;
        if ("Premiere".equals(type)){
            ticketPrice = 12;
        }else if("Normal".equals(type)){
            ticketPrice = 7.50;
        }else if("Discount".equals(type)){
            ticketPrice = 5;
        }
        System.out.printf("%.02f", rows*cols*ticketPrice);
    }

}
