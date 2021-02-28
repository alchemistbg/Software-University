package L08_SimpleLoops;

import java.util.Scanner;

public class S04_SumNumbers {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int iter = Integer.parseInt(scanner.nextLine());
        int result = 0;
        int num = 0;

        for(int i = 0; i < iter; i++){
            num = Integer.parseInt(scanner.nextLine());
            result = result + num;
        }
        System.out.println(result);
    }

}
