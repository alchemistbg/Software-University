package L11_ExamPreparation.Exam_2017_09_17;

import java.util.Scanner;

public class P01_Birthday_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int length = Integer.parseInt(scanner.nextLine());
        int width = Integer.parseInt(scanner.nextLine());
        int heigth = Integer.parseInt(scanner.nextLine());
        double percentage = Double.parseDouble(scanner.nextLine());

        int volumeCM = length*width*heigth;
        double volume = length*width*heigth*1.0/1000;

        double water = volume - volume*percentage/100;

        System.out.printf("%.3f", water);
    }

}
