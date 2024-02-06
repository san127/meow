public class a {
  public static void main(String[] args) {
    System.out.println("hello");
    int[] a = new int[5];
    a = revArr(new int[] { 1, 2, 3, 4, 5 });
    for (int i = 0; i < a.length; i++) {
      System.out.print(" | " + a[i]);
    }
  }

  public static int[] revArr(int[] input) {
    int[] temp = new int[input.length];
    int i, size = input.length, j = size;
    for (i = 0; i < size; i++) {
      temp[j - 1] = input[i];
      j = j - 1;
    }
    return temp;
  }
}