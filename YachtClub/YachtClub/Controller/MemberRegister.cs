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
            if (allBoats.Contains(boat))
            {
                throw new ArgumentNullException();
        }
            else { allBoats.Add(boat); }

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
            
            if (allBoats.Contains(boat))
        {
                allBoats.Remove(boat);
            }
            else
                throw new ArgumentNullException();

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
                    Boat newBoat = new Boat();
                    newBoat.SetType(boat.GetType());
                    newBoat.Length = boat.Length;
                }
                else 
                {
                    throw new Exception ("Boat does not exist.");
                }
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }

        public List<Boat> getBoatsFromMember(Member member)
        {
            if (allMembers.Contains(member))
            {
                int sizeOfBoatsList = member.boats.Count;
                if (member.boats.Count == 0)
                {
                    Console.WriteLine("The member has no boats.");
                    return member.boats;
                }
                else
                {
                    allMembers.Find(x => x.personal_number == member.personal_number);
                    return member.boats;
                }
            }
            else
            {
                throw new Exception("Member does not exist.");
            }
        }
    }
}