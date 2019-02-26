using System.Runtime.Serialization;
using HubSpot.Contact.Interfaces;

namespace HubSpot.Contact.Dto
{
    [DataContract]
    public class ContactHubSpotEntity : IContactHubSpotEntity
    {
        /// <summary>
        /// Contacts unique Id in HubSpot
        /// </summary>
        [DataMember(Name = "vid")]
        [IgnoreDataMember]
        public long? Id { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "firstname")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastname")]
        public string Lastname { get; set; }
        [DataMember(Name = "website")]
        public string Website { get; set; }
        [DataMember(Name = "company")]
        public string Company { get; set; }
        [DataMember(Name = "phone")]
        public string Phone { get; set; }
        [DataMember(Name = "address")]
        public string Address { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
        [DataMember(Name = "zip")]
        public string ZipCode { get; set; }

        //New Custom Fields



        [DataMember(Name = "are_you_interested_in_participating_in_our_operating_partner_program_click_here_for_more_informatio")]
        public string are_you_interested_in_participating_in_our_operating_partner_program_click_here_for_more_informatio { get; set; }
        [DataMember(Name = "technology_expertise")]
        public string technology_expertise { get; set; }
        [DataMember(Name = "num_unique_conversion_events")]
        public string num_unique_conversion_events { get; set; }
        [DataMember(Name = "if_you_are_a_member_of_another_angel_or_investment_group_please_list_them_below_")]
        public string if_you_are_a_member_of_another_angel_or_investment_group_please_list_them_below_ { get; set; }
        [DataMember(Name = "channel")]
        public string channel { get; set; }
        [DataMember(Name = "ff_number_of_investments")]
        public string ff_number_of_investments { get; set; }
        [DataMember(Name = "prior_angel_venture_investing_activity_1_is_low_10_is_high_")]
        public string prior_angel_venture_investing_activity_1_is_low_10_is_high_ { get; set; }
        [DataMember(Name = "linkedin_url")]
        public string linkedin_url { get; set; }
        [DataMember(Name = "how_many_private_investments_have_you_made_in_the_last_12_months_")]
        public string how_many_private_investments_have_you_made_in_the_last_12_months_ { get; set; }
        [DataMember(Name = "industry")]
        public string industry { get; set; }
        [DataMember(Name = "do_you_have_an_accredited_trust_or_llc_you_would_like_to_make_investments_through_")]
        public string do_you_have_an_accredited_trust_or_llc_you_would_like_to_make_investments_through_ { get; set; }
        [DataMember(Name = "which_stage_s_of_companies_are_you_interested_in_")]
        public string which_stage_s_of_companies_are_you_interested_in_ { get; set; }
        [DataMember(Name = "if_yes_how_would_you_like_to_be_involved_please_select_at_least_1_of_the_below_")]
        public string if_yes_how_would_you_like_to_be_involved_please_select_at_least_1_of_the_below_ { get; set; }
        [DataMember(Name = "angel_co_url")]
        public string angel_co_url { get; set; }
        [DataMember(Name = "industry_expertise")]
        public string industry_expertise { get; set; }
        [DataMember(Name = "ff_fund_i_dollar_amount_of_investments")]
        public string ff_fund_i_dollar_amount_of_investments { get; set; }
        [DataMember(Name = "ff_dollar_amount_of_investments")]
        public string ff_dollar_amount_of_investments { get; set; }
        [DataMember(Name = "investments_company")]
        public string investments_company { get; set; }
        [DataMember(Name = "industry_interests")]
        public string industry_interests { get; set; }
        [DataMember(Name = "technology_interest")]
        public string technology_interest { get; set; }
        [DataMember(Name = "self_accredidation")]
        public string self_accredidation { get; set; }
        [DataMember(Name = "member_of_other_angel_group")]
        public string member_of_other_angel_group { get; set; }



        public string RouteBasePath => "/contacts/v1";
        public bool IsNameValue => false;
        public virtual void ToHubSpotDataEntity(ref dynamic converted)
        {

        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {
            
        }
    }
}
