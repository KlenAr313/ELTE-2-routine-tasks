import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class VehicleExceptionStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theCheckedException("game.utils.VehicleException")
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL);
    }

    @Test
    public void constructor01() {
        it.hasConstructor(withNoArgs())
            .thatIs(VISIBLE_TO_ALL);
    }

    @Test
    public void constructor02() {
        it.hasConstructor(withArgs("String"))
            .thatIs(VISIBLE_TO_ALL);
    }
}

