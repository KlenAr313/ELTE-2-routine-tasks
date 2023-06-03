import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;

import game.*;
import game.vehicles.*;
import game.utils.*;

public class Tests {
    @Test
    public void testNullName() {
        assertThrows(IllegalArgumentException.class, 
            () -> new Player(null, "valami", 20));
    }
    
    @Test
    public void testNegativeCash() {
        assertThrows(IllegalArgumentException.class, 
            () -> new Player("Name", "valami", -20));
    }
    
    @Test
    public void testWhiteSpaceInIp() {
        assertThrows(IllegalArgumentException.class, 
            () -> new Player("Name", "va lami", 20));
    }
    
    @Test
    public void rightAmountMoney() {
       Player p = new Player("Name", "valami", 20);

       int m = p.getMoney();

       assertEquals(20, m);
    }
}