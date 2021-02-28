package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S11_EqualWords {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String w1 = scanner.nextLine();
        String w2 = scanner.nextLine();

        if(w1.equalsIgnoreCase(w2)){
            System.out.println("yes");
        }else{
            System.out.println("no");
        }
    }

}
