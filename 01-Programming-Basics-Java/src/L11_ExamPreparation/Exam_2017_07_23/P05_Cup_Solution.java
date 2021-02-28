package L11_ExamPreparation.Exam_2017_07_23;

import java.util.Scanner;

public class P05_Cup_Solution {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n/2; i++) {
            System.out.print(repeatString(n+i, "."));
            System.out.print(repeatString(3*n-i*2, "#"));
            System.out.print(repeatString(n+i, "."));
            System.out.println();
        }

        for (int i = 0; i < n/2+1; i++) {
            System.out.print(repeatString(n+n/2+i, "."));
            System.out.print("#");
            System.out.print(repeatString(2*n-2-2*i, "."));
            System.out.print("#");
            System.out.println(repeatString(n+n/2+i, "."));
        }
        System.out.println(repeatString(2*n, ".") + repeatString(n, "#") + repeatString(2*n, "."));

        for (int i = 0; i < n+2; i++) {
            if(i == n/2){
                System.out.print(repeatString((5*n-12)/2+1,"."));
                System.out.print("D^A^N^C^E^");
                System.out.println(repeatString((5*n-12)/2+1,"."));
            }else{
                System.out.print(repeatString(2*n-2,"."));
                System.out.print(repeatString(n+4,"#"));
                System.out.println(repeatString(2*n-2,"."));
            }
        }
    }

    public static String repeatString(int n, String s){
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++) {
            sb.append(s);
        }
        return sb.toString();
    }

}
