package L08_SimpleLoops;

import java.util.Scanner;

public class S10_HalfSumElement {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int maxNum = 0;
        int temp = 0;
        int sum = 0;

        int iter = Integer.parseInt(scanner.nextLine());

        for(int i = 0; i < iter; i++){
            temp = Integer.parseInt(scanner.nextLine());
            sum = sum + temp;
            if(maxNum < temp){
                maxNum = temp;
            }
        }

        sum = sum - maxNum;


        if(sum == maxNum){
            System.out.println("Yes");
            System.out.printf("Sum = %d", sum);
        }else{
            System.out.println("No");
            System.out.printf("Diff = %d", Math.abs(sum - maxNum));
        }
    }

}
