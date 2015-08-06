using Architecture.Data.Models;
using Architecture.Entities.Masters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Data
{
    public class ConfigData : DropCreateDatabaseIfModelChanges<ArchitectureEntities>
    {
        protected override void Seed(ArchitectureEntities context)
        {
            new List<State>{
                new State{StateId=1, StateName="Arunachal Pradesh"},
                new State{StateId=2, StateName="Assam"},
                new State{StateId=3, StateName="Bihar"},
                new State{StateId=4, StateName="Chhattisgarh"},
                new State{StateId=5, StateName="Goa"},
                new State{StateId=6, StateName="Gujarat"},
                new State{StateId=7, StateName="Haryana"},
                new State{StateId=8, StateName="Himachal Pradesh"},
                new State{StateId=9, StateName="Jammu and Kashmir"},
                new State{StateId=10, StateName="Jharkhand"},
                new State{StateId=11, StateName="Karnataka"},
                new State{StateId=12, StateName="Kerala"},
                new State{StateId=13, StateName="Madhya Pradesh"},
                new State{StateId=14, StateName="Maharashtra"},
                new State{StateId=15, StateName="Manipur"},
                new State{StateId=16, StateName="Meghalaya"},
                new State{StateId=17, StateName="Mizoram"},
                new State{StateId=18, StateName="Nagaland"},
                new State{StateId=19, StateName="Orissa"},
                new State{StateId=20, StateName="Punjab"},
                new State{StateId=21, StateName="Rajasthan"},
                new State{StateId=22, StateName="Sikkim"},
                new State{StateId=23, StateName="Tamil Nadu"},
                new State{StateId=24, StateName="Telangana"},
                new State{StateId=25, StateName="Tripura"},
                new State{StateId=26, StateName="Uttar Pradesh"},
                new State{StateId=27, StateName="Uttarakhand"},
                new State{StateId=28, StateName="West Bengal"},
                new State{StateId=29, StateName="Delhi"},
                new State{StateId=30, StateName="Pondicherry"}
            }.ForEach(m => context.State.Add(m));

            context.Commit();
        }
    }
}
