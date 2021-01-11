using System.Collections.Generic;

namespace WyprawaNa8k
{
    public class MemberCard : Card
    {
        public static List<Card> cards {get;set;}
        private string Organisation { get; set; }
        public MemberCard(string owner, string organisation) : base(owner)
        {
            this.Organisation = organisation;
            
            // cards.Add();
        }
    }
}