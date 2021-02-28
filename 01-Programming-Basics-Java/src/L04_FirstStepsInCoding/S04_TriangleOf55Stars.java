package L04_FirstStepsInCoding;

public class S04_TriangleOf55Stars {

    public static void main(String[] args) {
        String s = "";
        for(int i = 1; i <= 10; i++){
            s = new String(new char[i]).replace("\0", "*");
            System.out.println(s);
        }
    }

}
