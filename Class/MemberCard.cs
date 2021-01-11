namespace WyprawaNa8k
{
    public class MemberCard : Card
    {
        private string Organisation { get; set; }
        public MemberCard(string owner, string organisation) : base(owner)
        {
            this.Organisation = organisation;
        }
    }
}