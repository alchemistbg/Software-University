package L08_SimpleLoops;

import java.util.Scanner;

public class S12_EqualPairs {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int iter = Integer.parseInt(scanner.nextLine());

        int num1 = 0;
        int num2 = 0;

        int sum = 0;
        int oldSum = 0;

        int diff = 0;
        int oldDiff = 0;

        if(iter == 1) {
            num1 = Integer.parseInt(scanner.nextLine());
            num2 = Integer.parseInt(scanner.nextLine());
            System.out.println("Yes, value=" + (num1+num2));
        }else {

            boolean bool = false;
            for(int i = 0; i < iter*2; i++) {

                if(i % 2 == 0) {
                    num1 = Integer.parseInt(scanner.nextLine());
                }else {
                    num2 = Integer.parseInt(scanner.nextLine());
                    sum = num1 + num2;
                    if(i > 1) {
                        if(sum == oldSum) {
                            bool = true;
                        }else {
                            bool = false;
                            diff = Math.abs(sum - oldSum);
                            if(oldDiff < diff) {
                                oldDiff = diff;
                            }
                        }
                    }
                    oldSum = sum;
                }
            }

            if(bool) {
                System.out.println("Yes, value=" + sum);
            }else {
                System.out.println("No, maxdiff=" + diff);
            }
        }
    }

}
