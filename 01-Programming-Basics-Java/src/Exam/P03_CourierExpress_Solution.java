package Exam;

import java.util.Scanner;

public class P03_CourierExpress_Solution {

    // 58/100

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double packageWeight = Double.parseDouble(scanner.nextLine());
        String serviceType = scanner.nextLine();
        int distance = Integer.parseInt(scanner.nextLine());

        double price = 0.0;

        if("standard".equals(serviceType)){
            if(packageWeight < 1.0){
                price = 1.0*distance*3/100;
            }else if(packageWeight > 1.0 && packageWeight < 10.0){
                price = 1.0*distance*5/100;
            }else if(packageWeight > 11.0 && packageWeight < 40.0){
                price = 1.0*distance*10/100;
            }else if(packageWeight > 41.0 && packageWeight < 90.0){
                price = 1.0*distance*15/100;
            }else if(packageWeight > 91.0 && packageWeight < 150.0){
                price = 1.0*distance*20/100;
            }
        }else{
            if(packageWeight < 1.0){
                price = 1.0*distance*3/100 + distance*3/100*0.8;
                double nadcenka = (15*0.02)*distance*packageWeight/100;
                price  = price + nadcenka;
            }else if(packageWeight > 1.0 && packageWeight < 10){
                price = 1.0*distance*5/100 + distance*5/100*0.4;
                double nadcenka = (15*0.02)*distance*packageWeight/100;
                price  = price + nadcenka;
            }else if(packageWeight > 11.0 && packageWeight < 40.0){
                price = 1.0*distance*10/100 + distance*10/100*0.05;
                double nadcenka = (15*0.02)*distance*packageWeight/100;
                price  = price + nadcenka;
            }else if(packageWeight > 41.0 && packageWeight < 90.0){
                price = 1.0*distance*15/100;
                double nadcenka = (15*0.02)*distance*packageWeight/100;
                price  = price + nadcenka;
            }else if(packageWeight > 91.0 && packageWeight < 150.0){
                price = 1.0*distance*20/100 + distance*20/100*0.01;
                double nadcenka = (15*0.02)*distance*packageWeight/100;
                price  = price + nadcenka;
            }

        }
        System.out.printf("The delivery of your shipment with weight of %.3f kg. would cost %.2f lv.%n", packageWeight, price);
    }

}
