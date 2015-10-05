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

        public void addMember(Member member)
        {
            if (allMembers.Contains(member))
            {
                throw new ArgumentNullException();
        }
            else {allMembers.Add(member);}

            
        }

        public void addBoat(Boat boat)
        {
            if (allBoath.Contains(boat))
            {
                throw new ArgumentNullException();
        }
            else { allBoath.Add(boat); }

        }

        public void deleteMember(Member mem)
        {
            
            if (allMembers.Contains(mem))
        {
                allMembers.Remove(mem);
            }
            else
                throw new ArgumentNullException();
            
            
        }

        public void deleteBoat(Boat boat)
        {
            
            if (allBoath.Contains(boat))
        {
                allBoath.Remove(boat);
            }
            else
                throw new ArgumentNullException();

            
        }

        public void updateMember(Member member)
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