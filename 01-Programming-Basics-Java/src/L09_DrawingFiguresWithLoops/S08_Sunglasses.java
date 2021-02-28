package L09_DrawingFiguresWithLoops;

import java.util.Scanner;

public class S08_Sunglasses {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        String topBottomStars = new String(new char[2*n]).replace('\0', '*');
        String topBottomSpaces = new String(new char[n]).replace('\0', ' ');
        String topBottom = new String(topBottomStars + topBottomSpaces + topBottomStars);

        String middleSlashes = new String(new char[2*n-2]).replace('\0', '/');
        String middleSpaces = new String(new char[n]).replace('\0', ' ');
        String middle = "*" + middleSlashes + "*" + middleSpaces + "*" + middleSlashes + "*";

        String middlePipe = new String(new char[n]).replace('\0', '|');
        String middleFrame = "*" + middleSlashes + "*" + middlePipe + "*" + middleSlashes + "*";

        for (int i = 1; i <= n; i++) {
            if(i == 1){
                System.out.println(topBottom);
            }else if(i == n){
                System.out.println(topBottom);
            }else{
                if (n%2 == 0){
                    if(i == n/2){
                        System.out.println(middleFrame);
                    }else{
                        System.out.println(middle);
                    }
                }else {
                    if(i == (n/2+1)){
                        System.out.println(middleFrame);
                    }else{
                        System.out.println(middle);
                    }
                }
            }
        }
    }

}
