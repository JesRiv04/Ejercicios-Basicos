import java.util.Scanner;

public class Main {
    public static int C;
    public static int N;
    public static int S;
    public static Double P;

    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
       do {
           System.out.println("Ingrese una nota:");
           N= recibirv.nextInt();
           C=C+1;
           S=S+N;
       }while (N!=0);
       P= (double) (S/C);
       System.out.println("El promedio es:" + P);
    }
}