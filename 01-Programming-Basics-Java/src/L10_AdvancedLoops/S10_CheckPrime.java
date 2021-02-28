package L10_AdvancedLoops;

import java.util.Scanner;

public class S10_CheckPrime {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        if(n < 2){
            System.out.println("Not Prime");
        }else{
            int lowerLimit = 2;
            int upperLimit = (int)Math.sqrt(n);
            boolean hasResidual = true;
            while(upperLimit >= lowerLimit){
                if(n % lowerLimit == 0){
                    hasResidual = false;
                    break;
                }
                lowerLimit++;
            }
            if(hasResidual) {
                System.out.println("Prime");
            }else{
                System.out.println("Not Prime");
            }
        }
    }

}
