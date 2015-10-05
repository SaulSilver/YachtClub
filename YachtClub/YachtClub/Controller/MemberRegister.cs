using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YachtClub
{
    public class MemberRegister
    {
        private List<Member> allMembers;
        private List<Boat> allBoats;
        private FileInteraction database;

        public void addMember()
        {
            throw new System.NotImplementedException();
        }

        public void addBoat()
        {
            throw new System.NotImplementedException();
        }

        public void deleteMember()
        {
            throw new System.NotImplementedException();
        }

        public void deleteBoat()
        {
            throw new System.NotImplementedException();
        }

        public void updateMember()
        {
            throw new System.NotImplementedException();
        }

        public void updateBoat(Member member, Boat boat)
        {
            if (allMembers.Contains(member))
            {
                if (allBoats.Contains(boat))
                {
                    boat.
                }
            }
            throw new System.NotImplementedException();
        }

        public void getBoatsFromMember(Member member)
        {
            if (allMembers.Contains(member))
            {
                allMembers.Find(x => x.personal_number());
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
                throw new System.NotImplementedException();
        }
    }
}