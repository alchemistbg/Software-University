package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S15_3_EqualNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = Integer.parseInt(scanner.nextLine());
        int b = Integer.parseInt(scanner.nextLine());
        int c = Integer.parseInt(scanner.nextLine());

        if(a == b){
            if(b == c){
                System.out.println("Yes");
            }else{
                System.out.println("no");
            }
        }else{
            System.out.println("no");
        }
    }

}
