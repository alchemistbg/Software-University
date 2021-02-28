package L08_SimpleLoops;

import java.text.DecimalFormat;
import java.util.Scanner;

public class S11_OddEvenPosition {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        DecimalFormat df = new DecimalFormat("0.##");

        int iter = Integer.parseInt(scanner.nextLine());
        double oddMin = 1000000000, oddMax = -1000000000, oddSum = 0;
        double evenMin = 1000000000, evenMax = -1000000000, evenSum = 0;

        double temp = 0;

        for(int i = 1; i < iter+1; i++) {
            temp = Double.parseDouble(scanner.nextLine());
            if(i%2 != 0){
                if(temp < oddMin){
                    oddMin = temp;
                }
                if(oddMax < temp){
                    oddMax = temp;
                }
                oddSum = oddSum + temp;
            }else{
                if(temp < evenMin){
                    evenMin = temp;
                }
                if(evenMax < temp){
                    evenMax = temp;
                }
                evenSum = evenSum + temp;
            }
        }

        System.out.println("OddSum=" + df.format(oddSum));
        if(oddMin == 1000000000){
            System.out.println("OddMin=No");
        }else{
            System.out.println("OddMin=" + df.format(oddMin));
        }

        if(oddMax == -1000000000){
            System.out.println("OddMax=No");
        }else{
            System.out.println("OddMax=" + df.format(oddMax));
        }

        System.out.println("EvenSum=" + df.format(evenSum));
        if(evenMin == 1000000000){
            System.out.println("EvenMin=No");
        }else{
            System.out.println("EvenMin=" + df.format(evenMin));
        }

        if(evenMax == -1000000000){
            System.out.println("EvenMax=No");
        }else{
            System.out.println("EvenMax=" + df.format(evenMax));
        }
    }

}
