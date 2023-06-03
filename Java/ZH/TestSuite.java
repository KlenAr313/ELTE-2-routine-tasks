import org.junit.platform.suite.api.SelectClasses;
import org.junit.platform.suite.api.Suite;

@Suite
@SelectClasses({
		tests.Tests.class, //Létre kell hozni, lásd feladatleírás
		
		CarStructureTest.class,
		PlayerStructureTest.class,
		TrainStructureTest.class,
		VehicleExceptionStructureTest.class,
		VehicleStructureTest.class
})
public class TestSuite {}
