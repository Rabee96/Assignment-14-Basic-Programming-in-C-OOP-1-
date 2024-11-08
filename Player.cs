using UnityEngine;

namespace Assets.Scripts
{
    public class Player : Character
    {  
        public Player(string characterName, int characterHealth) : base(characterName, characterHealth)
        {
        }

        public void Heal(int amount){

            if(amount >= 100 || amount + Health>= 100 )
                Debug.Log($"Why not to ask for immortality instead, {Name}😒");
            else if (amount <= 0)
                Debug.Log($"{Name} are you quitting so fast 🤔, chose reasonable value 🤨");
            else if (Health == 100)
                Debug.Log($"{Name} you already have full life and you ask for more 🫤");
            else if (Health + amount >=0 || Health + amount <= 100){
                Health += amount;
                Debug.Log($"You\'re current life points are {Health}, {Name}, Keep it up soldier 🫡");
            }
        }

        public void Heal (bool fullRestore){
            if(fullRestore)
                Health = 100;
                Debug.Log($"{Name} you\'re health has been fully restored, Keep it up soldier 🫡");
        }



    }
}