package L11_ExamPreparation.Exam_2017_09_17;

import java.util.Scanner;

public class P06_TheSongOfTheWheels_Solution {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int checkSum = Integer.parseInt(scanner.nextLine());

        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;

        int counter = 1;

        String tempPass = "";
        String pass = "";

        for (int i = 1; i < 10; i++) {
            a = i;
            for (int j = 1; j < 10; j++) {
                b = j;
                for (int k = 1; k < 10; k++) {
                    c = k;
                    for (int l = 1; l < 10; l++) {
                        d = l;
                        int tempCheskSum = 0;
                        if(a < b && c > d){
                            tempCheskSum = (a*b) + (c*d);
                        }

                        if(checkSum == tempCheskSum){
                            tempPass = "" + a+b+c+d;
                            System.out.printf("%s ", tempPass);
                            if(counter == 4){
                                pass = tempPass;
                            }
                            counter++;

                        }
                    }
                }
            }
        }

        if(!pass.isEmpty()){
            System.out.printf("%nPassword: %s", pass);
        }else{
            if(!tempPass.isEmpty())
                System.out.println("\nNo!");
        }
    }

}
