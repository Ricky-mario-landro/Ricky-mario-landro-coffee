using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milky;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.milky = milk;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe Expresso is ready";
        }
        public String makeCappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffee is empty";
            }
            if (!this.milky.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milky.makeOneCupMilk();
            return "Yey! your coffee Cappucino is ready";
        }

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()} and the milk : {this.milky.getVolumeMilk()}";
        }
    }
}
