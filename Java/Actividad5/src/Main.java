import java.util.Scanner;

public class Main {
    public static Double R;
    public static Double H;
    public static Double A;
    public static Double V;
    public static Double PI=3.1416;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa el Valor del radio:");
        R= recibirv.nextDouble();
        System.out.println("Ingresa el Valor de la altura:");
        H= recibirv.nextDouble();
        A=2*PI*R*(R+H);
        V=PI*(R*R)*H;
        System.out.println("El Area es:"+ A );
        System.out.println("El Volumen es:"+ V );

    }
}