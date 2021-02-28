package L11_ExamPreparation.Exam_2017_09_17;

import java.util.Scanner;

public class P04_GrandpaStavri_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int days = Integer.parseInt(scanner.nextLine());

        double rakiaVolume = 0.0;
        double rakiaGrade = 0.0;

        double rakiaTotalVolume = 0.0;
        double rakiaTotalGrade = 0.0;

        String result = "";

        if(days == 1){
            rakiaVolume = Double.parseDouble(scanner.nextLine());
            rakiaGrade = Double.parseDouble(scanner.nextLine());

            rakiaTotalVolume = rakiaVolume;
            rakiaTotalGrade = rakiaGrade;
        }
        else{
            for (int i = 1; i <= days*2; i++) {
                if (i % 2 != 0) {
                    rakiaVolume = Double.parseDouble(scanner.nextLine());
                    rakiaTotalVolume = rakiaTotalVolume+rakiaVolume;
                } else {
                    rakiaGrade = rakiaVolume*Double.parseDouble(scanner.nextLine());
                    rakiaTotalGrade = rakiaTotalGrade + rakiaGrade;
                }
            }
            rakiaTotalGrade = rakiaTotalGrade/rakiaTotalVolume;
        }

        System.out.printf("Liter: %.2f%n", rakiaTotalVolume);
        System.out.printf("Degrees: %.2f%n",rakiaTotalGrade);

        if (rakiaTotalGrade < 38){
            result = "Not good, you should baking!";
        }else if(rakiaTotalGrade > 38 && rakiaTotalGrade < 42) {
            result = "Super!";
        }else{
            result = "Dilution with distilled water!";
        }
        System.out.printf("%s", result);
    }

}
