using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtClub.Controller
{
    class test
    {
        static void Main(string[] args)
        {
            Member member1 = new Member();
            member1.last_name = "llelujah";
            member1.first_name = "ha";
            member1.personal_number = 19995784;

            Boat firstBoat = new Boat();
            firstBoat.SetType(Boat.boat_Type.kayak);

            MemberRegister mbRegister = new MemberRegister();
            mbRegister.addMember(member1);
            mbRegister.getBoatsFromMember(member1);


        }
    }
}
