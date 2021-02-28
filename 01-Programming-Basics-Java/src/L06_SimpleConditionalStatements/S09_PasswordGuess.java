package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S09_PasswordGuess {

    public static void main(String[] args) {

        String pass = "s3cr3t!P@ssw0rd";

        Scanner scanner = new Scanner(System.in);

        String tryPass = scanner.nextLine();

        if(tryPass.equals(pass)){
            System.out.println("Welcome");
        }else{
            System.out.println("Wrong password!");
        }
    }

}
