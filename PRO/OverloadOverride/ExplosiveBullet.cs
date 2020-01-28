namespace OverloadOverride
{
    public class ExplosiveBullet:BulletBase
    {
        private float _explosionRadius = 10.5f;

        //Constructor
        public ExplosiveBullet(int speed, int damage, float radius) : base(speed, damage) {
            this._explosionRadius = radius;
        }
        // Setter. 
        public void setExplosionRadius(float value) {
            _explosionRadius = value;
        }

        public override void onhit() {
            // 
        }
    }
}