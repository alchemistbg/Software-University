package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S12_Volleyball {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String yearType = scanner.nextLine();
        double holidays = Double.parseDouble(scanner.nextLine());
        double weekends2home = Double.parseDouble(scanner.nextLine());

        int weekends = 48;

        double weekends2sofia = weekends - weekends2home;

        double weekends2sofiaFREE = weekends2sofia*3/4;
        double holidays2volley = holidays*2/3;

        double volleyDays = weekends2home + weekends2sofiaFREE + holidays2volley;

        if("leap".equals(yearType)){
            volleyDays = volleyDays + volleyDays*0.15;
        }

        volleyDays = Math.floor(volleyDays);
        System.out.printf("%.0f", volleyDays);
    }

}
