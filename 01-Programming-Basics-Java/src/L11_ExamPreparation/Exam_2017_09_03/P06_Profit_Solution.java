package L11_ExamPreparation.Exam_2017_09_03;

import java.util.Scanner;

public class P06_Profit_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int coins1 = Integer.parseInt(scanner.nextLine());
        int coins2 = Integer.parseInt(scanner.nextLine());
        int bankNotes = Integer.parseInt(scanner.nextLine());
        int total = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i <= coins1 ; i++) {
            for (int j = 0; j <= coins2; j++) {
                for (int k = 0; k <= bankNotes; k++) {
                    int temp = i*1 + j*2 + k*5;
                    if(temp == total){
                        System.out.printf("%d * 1 lv. + %d * 2 lv. + %d * 5 lv. = %d lv.", i, j, k, temp);
                        System.out.println();
                    }
                }
            }
        }
    }

}
