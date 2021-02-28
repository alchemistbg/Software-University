package Exam;

import java.util.Scanner;

public class P04_ExternalEvaluation_Solution {

    // 100/100

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int totalGrades = Integer.parseInt(scanner.nextLine());
        int counter = totalGrades;
        int poorCount = 0;
        int satisCount = 0;
        int goodCount = 0;
        int vGoodCount = 0;
        int exCount = 0;

        while(counter > 0){
            double points = Double.parseDouble(scanner.nextLine());
            if(points <= 22.5){
                poorCount++;
            }else if(points > 22.5 && points <= 40.5){
                satisCount++;
            }else if(points > 40.5 && points <= 58.5){
                goodCount++;
            }else if(points > 58.5 && points <= 76.5){
                vGoodCount++;
            }else if(points > 76.5){
                exCount++;
            }
            counter--;
        }
        System.out.printf("%.2f%% poor marks%n", 1.0*poorCount/totalGrades*100);
        System.out.printf("%.2f%% satisfactory marks%n", 1.0*satisCount/totalGrades*100);
        System.out.printf("%.2f%% good marks%n", 1.0*goodCount/totalGrades*100);
        System.out.printf("%.2f%% very good marks%n", 1.0*vGoodCount/totalGrades*100);
        System.out.printf("%.2f%% excellent marks%n", 1.0*exCount/totalGrades*100);
    }

}
