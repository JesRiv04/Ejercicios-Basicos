import java.util.Scanner;

public class Main {
    public static int A;
    public static int B;
    public static double H;
    public static Scanner recibirV=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa el Valor del cateto A:");
        A=recibirV.nextInt();
        System.out.println("Ingresa el Valor del cateto B:");
        B=recibirV.nextInt();
        H=(A*A)+(B*B);
        H=Math.sqrt(H);
        System.out.println("La hipotenusa es:"+ H);
    }
}