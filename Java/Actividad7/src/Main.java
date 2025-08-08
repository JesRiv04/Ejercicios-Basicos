import java.util.Scanner;

public class Main {
    public static int N;
    public static Scanner recibirV=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingresa la calificaion:");
        N=recibirV.nextInt();
        if (N<21&&N>0){
            if (N<21&&N>18){
                System.out.println("La nota es A");
            }else {
                if (N<19&&N>15){
                    System.out.println("la nota es B");
                }else {
                    if (N<16&&N>12){
                        System.out.println("La nota es C");
                    }else {
                        if (N<13&&N>9){
                            System.out.println("la nota es D");
                        }else {
                            if (N<10&&N>0){
                                System.out.println("La nota es E");
                            }else {
                                System.out.println("La nota es invalida");
                            }
                        }
                    }
                }
            }
        }else {
            System.out.println("La calificacion es invalida");
        }
    }
}