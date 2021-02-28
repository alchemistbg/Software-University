package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S10_Number_100_200 {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int i = Integer.parseInt(scanner.nextLine());

        if(i > 200) {
            System.out.println("Greater than 200");
        }else if(i < 100){
            System.out.println("Less than 100");
        }else{
            System.out.println("Between 100 and 200");
        }
    }

}
