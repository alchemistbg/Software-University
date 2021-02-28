package L11_ExamPreparation.Exam_2017_07_23;

import java.util.Scanner;

public class P06_GroupName_Solution {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        char first = scanner.nextLine().charAt(0);
        char second = scanner.nextLine().charAt(0);
        char third = scanner.nextLine().charAt(0);
        char fourth = scanner.nextLine().charAt(0);
        int num = Integer.parseInt(scanner.nextLine());

        int iter = 0;

        for (char a = 'A'; a <= first; a++) {
            //System.out.print(a);
            for (char b = 'a'; b <= second; b++) {
                //System.out.print(b);
                for (char c = 'a'; c <= third; c++) {
                    //System.out.print(c);
                    for (char d = 'a'; d <= fourth; d++) {
                        //System.out.print(d);
                        for (int m = 0; m <= num; m++) {
                            //System.out.println(m);
                            iter++;
                        }
                    }
                }
            }
        }
        System.out.println(iter-1);
    }

}
