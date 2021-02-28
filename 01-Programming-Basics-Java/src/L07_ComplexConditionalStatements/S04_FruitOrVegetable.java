package L07_ComplexConditionalStatements;

import java.util.Scanner;

public class S04_FruitOrVegetable {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        boolean isFruit = "banana".equals(input) || "apple".equals(input) ||
                "kiwi".equals(input) || "cherry".equals(input) ||
                "lemon".equals(input) || "grapes".equals(input);
        boolean isVegetable = "tomato".equals(input) || "cucumber".equals(input) ||
                "pepper".equals(input) || "carrot".equals(input);

        if(isFruit) {
            System.out.println("fruit");
        }else if (isVegetable) {
            System.out.println("vegetable");
        }else {
            System.out.println("unknown");
        }
    }

}
