import java.util.Scanner;
class Main {
    public static int A;
    public static int B;
    public static int C;
    public static Scanner recibirV=new Scanner(System.in);
    public static void main(String[] args) {
        System.out.println("Ingrese el Valor A");
        A= recibirV.nextInt();
        System.out.println("Ingrese el Valor B");
        B= recibirV.nextInt();
        System.out.println("Ingrese el Valor C");
        C= recibirV.nextInt();
        if (A==B){
            System.out.println("A y B son iguales"+A+" "+B);
        }else {
            if (A==C){
                System.out.println("A y C son iguales"+A+" "+C);
            }else {
                if (B==C){
                    System.out.println("C y B son iguales"+C+" "+B);
                }else {
                    if (A>B){
                        if (A>C){
                            System.out.println("A es Mayor");
                        }else {
                            System.out.println("C es Mayor");
                        }
                    }else{
                        if (B>C){
                            System.out.println("B es Mayor");
                        }else {
                            System.out.println("C es Mayor");
                        }

                    }
                }
            }
        }

    }
}