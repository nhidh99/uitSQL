namespace DTO
{
    class RuleDTO
    {
        public string RuleID { get; set; }
        public string RuleName { get; set; }
        public float RuleValue { get; set; }
        public RuleDTO() { }

        public RuleDTO(string RuleID, string RuleName, float RuleValue)
        {
            this.RuleID = RuleID;
            this.RuleName = RuleName;
            this.RuleValue = RuleValue;
        }
    }
}
