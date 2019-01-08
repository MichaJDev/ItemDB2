using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDB2
{
    class Item
    {
        string name, desc, type, worth;
        int stam, str, intl, agi, has, mas;
        
        public Item(string name, string desc, string type, string worth, int stam, int str, int intl, int agi, int has, int mas)
        {
            this.name = name;
            this.desc = desc;
            this.type = type;
            this.worth = worth;
            this.stam = stam;
            this.str = str;
            this.intl = intl;
            this.agi = agi;
            this.has = has;
            this.mas = mas;
        }

        public string getName()
        {
            return name;
        }
        public string getDesc()
        {
            return desc;
        }
        public string getType()
        {
            return type;
        }
        public string getWorth()
        {
            return worth;
        }
        public int getStam()
        {
            return stam;
        }
        public int getStr()
        {
            return str;
        }
        public int getIntl()
        {
            return intl;
        }
        public int getAgi()
        {
            return agi;
        }
        public int getHas()
        {
            return has;
        }
        public int getMas()
        {
            return mas;
        }
        public override string ToString()
        {
            return "---------------------------\n" + 
                "ITEM\n" +
                "---------------------------\n" +
                "Name: " + name + "\n" +
                "Desc: " + desc + "\n" +
                "Type: " + type + "\n" +
                "Worth: " + worth + "\n" +
                "Stamina: " + stam + "\n" +
                "Strength: " + str + "\n" +
                "Intellect: " + intl + "\n" +
                "Agility: " + agi + "\n" +
                "Haste: " + has + "\n" +
                "Mastery: " + mas + "\n" +
                "---------------------------";
        }
    }
}
