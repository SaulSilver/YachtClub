using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YachtClub
{
    public class MemberRegister
    {
        private List<Member> allMembers;
        private List<Boat> allBoath;

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

            throw new System.NotImplementedException();
        }

        public void updateMember(Member member)
        {
            throw new System.NotImplementedException();
        }

        public void updateBoat()
        {
            throw new System.NotImplementedException();
        }

        public void getBoatsFromMember()
        {
            throw new System.NotImplementedException();
        }
    }
}