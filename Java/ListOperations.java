import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class ListOperations {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" ")).map(Integer::parseInt).collect(Collectors.toList());
        String input = scanner.nextLine();
        while(!input.equals("End"))
        {
            if (input.contains("Add"))
            {
                    numbers.add(Integer.parseInt(input.split(" ")[1]));  //ADD
            }else if (input.contains("Remove"))
            {
                if (isValid(numbers, Integer.parseInt(input.split(" ")[1])))
                {
                    numbers.remove(Integer.parseInt(input.split(" ")[1])); // REMOVE
                }
            }else if (input.contains("Shift left"))
            {
                int con = Integer.parseInt(input.split(" ")[2]);
                for (int i = 0; i < con; i++)
                {
                    int first = numbers.get(0);
                    numbers.add(first);
                    numbers.remove(0);
                }                                   //FIRST BECOMES LAST
            }else if (input.contains("Shift right"))
            {
                int con = Integer.parseInt(input.split(" ")[2]);
                for (int i = 0; i < con; i++)
                {
                    int last = numbers.get(numbers.size()- 1);
                    numbers.add(0, last);
                    numbers.remove(numbers.size() - 1);
                }                                   //LAST BECOMES FIRST
            }else
            {
                if (isValid(numbers, Integer.parseInt(input.split(" ")[2])))
                {
                    numbers.add(Integer.parseInt(input.split(" ")[2]), Integer.parseInt(input.split(" ")[1]));      //INSERT
                }

            }

            input = scanner.nextLine();
        }

        for (int n : numbers)
        {
            System.out.printf("%s ", n);
        }
    }
    public static boolean isValid(List<Integer> numbers, int n)
    {
        if (n < numbers.size() && n > -1)
        {
            return true;
        }
        System.out.println("Invalid index");
        return  false;
    }

}
