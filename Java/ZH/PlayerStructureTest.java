import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class PlayerStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("game.Player")
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatHas(TEXTUAL_REPRESENTATION);
            //.thatHas(EQUALITY_CHECK);
    }

    @Test
    public void fieldName() {
        it.hasField("name", ofType("String"))
            .thatIs(INSTANCE_LEVEL, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHasNo(GETTER, SETTER);
    }

    @Test
    public void fieldIp() {
        it.hasField("ip", ofType("String"))
            .thatIs(INSTANCE_LEVEL, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHasNo(GETTER, SETTER);
    }

    @Test
    public void fieldMoney() {
        it.hasField("money", ofType("int"))
            .thatIs(INSTANCE_LEVEL, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHas(GETTER)
            .thatHasNo(SETTER);
    }

    @Test
    public void fieldCars() {
        it.hasField("cars", ofType("ArrayList"))
            .thatIs(INSTANCE_LEVEL, MODIFIABLE, VISIBLE_TO_NONE)
            .thatHasNo(GETTER, SETTER);
    }

    @Test
    public void constructor() {
        it.hasConstructor(withArgs("String", "String", "int"))
            .thatIs(VISIBLE_TO_ALL);
    }

    @Test
    public void methodBuyCar() {
        it.hasMethod("buyCar", withParams("game.vehicles.Car"))
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatReturnsNothing();
    }

    @Test
    public void methodGetSortedCars() {
        it.hasMethod("getSortedCars", withNoParams())
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL)
            .thatReturns("ArrayList");
    }
}

