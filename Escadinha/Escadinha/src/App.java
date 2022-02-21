import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {

        Scanner entrada = new Scanner(System.in);
        System.out.println("Digite a quantidade de Degraus: ");
        int veses = entrada.nextInt();

        for (int i = 0; i < veses; i++) {

            System.out.println("");

            for (int j = 0; j <= i; j++) {

                System.out.print("*");
            }
        }
        System.in.read();
    }
}
