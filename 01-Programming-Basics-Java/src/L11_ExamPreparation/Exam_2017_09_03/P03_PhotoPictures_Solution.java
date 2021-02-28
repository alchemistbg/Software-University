package L11_ExamPreparation.Exam_2017_09_03;

import java.util.Scanner;

public class P03_PhotoPictures_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int picturesNum = Integer.parseInt(scanner.nextLine());
        String picturesSize = scanner.nextLine().toLowerCase();
        String orderType = scanner.nextLine();

        double picturesPrice = 0.0;
        double discountByNum = 0.0;
        double discountByOrderType = 0.0;
        double totalOrderPrice = 0.0;

        switch (picturesSize){
            case "9x13": {
                picturesPrice = picturesNum*0.16;
                if(picturesNum >= 50){
                    discountByNum = picturesPrice*0.05;
                }
            }break;
            case "10x15": {
                picturesPrice = picturesNum*0.16;
                if(picturesNum >= 80){
                    discountByNum = picturesPrice*0.03;
                }
            }break;
            case "13x18": {
                picturesPrice = picturesNum*0.38;
                if(picturesNum >= 50 && picturesNum <= 100){
                    discountByNum = picturesPrice*0.03;
                }else if(picturesNum > 100){
                    discountByNum = picturesPrice*0.05;
                }
            }break;
            case "20x30": {
                picturesPrice = picturesNum*2.90;
                if(picturesNum >= 10 && picturesNum <= 50){
                    discountByNum = picturesPrice*0.07;
                }else if(picturesNum > 50){
                    discountByNum = picturesPrice*0.09;
                }
            }break;
        }

        picturesPrice -= discountByNum;

        if("online".equals(orderType)) {
            discountByOrderType = picturesPrice*0.02;
        }

        totalOrderPrice = picturesPrice - discountByOrderType;

        System.out.printf("%.2fBGN", totalOrderPrice);

    }

}
