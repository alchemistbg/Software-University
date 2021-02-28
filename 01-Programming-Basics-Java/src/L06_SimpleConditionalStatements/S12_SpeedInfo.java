package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S12_SpeedInfo {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double sp = Double.parseDouble(scanner.nextLine());

        if(sp > 1000){
            System.out.println("extremely fast");
        }else if(sp > 150 && sp <= 1000){
            System.out.println("ultra fast");
        }else if(sp > 50 && sp <= 150){
            System.out.println("fast");
        }else if(sp > 10 && sp <= 50){
            System.out.println("average");
        }else {
            System.out.println("slow");
        }
    }

}
