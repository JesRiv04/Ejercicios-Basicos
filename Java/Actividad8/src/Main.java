import java.util.Scanner;

public class Main {
    public static int A;
    public static int B;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {

        System.out.println("Ingresa el primer numero:");
        A= recibirv.nextInt();
        System.out.println("Ingresa el segundo numero:");
        B= recibirv.nextInt();
        if (A==B){
            System.out.println("Primero " + A + "luego " +  B);
        }else {
            if (A>B){
                System.out.println("Primero " + B + "luego " +  A);
            }else {
                System.out.println("Primero " + A + "luego " +  B);
            }
        }

    }
}