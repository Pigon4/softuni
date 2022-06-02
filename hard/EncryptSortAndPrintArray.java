import java.util.Scanner;
import java.util.Arrays;

public class EncryptSortAndPrintArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        String word;
        int sum = 0;
        int[] sumArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            word = scanner.nextLine();
            char[] enWord = word.toCharArray();
            for (char letter : enWord) {
                if (isVowel(letter))
                {
                    sum += (int)letter * word.length();
                }else
                {
                    sum +=(int)letter / word.length();
                }
            }
            sumArr[i] = sum;
            sum = 0;
        }
        Arrays.sort(sumArr);
        for (int i = 0; i < n; i++)
        {
            System.out.println(sumArr[i]);
        }
    }
    public static boolean isVowel(char letter)
    {
        String all = "aeiouAEIOU";
        if (all.contains(letter + ""))
        {
            return true;
        }
        return false;
    }

}
