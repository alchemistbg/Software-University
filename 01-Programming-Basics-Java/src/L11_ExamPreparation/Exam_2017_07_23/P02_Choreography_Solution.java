package L11_ExamPreparation.Exam_2017_07_23;

import java.util.Scanner;

public class P02_Choreography_Solution {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int steps = Integer.parseInt(scanner.nextLine());
        int dancers = Integer.parseInt(scanner.nextLine());
        int days = Integer.parseInt(scanner.nextLine());

        double stepsAday = steps/days;
        double percentage = stepsAday/steps*100;
        percentage = Math.ceil(percentage);

        int percentageInt = (int)percentage;
        double percentagePerDancer = 1.0*percentageInt/dancers;
        if(percentageInt <= 13){
            System.out.printf("Yes, they will succeed in that goal! %.2f%%.", percentagePerDancer);
        }else{
            System.out.printf("No, They will not succeed in that goal! " +
                    "Required %.2f%% steps to be learned per day.", percentagePerDancer);
        }
    }

}
