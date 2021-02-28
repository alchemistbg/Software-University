package L11_ExamPreparation.Exam_2017_09_03;

import java.util.Scanner;

public class P01_TailoringWorkshop_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int tablesNum = Integer.parseInt(scanner.nextLine());
        double tablesLength = Double.parseDouble(scanner.nextLine());
        double tablesWidth = Double.parseDouble(scanner.nextLine());



        double pokrivka = (tablesLength+0.6)*(tablesWidth+0.6);
        double kare = (tablesLength/2)*(tablesLength/2);

        double platPokrivka = tablesNum*pokrivka;
        double platKare = tablesNum*kare;

        double priceUSD =  platPokrivka*7 + platKare*9;
        double priceBGN = priceUSD*1.85;

        System.out.printf("%.2f USD%n", priceUSD);
        System.out.printf("%.2f BGN", priceBGN);

    }

}
