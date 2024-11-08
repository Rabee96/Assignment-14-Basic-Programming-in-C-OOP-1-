
namespace Assets.Scripts{
    public class Character{
        public Character(string characterName,int characterHealth){
            Name = characterName;
            health = characterHealth;
        }
    public string Name { set; get; }
    private int health;
        public int Health
        {
        get => health;
        set {
            health = value;
        }
    }
    }
}
