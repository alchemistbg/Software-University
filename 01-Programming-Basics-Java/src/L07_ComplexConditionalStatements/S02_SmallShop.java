package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S02_SmallShop {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String item = scanner.nextLine().toLowerCase();
        String city = scanner.next().toLowerCase();
        double itemNum = Double.parseDouble(scanner.next());

        //double price = 0.0;

        if("sofia".equals(city)) {
            if("coffee".equals(item)) {
                System.out.println(0.50*itemNum);
            }else if("water".equals(item)) {
                System.out.println(0.80*itemNum);
            }else if("beer".equals(item)) {
                System.out.println(1.20*itemNum);
            }else if("sweets".equals(item)) {
                System.out.println(1.45*itemNum);
            }else if("peanuts".equals(item)) {
                System.out.println(1.60*itemNum);
            }
        }else if("plovdiv".equals(city)) {
            if("coffee".equals(item)) {
                System.out.println(0.40*itemNum);
            }else if("water".equals(item)) {
                System.out.println(0.70*itemNum);
            }else if("beer".equals(item)) {
                System.out.println(1.15*itemNum);
            }else if("sweets".equals(item)) {
                System.out.println(1.30*itemNum);
            }else if("peanuts".equals(item)) {
                System.out.println(1.50*itemNum);
            }
        }else if("varna".equals(city)) {
            if("coffee".equals(item)) {
                System.out.println(0.45*itemNum);
            }else if("water".equals(item)) {
                System.out.println(0.70*itemNum);
            }else if("beer".equals(item)) {
                System.out.println(1.10*itemNum);
            }else if("sweets".equals(item)) {
                System.out.println(1.35*itemNum);
            }else if("peanuts".equals(item)) {
                System.out.println(1.55*itemNum);
            }
        }
    }

}
