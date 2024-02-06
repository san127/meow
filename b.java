import static org.junit.Assert.assertArrayEquals;

import org.junit.Test;

public class b {
  @Test
  public void testmeth() {
    assertArrayEquals(new int[] { 4, 5, 2, 1 }, a.revArr(new int[] { 1, 2, 3, 4 }));
  }
}