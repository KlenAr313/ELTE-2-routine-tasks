import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class VehicleStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("game.vehicles.Vehicle")
            .thatIs(NOT_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL);
    }

    @Test
    public void fieldCurrentId() {
        it.hasField("currentId", ofType("int"))
            .thatIs(USABLE_WITHOUT_INSTANCE, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHasNo(GETTER, SETTER);
    }

    @Test
    public void fieldId() {
        it.hasField("id", ofType("int"))
            .thatIs(INSTANCE_LEVEL, NOT_MODIFIABLE, VISIBLE_TO_SUBCLASSES)
            .thatHasNo(GETTER, SETTER);
    }

    @Test
    public void fieldCurrentSpeed() {
        it.hasField("currentSpeed", ofType("double"))
            .thatIs(INSTANCE_LEVEL, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHas(GETTER)
            .thatHasNo(SETTER);
    }

    @Test
    public void constructor() {
        it.hasConstructor(withNoArgs())
            .thatIs(VISIBLE_TO_SUBCLASSES);
    }

    @Test
    public void methodAccelerate() {
        it.hasMethod("accelerate", withParams("double"))
            .thatIs(NOT_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatReturnsNothing();
    }

    @Test
    public void methodAccelerateCurrentSpeed() {
        it.hasMethod("accelerateCurrentSpeed", withParams("double"))
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_SUBCLASSES)
            .thatReturnsNothing();
    }
}

