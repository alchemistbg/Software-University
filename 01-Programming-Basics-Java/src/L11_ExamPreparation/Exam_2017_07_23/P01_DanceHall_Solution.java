package L11_ExamPreparation.Exam_2017_07_23;

import java.util.Scanner;

public class P01_DanceHall_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double L = Double.parseDouble(scanner.nextLine())*100;
        double W = Double.parseDouble(scanner.nextLine())*100;
        double wardrobe = Double.parseDouble(scanner.nextLine())*100;

        double hallSurface = L*W;
        double wardrobeSurface = wardrobe*wardrobe;
        double benchSurface = hallSurface/10;

        double freeSpace = hallSurface - wardrobeSurface - benchSurface;

        int dancerSpace = 7040;

        int totalDancers = (int)freeSpace / dancerSpace;
        System.out.println(totalDancers);
    }

}
