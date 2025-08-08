import java.util.Scanner;

public class Main {
    public static int R;
    public static int N;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa un valor:");
        N= recibirv.nextInt();
        R=2%N;
        if (R==0){
            System.out.println("El numero es par");
        }else {
            System.out.println("El numero es impar");
        }
    }
}