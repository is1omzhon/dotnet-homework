namespace encapsulation.Models;

class WaterTank 
{
   public int Capacity {get;}
   public int Water {get; private set;}

   public WaterTank(int capacity, int water)
   {
        if (water < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(water), "Qoldiq manfiy bo‘lmasligi kerak.");
        }

        if (water < 0 && water > capacity)
        {
            throw new ArgumentOutOfRangeException(nameof(water), "Suv miqdor  0 dan sigim gacha bo‘lishi kerak.");
        }

        Capacity = capacity;
        Water = water;        
   } 

   public bool Fill(int amount)
   {
        if (amount > 0 && amount <= Capacity - Water)
        {
            Water += amount;    
            return true;
        }

        return false;
   }

   public bool Use(int amount)
   {
        if(amount > 0 && amount <= Water)
        {
            Water -= amount;
            return true;
        }

        return false;
   }

   public int GetFreeCapacity()
   {
        int diffirence = Capacity - Water;
        return diffirence;
   }
}
