package L06_SimpleConditionalStatements;

import java.util.Scanner;

public class S08_MetricConverter {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double input = Double.parseDouble(scanner.nextLine());
        String from = scanner.nextLine();
        String to = scanner.nextLine();
        double temp = 0.0;
        double output = 0.0;

        if("mm".equals(from)){
            temp = input/1000;
        }else if("cm".equals(from)){
            temp = input/100;
        }else if("mi".equals(from)){
            temp = input/0.000621371192;
        }else if("in".equals(from)){
            temp = input/39.37007874015748;
        }else if("km".equals(from)){
            temp = input/0.001;
        }else if("ft".equals(from)){
            temp = input/3.2808399;
        }else if("yd".equals(from)){
            temp = input/1.0936133;
        }else{
            temp = input;
        }

        if("mm".equals(to)){
            output = temp*1000;
        }else if("cm".equals(to)){
            output = temp*100;
        }else if("mi".equals(to)){
            output = temp*0.000621371192;
        }else if("in".equals(to)){
            output = temp*39.37007874015748;
        }else if("km".equals(to)){
            output = temp*0.001;
        }else if("ft".equals(to)){
            output = temp*3.2808399;
        }else if("yd".equals(to)){
            output = temp*1.0936133;
        }else {
            output = temp;
        }

        System.out.printf("%.08f %s", output, to);
    }

}
