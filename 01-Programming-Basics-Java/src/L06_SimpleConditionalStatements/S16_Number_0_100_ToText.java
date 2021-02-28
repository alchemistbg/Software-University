package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S16_Number_0_100_ToText {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String s = scanner.nextLine();
        String num1 = "";
        String num2 = "";


        if(Integer.parseInt(s) > 100){
            System.out.println("invalid number");
        }else if(Integer.parseInt(s) < 0){
            System.out.println("invalid number");
        }else if(Integer.parseInt(s) == 0){
            System.out.println("zero");
        }else if(Integer.parseInt(s) == 1){
            System.out.println("one");
        }else if(Integer.parseInt(s) == 2){
            System.out.println("two");
        }else if(Integer.parseInt(s) == 3){
            System.out.println("three");
        }else if(Integer.parseInt(s) == 4){
            System.out.println("four");
        }else if(Integer.parseInt(s) == 5){
            System.out.println("five");
        }else if(Integer.parseInt(s) == 6){
            System.out.println("seven");
        }else if(Integer.parseInt(s) == 8){
            System.out.println("eight");
        }else if(Integer.parseInt(s) == 9){
            System.out.println("nine");
        }else if(Integer.parseInt(s) == 10){
            System.out.println("ten");
        }else if(Integer.parseInt(s) == 11){
            System.out.println("eleven");
        }else if(Integer.parseInt(s) == 12){
            System.out.println("twelve");
        }else if(Integer.parseInt(s) == 13){
            System.out.println("thirteen");
        }else if(Integer.parseInt(s) == 14){
            System.out.println("fourteen");
        }else if(Integer.parseInt(s) == 15){
            System.out.println("fifteen");
        }else if(Integer.parseInt(s) == 16){
            System.out.println("sixteen");
        }else if(Integer.parseInt(s) == 17){
            System.out.println("seventeen");
        }else if(Integer.parseInt(s) == 18){
            System.out.println("eighteen");
        }else if(Integer.parseInt(s) == 19){
            System.out.println("nineteen");
        }else if(Integer.parseInt(s) == 100){
            System.out.println("one hundred");
        }else{
            if(Integer.parseInt(s) > 19){
                if(s.startsWith("2")){
                    num1 = "twenty";
                }else if(s.startsWith("3")){
                    num1 = "thirty";
                }else if(s.startsWith("4")){
                    num1 = "forty";
                }else if(s.startsWith("5")){
                    num1 = "fifty";
                }else if(s.startsWith("6")){
                    num1 = "sixty";
                }else if(s.startsWith("7")){
                    num1 = "seventy";
                }else if(s.startsWith("8")){
                    num1 = "eighty";
                }else if(s.startsWith("9")){
                    num1 = "ninety";
                }

                if(s.endsWith("1")){
                    num2 = "one";
                }else if(s.endsWith("2")){
                    num2 = "two";
                }else if(s.endsWith("3")){
                    num2 = "three";
                }else if(s.endsWith("4")){
                    num2 = "four";
                }else if(s.endsWith("5")){
                    num2 = "five";
                }else if(s.endsWith("6")){
                    num2 = "six";
                }else if(s.endsWith("7")){
                    num2 = "seven";
                }else if(s.endsWith("8")){
                    num2 = "eight";
                }else if(s.endsWith("9")){
                    num2 = "nine";
                }

            }
            if(s.endsWith("0")){
                System.out.printf("%s", num1);
            }else {
                System.out.printf("%s %s", num1, num2);
            }
        }
    }

}
