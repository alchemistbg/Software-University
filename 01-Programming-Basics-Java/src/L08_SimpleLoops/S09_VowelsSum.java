package L08_SimpleLoops;

import java.util.Scanner;

public class S09_VowelsSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String string = scanner.nextLine();

        int sum = 0;

        for (int i = 0; i < string.length(); i++){
            if(string.charAt(i) == 'a'){
                sum = sum + 1;
            }else if(string.charAt(i) == 'e'){
                sum = sum + 2;
            }else if(string.charAt(i) == 'i'){
                sum = sum + 3;
            }else if(string.charAt(i) == 'o'){
                sum = sum + 4;
            }else if(string.charAt(i) == 'u'){
                sum = sum + 5;
            }else{

            }
        }
        System.out.println(sum);
    }

}
