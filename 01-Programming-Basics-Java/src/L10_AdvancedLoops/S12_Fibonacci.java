package L10_AdvancedLoops;

import java.util.Scanner;

public class S12_Fibonacci {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        if (n < 2){
            System.out.println(1);
        }else{
            int prevFibNum = 1;
            int currFibNum = 1;
            int fibNumber = 0;
            while (n >= 0){
                prevFibNum = currFibNum;
                currFibNum = fibNumber;
                fibNumber = prevFibNum + currFibNum;
                n--;
            }

            fibNumber = prevFibNum + currFibNum;
            System.out.println(fibNumber);
        }
    }

}
