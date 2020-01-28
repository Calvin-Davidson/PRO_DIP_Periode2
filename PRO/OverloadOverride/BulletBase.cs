namespace OverloadOverride
{
    public class BulletBase
    {
        int speed;
        int damage;

        //Constructor
        public BulletBase(int speed, int damage) {
            this.speed = speed;
            this.damage = damage;
        }

        public void setSpeed(int value) {
            speed = value;
        }
        public void setDamage(int damage) {

        }
        public int getDamage() {
            return this.damage;
        }


        public virtual void onhit() {
            // 
        }
    }
}