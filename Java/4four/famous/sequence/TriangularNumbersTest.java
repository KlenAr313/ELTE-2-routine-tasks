package famous.sequence;

import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;
//import org.junit.jupiter.ParammeterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

public class TriangularNumbersTest {
    @Test
    public void testGet() {
        int result = TriangularNumbers.getTriangularNumber(4);
        assertEquals(10, result);
    }
}