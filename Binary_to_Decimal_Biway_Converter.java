```java
import java.util.Scanner;

public class BinaryDecimalConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("1. Binary to Decimal");
            System.out.println("2. Decimal to Binary");
            System.out.println("3. Exit");
            System.out.print("Enter your choice: ");
            int choice = scanner.nextInt();
            switch (choice) {
                case 1:
                    System.out.print("Enter binary number: ");
                    String binary = scanner.next();
                    System.out.println("Decimal: " + Integer.parseInt(binary, 2));
                    break;
                case 2:
                    System.out.print("Enter decimal number: ");
                    int decimal = scanner.nextInt();
                    System.out.println("Binary: " + Integer.toBinaryString(decimal));
                    break;
                case 3:
                    System.exit(0);
                default:
                    System.out.println("Invalid choice");
            }
        }
    }
}
```