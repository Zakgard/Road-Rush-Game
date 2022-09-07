using System.Collections.Generic;
public class PlayerCarClass
{
    int carIndex;
    float acceleration;
    int hitPoints;   

    public PlayerCarClass(int carIndex, float acceleration, int hitPoints)
    {
        this.carIndex = carIndex;
        this.acceleration = acceleration;
        this.hitPoints = hitPoints;
        
    }

    List<PlayerCarClass> playerCarClasses= new List<PlayerCarClass>()
    {
        new PlayerCarClass(0, 5, 30),
        new PlayerCarClass(1, 10, 25),
        new PlayerCarClass(2, 15,20),
        new PlayerCarClass(3, 20,15),
        new PlayerCarClass (4, 40,5),
    };
    
}
