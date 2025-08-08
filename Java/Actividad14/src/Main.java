import java.util.Scanner;

public class Main {
    public static int G=15;
    public static int C;
    public static int S=20;
    public static int R=25;
    public static int P1;
    public static int P2;
    public static int P3;
    public static int Total;
    public static int D;
    public static int C2;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Cantidad de Gansitos:");
        C= recibirv.nextInt();
        P1=G*C;
        System.out.println("Cantidad de Sabritas:");
        C= recibirv.nextInt();
        P2=S*C;
        System.out.println("Cantidad de Refrescos:");
        C= recibirv.nextInt();
        P3=R*C;
        Total=P1+P2+P3;
        System.out.println("Dinero Recibido:");
        D= recibirv.nextInt();
        C2=Total-D;
        System.out.println("El cambio es:$" + C2);
    }
}