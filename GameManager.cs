using UnityEngine;

namespace Assets.Scripts{
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Player theBatman = new ("Batman",100);
            Enemy theJoker = new ("Joker",100);

            Debug.Log("Character name: " + theJoker.Name);
            Debug.Log("Player health points : " + theJoker.Health);
            theJoker.Attack(theBatman,50);
            theJoker.Attack(theBatman,30);

            Debug.Log("Character name: " + theBatman.Name);
            Debug.Log($"{theBatman.Name} health points: " + theBatman.Health);
            theBatman.Heal(30);
            theBatman.Heal(true);
            Debug.Log(theBatman.Name +" health points : " + theBatman.Health);

        }
    }
}