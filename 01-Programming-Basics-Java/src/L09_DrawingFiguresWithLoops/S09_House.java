package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S09_House {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int counts = Integer.parseInt(scanner.nextLine());

        //ROOF
        int roofRows = (counts+1)/2;
        String roofCenter = "";
        if(counts % 2 ==0){
            roofCenter = "**";
        }else{
            roofCenter = "*";
        }

        String leftRoofPart = "";
        String rightRoofPart = "";
        String roofRow = "";
        for (int i = 0; i < roofRows; i++) {
            leftRoofPart = repeatString(roofRows-i-1, "-") + repeatString(i, "*");
            rightRoofPart = repeatString(i, "*") + repeatString(roofRows-i-1, "-");
            roofRow = leftRoofPart + roofCenter + rightRoofPart;
            System.out.println(roofRow);
        }

        //BASE
        String houseBase = "|" + repeatString(counts-2, "*") + "|";
        for (int i = 0; i < counts-roofRows; i++) {
            System.out.println(houseBase);
        }

        scanner.close();
    }

    static String repeatString(int repeats, String s){
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < repeats; i++) {
            sb.append(s);
        }

        return  sb.toString();
    }

}
