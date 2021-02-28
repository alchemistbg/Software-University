package L08_SimpleLoops;

import java.util.Scanner;

public class S07_LeftAndRightSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int iter = Integer.parseInt(scanner.nextLine());

        int leftSum = 0;
        int rightSum = 0;

        for(int i = 0; i < 2*iter; i ++){
            if(i < iter){
                leftSum = leftSum + Integer.parseInt(scanner.nextLine());
            }else{
                rightSum = rightSum + Integer.parseInt(scanner.nextLine());
            }
        }
        if(leftSum == rightSum){
            System.out.printf("Yes, sum = %d", (leftSum));
        }else{
            System.out.printf("No, diff = %d", Math.abs(leftSum-rightSum));
        }
    }

}
