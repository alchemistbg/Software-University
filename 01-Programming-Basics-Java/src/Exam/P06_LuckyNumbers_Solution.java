package Exam;

import java.util.Scanner;

public class P06_LuckyNumbers_Solution {

    // 100/100

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int checkDigit = Integer.parseInt(scanner.nextLine());

        for (int i = 1; i < 10; i++) {
            for (int j = 1; j < 10; j++) {
                for (int k = 1; k < 10; k++) {
                    for (int l = 1; l < 10; l++) {
                        if((i+j) == (k+l) && checkDigit%(i+j) == 0){
                            String lucky = "" + i + j + k + l;
                            if(lucky.length() < 5){
                                System.out.printf("%d%d%d%d", i, j, k, l);
                                System.out.printf(" ");
                            }
                        }
                    }
                }
            }
        }
    }

}
