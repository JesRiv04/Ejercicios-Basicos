import java.util.Scanner;

public class Main {
    public  static int V1;
    public  static int V2;
    public  static Scanner recibirV = new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingrese el primer valor:");
        V1= recibirV.nextInt();
        System.out.println("Ingrese el segundo valor:");
        V2= recibirV.nextInt();
        if(V1>V2){
            System.out.println(V1 + " Es mayor");
        } else {
            System.out.println(V2 + " Es mayor");
        }
    }
}