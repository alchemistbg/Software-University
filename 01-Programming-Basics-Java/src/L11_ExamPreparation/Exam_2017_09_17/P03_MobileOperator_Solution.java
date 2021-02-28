package L11_ExamPreparation.Exam_2017_09_17;

import java.util.Scanner;

public class P03_MobileOperator_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String duration = scanner.nextLine();
        String type = scanner.nextLine();
        String net = scanner.nextLine();
        int monthsNum = Integer.parseInt(scanner.nextLine());

        double monthPayment = 0.0;

        if("one".equals(duration)){
            switch (type){
                case "Small": monthPayment = 9.98;
                    break;
                case "Middle": monthPayment = 18.99;
                    break;
                case "Large": monthPayment = 25.98;
                    break;
                case "ExtraLarge": monthPayment = 35.99;
                    break;
            }

            if ("yes".equals(net)) {
                if (monthPayment <= 10.00) {
                    monthPayment = monthPayment + 5.50;
                } else if (monthPayment <= 30.00) {
                    monthPayment = monthPayment + 4.35;
                } else if (monthPayment > 30) {
                    monthPayment = monthPayment + 3.85;
                }
            }
        }else{
            switch (type){
                case "Small": monthPayment = 8.58;
                    break;
                case "Middle": monthPayment = 17.09;
                    break;
                case "Large": monthPayment = 23.59;
                    break;
                case "ExtraLarge": monthPayment = 31.79;
                    break;
            }

            if ("yes".equals(net)){
                if(monthPayment <= 10.00){
                    monthPayment = monthPayment + 5.50;
                }else if(monthPayment <= 30.00){
                    monthPayment = monthPayment + 4.35;
                }else if(monthPayment > 30){
                    monthPayment = monthPayment + 3.85;
                }
            }

            monthPayment = monthPayment - (monthPayment*0.0375);
        }
        double total = monthPayment*monthsNum;
        System.out.printf("%.2f lv.", total);
    }

}
