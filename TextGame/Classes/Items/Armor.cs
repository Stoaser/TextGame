﻿namespace Game.Items
{
    using Attributes;

    public class Armor : Item
    {
        public Armor(string name, ItemRarity rarity, AttributeModifier modifier) : base(name, ItemType.Armor, rarity)
        {
            Modifier = modifier;
        }

        public AttributeModifier Modifier { get; private set; }
    }
}