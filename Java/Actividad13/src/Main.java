import java.util.Scanner;

public class Main {
    public static int Horas;
    public static int i;
    public static int Salario;
    public static int Total;
    public static Scanner recibirv=new Scanner(System.in);
    public static void main(String[] args) {
        for (i=1; i == 50; i++){
            System.out.println("Ingresa las horas trabajadas:");
            Horas= recibirv.nextInt();
            Salario=Horas*100;
            Total=Total+Salario;
        }
        System.out.println("El salario total a pagar es:$" + Total);
    }
}