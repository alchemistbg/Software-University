package Exam;

import java.util.Scanner;

public class P02_Lutenitsa_Solution {

    // 100/100

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double tomatosTotal = Double.parseDouble(scanner.nextLine());
        int truckKasetki = Integer.parseInt(scanner.nextLine());
        int kasetkaJars = Integer.parseInt(scanner.nextLine());

        double totalLutenica = tomatosTotal/5;
        double totalJars = totalLutenica/0.535;
        double totalKasetki = totalJars/kasetkaJars;


        System.out.printf("Total lutenica: %d kilograms.%n", (int)totalLutenica);
        if(truckKasetki<totalKasetki){
            int i = (int)Math.floor(totalKasetki - truckKasetki);
            System.out.printf("%d boxes left.%n", i);
            int k = (int)Math.floor(totalJars - truckKasetki*kasetkaJars);
            System.out.printf("%d jars left.%n", k);
        }else{
            int i = (int)Math.floor(truckKasetki - totalKasetki);
            System.out.printf("%d more boxes needed.%n", i);
            int k = (int)Math.floor(truckKasetki*kasetkaJars-totalJars);
            System.out.printf("%d more jars needed.%n", k);
        }
    }

}
