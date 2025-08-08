import java.util.Scanner;

public class Main {
    public static int Dias;
    public static int Semanas;
    public static int Meses;
    public static int Años;
    public static int T;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa el numero de dias:");
        T=recibirv.nextInt();
        while (T>=365){
            T=T-365;
            Años=Años+1;
        }
        while (T>=30){
            T=T-30;
            Meses=Meses+1;
        }
        while (T>=7){
            T=T-7;
            Semanas=Semanas+1;
        }
        Dias=T;
        System.out.println("El tiempo es Años:" + Años + " Meses:" + Meses + " Semanas:" + Semanas
        + " Dias:" + Dias);
    }
}