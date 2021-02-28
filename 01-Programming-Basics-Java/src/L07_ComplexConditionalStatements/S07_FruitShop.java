package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S07_FruitShop {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String fruit = scanner.nextLine().toLowerCase();
        String weekDay = scanner.nextLine().toLowerCase();
        double qty = Double.parseDouble(scanner.nextLine());

        boolean isWorkDay = "monday".equals(weekDay) || "tuesday".equals(weekDay) ||
                "wednesday".equals(weekDay) || "thursday".equals(weekDay) || "friday".equals(weekDay);
        boolean isWeekend = "saturday".equals(weekDay) || "sunday".equals(weekDay);

        if(isWorkDay){
            if("banana".equals(fruit)){
                System.out.println(qty*2.50);
            }else if("apple".equals(fruit)){
                System.out.println(qty*1.20);
            }else if("orange".equals(fruit)){
                System.out.println(qty*0.85);
            }else if("grapefruit".equals(fruit)){
                System.out.println(qty*1.45);
            }else if("kiwi".equals(fruit)){
                System.out.println(qty*2.70);
            }else if("pineapple".equals(fruit)){
                System.out.println(qty*5.50);
            }else if("grapes".equals(fruit)){
                System.out.println(qty*3.85);
            }else{
                System.out.println("error");
            }
        }else if(isWeekend){
            if("banana".equals(fruit)){
                System.out.println(qty*2.70);
            }else if("apple".equals(fruit)){
                System.out.println(qty*1.25);
            }else if("orange".equals(fruit)){
                System.out.println(qty*0.90);
            }else if("grapefruit".equals(fruit)){
                System.out.println(qty*1.60);
            }else if("kiwi".equals(fruit)){
                System.out.println(qty*3.00);
            }else if("pineapple".equals(fruit)){
                System.out.println(qty*5.60);
            }else if("grapes".equals(fruit)){
                System.out.println(qty*4.20);
            }else{
                System.out.println("error");
            }
        }else {
            System.out.println("error");
        }
    }

}
