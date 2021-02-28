package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S08_TradeComissions {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String city = scanner.nextLine().toLowerCase();
        double sales = Double.parseDouble(scanner.nextLine());

        boolean com1 = sales >= 0 && sales <= 500;
        boolean com2 = sales > 500 && sales <= 1000;
        boolean com3 = sales > 1000 && sales <= 10000;
        boolean com4 = sales > 10000;

        double comission = -1;

        if("sofia".equals(city)){
            if(com1){
                comission = 0.05*sales;
                System.out.printf("%.02f", comission);
            }else if(com2){
                comission = 0.07*sales;
                System.out.printf("%.02f", comission);
            }else if(com3){
                comission = 0.08*sales;
                System.out.printf("%.02f", comission);
            }else if(com4){
                comission = 0.12*sales;
                System.out.printf("%.02f", comission);
            }else{
                System.out.println("error");
            }
        }else if("varna".equals(city)){
            if(com1){
                comission = 0.045*sales;
                System.out.printf("%.02f", comission);
            }else if(com2){
                comission = 0.075*sales;
                System.out.printf("%.02f", comission);
            }else if(com3){
                comission = 0.1*sales;
                System.out.printf("%.02f", comission);
            }else if(com4){
                comission = 0.13*sales;
                System.out.printf("%.02f", comission);
            }else{
                System.out.println("error");
            }
        }else if("plovdiv".equals(city)){
            if(com1){
                comission = 0.055*sales;
                System.out.printf("%.02f", comission);
            }else if(com2){
                comission = 0.08*sales;
                System.out.printf("%.02f", comission);
            }else if(com3){
                comission = 0.12*sales;
                System.out.printf("%.02f", comission);
            }else if(com4){
                comission = 0.145*sales;
                System.out.printf("%.02f", comission);
            }else{
                System.out.println("error");
            }
        }else{
            System.out.println("error");
        }
    }

}
