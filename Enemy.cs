using UnityEngine;

namespace Assets.Scripts
{
    public class Enemy : Character
    {  
        public Enemy(string characterName, int characterHealth) : base(characterName, characterHealth)
        {
        }

        public void Attack(Player player,int amount){
            player.Health -= amount;
            Debug.Log($"Didn\'t see that coming batty 🤡😂");
        }

    }
}