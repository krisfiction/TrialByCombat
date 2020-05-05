using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat
{
    class Gear : Items // every item that can be worn
    {
        public int ArmorBonus { get; set; }
    }
}


/*
         name: padded armor
         slot: chest
         type: light
         cost: 5gp
         armor bonus: +1
         dex bonus: +8
         armor penalty: 0
         spell failure chance: 5%
         speed 30 feet: 30 feet
         speed 20 feet: 20 feet
         weight: 10 lbs

        extra stuff:
        plural name
        id
        flavor text

    more stats:
    health
    mana
    armor class / armor bonus
    str
    wis
    int
    spell power
    resist
    class / race restrictions ?

    weapons:
    damage



diablo 1: 7 items
head
body
neck
ring 1
ring 2
main hand weapon
off hand weapon


diablo 2: 10 items
head
body
*belt
*hands
*feet
neck
ring 1
ring 2
main hand weapon
off hand weapon


diablo 3: 12 items
head
*shoulders
chest
belt
*arms
hands
legs
feet
neck
ring 1
ring 2
main hand weapon
off hand weapon 


skyrim: 8 items 
helm
hands
feet
body
ring
neck
main hand
off hand



everquest:
Arms
Back
Chest
Ear
Face
Feet
Fingers
Hands
Head
Legs
Neck
Shoulders
Waist
Wrist

Primary
Secondary
Range
Ammo

1H Blunt
2H Blunt
1H Slashing
2H Slashing
Piercing
2H Piercing
Archery (Bows)
Throwing
Instrument
Hand to Hand


world of warcraft:
Slot
Head
Neck
Shoulder
Shirt
Chest
Belt
Legs
Feet
Wrist
Gloves
Finger 1 (Top)
Finger 2 (Bottom)
Trinket 1 (Top)
Trinket 2 (Bottom)
Back
Main Hand
Off Hand
Ranged
Tabard

*/
