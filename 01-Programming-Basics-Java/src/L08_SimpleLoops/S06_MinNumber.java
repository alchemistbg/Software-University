package L08_SimpleLoops;

import java.util.Scanner;

public class S06_MinNumber {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int iter = Integer.parseInt(scanner.nextLine());
        int minNum = Integer.parseInt(scanner.nextLine());
        int num;

        for(int i = 1; i < iter; i++){
            num = Integer.parseInt(scanner.nextLine());
            if(num < minNum){
                minNum = num;
            }else{
            }
        }
        System.out.println(minNum);
    }

}
