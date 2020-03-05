using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasycard
{
    class Card
    {
        private int power;
        private string name;
        private string faction;
        private string race;
        private string class_;

        public Card(int power, string name, string faction, string race, string class_)
        {
            this.power = power;
            this.name = name;
            this.faction = faction;
            this.race = race;
            this.class_ = class_;
        }

        public int Power { get => power; set => power = value; }
        public string Name { get => name; set => name = value; }
        public string Faction { get => faction; set => faction = value; }
        public string Race { get => race; set => race = value; }
        public string Class_ { get => class_; set => class_ = value; }

        public override string ToString()
        {
            return String.Format("{0};{1};{2};{3};{4}", power, name, faction, race, class_);
        }





    }
}
