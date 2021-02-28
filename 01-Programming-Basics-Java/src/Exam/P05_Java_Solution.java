package Exam;

import java.util.Scanner;

public class P05_Java_Solution {

    // 70/100

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        String eqString = repeatString(3*n+5, "=");

        for (int i = 0; i < n; i++) {
            System.out.print(repeatString(n-1, " "));
            System.out.println(repeatString(3, " ~"));
        }
        System.out.println(eqString);

        if(n % 2==0){
            for (int i = 0; i < n-2; i++) {
                if(i == n/2-1){
                    System.out.println("|" + repeatString(n, "~") + "JAVA" +
                            repeatString(n, "~") + "|" + repeatString(n-1, " ") + "|");
                }else{
                    System.out.println("|" + repeatString(n, "~") + "~~~~" +
                            repeatString(n, "~") + "|" + repeatString(n-1, " ") + "|");
                }
            }
        }else{
            for (int i = 0; i < n-2; i++) {
                if(i == 0 && n == 3){
                    System.out.println("|" + repeatString(n, "~") + "JAVA" +
                            repeatString(n, "~") + "|" + repeatString(n-1, " ") + "|");
                }else {
                    if(i == (n%2)){
                        System.out.println("|" + repeatString(n, "~") + "JAVA" +
                                repeatString(n, "~") + "|" + repeatString(n-1, " ") + "|");
                    }else{
                        System.out.println("|" + repeatString(n, "~") + "~~~~" +
                                repeatString(n, "~") + "|" + repeatString(n-1, " ") + "|");
                    }
                }
            }
        }
        System.out.println(eqString);

        //int z = 0;
        for (int i = 0; i < n; i++) {
            System.out.println(repeatString(i, " ") + "\\" +
                    repeatString(3*n+3-2*i-(n-1), "@") + "/");
            //z = 3*n+5-(n-1);
        }

        System.out.println(repeatString(2*n+6, "="));

    }

    public static String repeatString(int repeats, String s){
        String result = "";
        for(int i = 0; i < repeats; i++){
            result = result + s;
        }
        return result;
    }

}
