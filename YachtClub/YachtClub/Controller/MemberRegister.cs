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
                throw new ArgumentNullException("Member not found");
        }
            else {allMembers.Add(member);}

            
        }

        public void addBoat(Boat boat)
        {
            if (allBoath.Contains(boat))
            {
                throw new ArgumentNullException("Boat not found");
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
                throw new ArgumentNullException("Member not found");
            
            
        }

        public void deleteBoat(Boat boat)
        {
            
            if (allBoath.Contains(boat))
        {
                allBoath.Remove(boat);
            }
            else
                throw new ArgumentNullException("Boat not found");

          
        }

        public void updateMember(Member member)
        {
            //Need to delete member and create new one in XML file

            member.last_name 
            member.member_id 
            member.personal_number 
            member.first_name  
            
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
            
        }
    }
}