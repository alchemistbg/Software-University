package L08_SimpleLoops;

import java.util.Scanner;

public class S08_OddEvenSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int iter = Integer.parseInt(scanner.nextLine());

        int oddSum = 0;
        int evenSum = 0;

        for(int i = 0; i < iter; i ++){
            if((i % 2) != 0){
                oddSum = oddSum + Integer.parseInt(scanner.nextLine());
            }else{
                evenSum = evenSum + Integer.parseInt(scanner.nextLine());
            }
        }

        if(oddSum == evenSum){
            System.out.printf("Yes, sum = %d", (oddSum));
        }else{
            System.out.printf("No, diff = %d", Math.abs(oddSum-evenSum));
        }
    }

}
