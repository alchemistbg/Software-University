package L11_ExamPreparation.Exam_2017_09_03;

import java.util.Scanner;

public class P02_Scholarship_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double income = Double.parseDouble(scanner.nextLine());
        double grades = Double.parseDouble(scanner.nextLine());
        double minSalary = Double.parseDouble(scanner.nextLine());
        double socialSholarship = 0.0;
        double exelenceSholarship = 0.0;

        boolean b = true;

        if(income < minSalary && grades > 4.5){
            socialSholarship = minSalary*0.35;
        }

        if(grades >= 5.5) {
            exelenceSholarship = grades * 25;
        }

        if(socialSholarship == 0 && exelenceSholarship ==0){
            System.out.println("You cannot get a scholarship!");
        }else{
            if(socialSholarship > exelenceSholarship){
                System.out.printf("You get a Social scholarship %d BGN", (int)socialSholarship);
            }else{
                System.out.printf("You get a scholarship for excellent results %d BGN", (int)exelenceSholarship);
            }
        }
    }

}
