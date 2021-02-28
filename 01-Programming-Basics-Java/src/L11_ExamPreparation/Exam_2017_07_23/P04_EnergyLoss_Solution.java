package L11_ExamPreparation.Exam_2017_07_23;

import java.util.Scanner;

public class P04_EnergyLoss_Solution {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int days = Integer.parseInt(scanner.nextLine());
        int dancers = Integer.parseInt(scanner.nextLine());

        int numDay = 1;

        int totalEnergy = 100*days*dancers;
        int energyLoss = 0;

        while(days - numDay >= 0){
            int hours = Integer.parseInt(scanner.nextLine());
            if(numDay % 2 == 0 && hours %2 == 0){
                energyLoss = energyLoss + dancers*68;
            }
            if(numDay % 2 == 0 && hours %2 != 0){
                energyLoss = energyLoss + dancers*65;
            }
            if(numDay % 2 != 0 && hours %2 == 0){
                energyLoss = energyLoss + dancers*49;
            }
            if(numDay % 2 != 0 && hours %2 != 0){
                energyLoss = energyLoss + dancers*30;
            }
            numDay++;
        }
        int energySaved = totalEnergy - energyLoss;
        double usedEnerdyPerDancer = 1.0*energyLoss/dancers/days;
        double savedEnergyPerDancer = 1.0*energySaved/days/dancers;

        if(usedEnerdyPerDancer > 50){
            System.out.printf("They are wasted! Energy left: %.2f", savedEnergyPerDancer);
        }else{
            System.out.printf("They feel good! Energy left: %.2f", savedEnergyPerDancer);
        }
    }

}
