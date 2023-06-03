import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class CarStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("game.vehicles.Car", withParent("game.vehicles.Vehicle"), withInterface("java.lang.Comparable"))
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatHas(TEXTUAL_REPRESENTATION);
    }

    @Test
    public void fieldMaxSpeed() {
        it.hasField("maxSpeed", ofType("int"))
            .thatIs(INSTANCE_LEVEL, NOT_MODIFIABLE, VISIBLE_TO_NONE)
            .thatHasNo(GETTER, SETTER);
    }

    @Test
    public void fieldCost() {
        it.hasField("cost", ofType("int"))
            .thatIs(INSTANCE_LEVEL, NOT_MODIFIABLE, VISIBLE_TO_NONE)
            .thatHas(GETTER)
            .thatHasNo(SETTER);
    }

    @Test
    public void fieldOwner() {
        it.hasField("owner", ofType("game.Player"))
            .thatIs(INSTANCE_LEVEL, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHas(GETTER, SETTER);
    }

    @Test
    public void constructor() {
        it.hasConstructor(withArgs("int", "int"))
            .thatIs(VISIBLE_TO_ALL);
    }

    @Test
    public void methodAccelerate() {
        it.hasMethod("accelerate", withParams("double"))
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatReturnsNothing();
    }

    @Test
    public void methodCompareTo() {
        it.hasMethod("compareTo", withParams("Car"))
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatReturns("int");
    }
}

