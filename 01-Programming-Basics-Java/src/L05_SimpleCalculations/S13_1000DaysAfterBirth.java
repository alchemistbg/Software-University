package L05_SimpleCalculations;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

public class S13_1000DaysAfterBirth {

    public static void main(String[] args) {

        Scanner s= new Scanner(System.in);
        String da = s.nextLine();

        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("dd-MM-yyyy");
        //dtf = dtf.withLocale(Locale.ROOT);

        LocalDate d = LocalDate.parse(da,dtf);
        long l = 1000;
        d = d.plusDays(1000-1);


        System.out.println(d.format(dtf));

    }

}
