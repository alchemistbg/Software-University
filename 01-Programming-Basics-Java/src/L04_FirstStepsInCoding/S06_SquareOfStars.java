package L04_FirstStepsInCoding;

import java.util.Scanner;

public class S06_SquareOfStars {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        String flLine = new String(new char[n]).replace("\0", "*");
        System.out.println(flLine);
        for (int i = 1; i <= n-2; i++) {
            String spaces = new String (new char[n-2]).replace("\0", " ");
            System.out.println("*" + spaces + "*");
        }

        System.out.println(flLine);
    }

}
