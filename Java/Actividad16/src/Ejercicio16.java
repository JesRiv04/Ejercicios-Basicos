import java.util.Scanner;

public class Ejercicio16 {
    public static void main(String[] args) {

        int BC = 0, BV = 0, BD = 0, BC2 = 0, BM = 0, C, Resto, N;


        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingrese el valor de N: ");
        N = scanner.nextInt();
        C = N;
        while (N >= 50000) {
            BC++;
            C -= 50000;
            System.out.print("Ingrese el nuevo valor de C: ");
            C = scanner.nextInt();
            N = C;  // Actualizamos N para seguir con el siguiente paso
        }
        while (N >= 20000) {
            BV++;
            C -= 20000;
            System.out.print("Ingrese el nuevo valor de C: ");
            C = scanner.nextInt();
            N = C;
        }
        while (N >= 10000) {
            BD++;
            C -= 10000;
            System.out.print("Ingrese el nuevo valor de C: ");
            C = scanner.nextInt();
            N = C;
        }
        while (N >= 5000) {
            BC2++;
            C -= 5000;
            System.out.print("Ingrese el nuevo valor de C: ");
            C = scanner.nextInt();
            N = C;
        }
        while (N >= 1000) {
            BM++;
            C -= 1000;
            System.out.print("Ingrese el nuevo valor de C: ");
            C = scanner.nextInt();
            N = C;
        }
        Resto = C;
        System.out.printf("%d %d %d %d %d %d\n", N, BC, BV, BD, BC2, BM, Resto);
        scanner.close();
    }
}
