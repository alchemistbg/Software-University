package L09_DrawingFiguresWithLoops;

public class S01_RectangleOf10x10Stars {

    public static void main(String[] args) {
        for(int i = 0; i < 10; i++){
            System.out.println(str("*", 10));
        }

    }

    public static String str(String str, int repeats){
        StringBuilder sb = new StringBuilder();
        String result = "";
        for (int i = 0; i < repeats; i++) {
            sb.append(str);
        }
        return sb.toString();
    }

}
