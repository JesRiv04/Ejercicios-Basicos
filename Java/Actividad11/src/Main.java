import java.util.Scanner;

public class Main {
    public static Double K;
    public static Double M;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa la velocidad en k/h:");
        K= recibirv.nextDouble();
        M=K*5/18;
        System.out.println("La velocidad en m/s es:" + M);
    }
}