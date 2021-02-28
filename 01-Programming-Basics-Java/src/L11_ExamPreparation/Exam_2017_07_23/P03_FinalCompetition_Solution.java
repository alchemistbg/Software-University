package L11_ExamPreparation.Exam_2017_07_23;

import java.util.Scanner;

public class P03_FinalCompetition_Solution {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int dancers = Integer.parseInt(scanner.nextLine());
        double points = Double.parseDouble(scanner.nextLine());
        String season = scanner.nextLine();
        String location = scanner.nextLine();

        double price = 0.0;
        double expenditures = 0.0;
        if("Bulgaria".equals(location)){
            price = dancers*points;
            if("summer".equals(season)){
                expenditures = price*0.05;
            }else{
                expenditures = price*0.08;
            }
        }else{
            price = dancers*points;
            price = price + price*0.5;

            if("summer".equals(season)){
                expenditures = price*0.1;
            }else{
                expenditures = price*0.15;
            }
        }
        price = price - expenditures;
        double charity = price*0.75;
        price = price - charity;
        double profit = price/dancers;

        System.out.printf("Charity - %.2f%nMoney per dancer - %.2f", charity, profit);
    }

}
