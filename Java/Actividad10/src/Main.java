import java.util.Scanner;
public class Main {
    public static Double Entrada;
    public static Double Salida;
    public static Double Tiempo;
    public static Double R;
    public static Double Monto=0.00;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa la hora de entrada:");
        Entrada= recibirv.nextDouble();
        System.out.println("Ingresa la hora de salida:");
        Salida= recibirv.nextDouble();
        Tiempo=Salida-Entrada;
        R=Tiempo%1;
        if (R==0){
            Tiempo=Tiempo+1;
            if (Tiempo==1){
                Monto=15.00;
            }else {
                Monto=15.00+(Tiempo-1)*10;
            }
        }else {
            if (Tiempo==1){
                Monto=15.00;
            }else {
                Monto=15.00+(Tiempo-1)*10;
            }
        }
        System.out.println("El monto a pagar es:$" + Monto);
    }
}