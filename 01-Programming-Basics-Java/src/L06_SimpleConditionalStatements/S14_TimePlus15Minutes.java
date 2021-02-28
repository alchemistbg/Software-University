package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S14_TimePlus15Minutes {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

        int hh = Integer.parseInt(s.nextLine());
        int mm = Integer.parseInt(s.nextLine());

        mm = mm + 15;

        if(mm >= 60){
            hh++;
            mm = mm - 60;
        }

        if(hh >= 24){
            hh = hh - 24;
        }

        System.out.printf("%d:%02d", hh, mm);
    }

}
