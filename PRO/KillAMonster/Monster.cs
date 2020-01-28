namespace KillAMonster
{
    public class Monster
    {
        private string naam;
        private int HP;
        
        private bool isDead = false;
        public string getnaam() {
            return this.naam;
        }
        public void setnaam(string Naam) {
            this.naam = Naam;
        }
        public int getHP() {
            return HP;
        }
        public void setHP(int newHP) {
            this.HP = newHP;
        }

        public bool getIsDead() {
            return this.isDead;
        }
        public void setisDead(bool input) {
            this.isDead = input;
        }
    }
}