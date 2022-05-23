namespace desafio01.src.Entities
{
    public abstract class Hero // abstract - classe mãe de outas classes
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero()
        {
            
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString() // override - sobescreve o metodo herdado
        {
            return this.Name + " " + this.Level + " " + this.HeroType;

        }
        public virtual string Attack() // virtual - permite que um filho altere o comportamento > override
        {
            return this.Name + " Atacou com a sua espada";
        }
        
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
                return this.Name + " Lançou Magia SUPER EFETIVA com bonus de " + Bonus;
            else
                return this.Name + " Lançou uma magia com FORÇA FRACA com bonus de " + Bonus;

        }
    }
}