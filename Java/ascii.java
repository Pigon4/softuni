import java.util.Scanner;

public class ascii {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int lenght = Integer.parseInt(scanner.nextLine());
        int sum = 0 ;
        for (int i = 0; i < lenght; i++)
        {
            char symbol = scanner.nextLine().charAt(0);
            sum = sum + (int)symbol;
        }
        System.out.printf("The sum equals: %s", sum);
    }
}
