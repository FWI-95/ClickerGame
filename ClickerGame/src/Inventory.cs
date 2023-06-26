using System;
using System.Collections;

namespace CookieClicker {
    internal class Inventory {
        ArrayList Helpers {get;set;}
        ArrayList Upgrades {get;set;}

        public Inventory() {
            Helpers = new ArrayList(Helpers);
            Upgrades = new ArrayList(Upgrades);
        }

        public void NewHelper(Helper helper) {
            Helpers.Add(helper);
        }
    }
}