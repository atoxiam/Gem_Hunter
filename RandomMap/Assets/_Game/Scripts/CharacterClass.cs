using UnityEngine;
using System.Collections;

namespace Quantum_Asset {
    class CharacterClass : MonoBehaviour {
        private int _currentLvl = 1;
        private int maxHealth = 100;
        private int maxMana = 100;
        private int _health;
        private int _mana;
        private int maxLvl = 100;
        // private int experience;

        private string myName;

        public int CurrentLvl {
            get {
                return _currentLvl;
            }
        }

        public int Health {
            get {
                return _health;
            }
            set {
                if (_health <= 0) {
                    _health = 0;
                } else if (_health >= maxHealth) {
                    _health = maxHealth;
                } else {
                    _health = value;
                }
            }
        }

        public int Mana {
            get {
                return _mana;
            }
            set {
                if (_mana <= 0) {
                    _mana = 0;
                } else if (_mana >= maxMana) {
                    _mana = maxHealth;
                } else {
                    _mana = value;
                }
            }
        }

        /*---------------------------- Meathods ----------------------------------*/


        public CharacterClass(string _name) {
            _health = maxHealth;
            _mana = maxMana;
            myName = _name;
        }

        public CharacterClass(string _name, int mH, int mM) {
            maxHealth = mH;
            maxMana = mM;
            _health = maxHealth;
            _mana = maxMana;
            myName = _name;
        }

        //This event will be trigger to level the character up 
        public void LvlUp() {
            _currentLvl++;
            maxMana += 100;
            maxHealth += 100;
            Heal();
            RegenMana();

        }

        public void LvlUp(int lvl) {
            if (lvl >= maxLvl) {
                lvl = maxLvl;
            }
            _currentLvl += lvl;

            for (int i = 0; i < lvl; i++) {
                maxMana += 100;
                maxHealth += 100;
            }

            Heal();
            RegenMana();

        }

        //This is the heal the character to full health
        public int Heal() {
            _health = maxHealth;
            return _health;
        }

        //This is to heal the character a certain amount if it is less then their max health
        public int Heal(int healed) {
            _health = _health + healed;
            return _health;
        }

        //This is to regen to full mana
        public int RegenMana() {
            _mana = maxMana;
            return _mana;
        }

        //This is to regen mana to a certain amount if it is less then their max Mana
        public int RegenMana(int regened) {
            _mana = _mana + regened;
            return _mana;
        }

        public string WhoAmI() {
            string greeting = "Hello, My name is " + myName;
            return greeting;
        }

        /* ---------------------- Attacks ---------------------- */

        public void Fireball() {
            //Uses mana and does damange to enemies
            Debug.Log("You shot a fireball.");
        }

        public void Melee() {
            //Does damage to enemy in a close range to the character
            Debug.Log("You Did a Melee attack.");
        }

    }
}
