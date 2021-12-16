﻿using System;

namespace TrialByCombat
{
    public class Characters
    {
        public string Name;

        public int Health { get; set; }

        public int HealthMax { get; set; }

        public int Gold { get; set; }

        public int WeaponDamageLow { get; set; }
        public int WeaponDamageHigh { get; set; }
        public int WeaponDamage { get; set; }

        public string WeaponName { get; set; }

        public string DisplayHealthBar()
        {
            // maybe a seperate method() such as HealthPercentage() that returns 85%

            // (current health / max health) * 100
            //int _healthPercentage = (int)Math.Round((double)(100 * Health) / HealthMax);

            string _barTemp = "";
            int _barCount = 0;
            int _healthTenth = (10 * Health) / HealthMax;

            do
            {
                _barTemp += "*";
                _barCount++;
            } while (_barCount < _healthTenth);

            if (_healthTenth < 10)
            {
                do
                {
                    _barTemp += "-";
                    _barCount++;
                } while (_barCount < 10);
            }

            //testing
            //string _healthBar = $"{_healthPercentage} - {_healthTenth} [{_barTemp}]";
            string _healthBar = $"[{_barTemp}]";

            return _healthBar;
        }

        // add inventory here ??
    }
}