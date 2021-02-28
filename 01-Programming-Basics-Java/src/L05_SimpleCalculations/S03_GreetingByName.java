package L05_SimpleCalculations;

import java.util.Scanner;

public class S03_GreetingByName {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();
        System.out.printf("Hello, %s!", name);
    }

}
