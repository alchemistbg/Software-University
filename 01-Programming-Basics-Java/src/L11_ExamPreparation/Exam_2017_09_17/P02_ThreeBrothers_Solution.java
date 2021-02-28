package L11_ExamPreparation.Exam_2017_09_17;

import java.util.Scanner;

public class P02_ThreeBrothers_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double t1 = Double.parseDouble(scanner.nextLine());
        double t2 = Double.parseDouble(scanner.nextLine());
        double t3 = Double.parseDouble(scanner.nextLine());
        double t4 = Double.parseDouble(scanner.nextLine());

        double cleaningTime = 1/((1/t1) + (1/t2) + (1/t3));
        double breakTIme = cleaningTime*0.15;
        double totalTime = cleaningTime + breakTIme;

        double timeDiff = Math.abs(totalTime - t4);

        boolean timeShortage = totalTime < t4;

        if(timeShortage){
            int diff = ((int) Math.floor(timeDiff));
            System.out.printf("Cleaning time: %.2f%n", totalTime);
            System.out.println("Yes, there is a surprise - time left -> " + diff + " hours.");
        }else{
            int diff = ((int) Math.ceil(timeDiff));
            System.out.printf("Cleaning time: %.2f%n", totalTime);
            System.out.println("No, there isn't a surprise - shortage of time -> " + diff + " hours.");
        }
    }

}
