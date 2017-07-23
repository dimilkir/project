using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class MenuMaker
    {
        public Random Randomizer;

        string[] Bananas = { "Бэби банан", "Синий банан", "Банан Барро", "Банан Кавендиш", "Банан Мансано", "Банан Плантайн", "Красный банан" };
        string[] Condiments = { "под дикий ор", "в застывшей тишине", "в бухом состоянии", "на спор" };
        string[] BodyParts = { "лицо", "лицо", "лицо", "лицо" };

        public string GetAction()
        {
            string rndBanana = Bananas[Randomizer.Next(Bananas.Length)];
            string rndCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string rndBodyPart = BodyParts[Randomizer.Next(BodyParts.Length)];

            return
                "Димка словил " + rndBanana +
                " " + rndCondiments +
                " на своё " + rndBodyPart;
        }

    }
}
