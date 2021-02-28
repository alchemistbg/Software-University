package L10_AdvancedLoops;

import java.util.Scanner;

public class S11_EnterEvenNumber {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter even number: ");
        String s = scanner.nextLine();

        boolean isNaN = true;

        while(isNaN){
            try{
                int number = Integer.parseInt(s);
                if(number % 2 != 0){
                    System.out.println("The number is not even.");
                    System.out.print("Enter even number: ");
                    s = scanner.nextLine();
                }else{
                    System.out.println("Even number entered: " + number);
                    isNaN = false;
                }
            }catch(NumberFormatException e){
                System.out.println("Invalid number!");
                System.out.print("Enter even number: ");
                s = scanner.nextLine();
            }
        }
    }

}
