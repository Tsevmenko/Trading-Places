using Resourses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Date.ViewModel
{
    public class DayTimeModel
    {
        public string DayTime { get; set; }
        public bool Checked { get; set; }
    }

    public class ContactUsModel
    {
        const string _pleaseEnterYourName = "Please enter your name";
        const string _englandPhoneNumberRegularExpression = "[0-9]{3}-[0-9]{4}-[0-9]{4}";
        const string _enterYourPhoneNumber = "Please write your phone number. \r\nExample: 020-8558-1147";
        const string _typeYourMessage = "Type your message";
        const string _chooseSomeTitle = "Choose some title";

        public string Title { get; set; }
        [Required]
        public string TitleAnswer { get; set; }
        public SelectList TitleList { get; set; }
        [Required(ErrorMessage = _pleaseEnterYourName)]
        public string Name { get; set; }
        [RegularExpression(_englandPhoneNumberRegularExpression, ErrorMessage = _enterYourPhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = _typeYourMessage)]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        public string MessageHeader { get; set; }
        public List<DayTimeModel> ContactTime { get; set; }

        public ContactUsModel()
        {
            var d = new DayTimeModel() { DayTime = WebSiteResources.ContactAnytime, Checked = false };
            var d1 = new DayTimeModel() { DayTime = WebSiteResources.ContactMondayAM, Checked = false };
            var d1p = new DayTimeModel() { DayTime = WebSiteResources.ContactMondayPM, Checked = false };
            var d2 = new DayTimeModel() { DayTime = WebSiteResources.ContatTuesdayAM, Checked = false };
            var d2p = new DayTimeModel() { DayTime = WebSiteResources.ContatTuesdayPM, Checked = false };
            var d3 = new DayTimeModel() { DayTime = WebSiteResources.ContactWednesdayAM, Checked = false };
            var d3p = new DayTimeModel() { DayTime = WebSiteResources.ContactWednesdayPM, Checked = false };
            var d4 = new DayTimeModel() { DayTime = WebSiteResources.ContactThursdayAM, Checked = false };
            var d4p = new DayTimeModel() { DayTime = WebSiteResources.ContactThursdayPM, Checked = false };
            var d5 = new DayTimeModel() { DayTime = WebSiteResources.ContactFidayAM, Checked = false };
            var d5p = new DayTimeModel() { DayTime = WebSiteResources.ContactFidayPM, Checked = false };
            var d6 = new DayTimeModel() { DayTime = WebSiteResources.ContactSaturdayAM, Checked = false };
            var d6p = new DayTimeModel() { DayTime = WebSiteResources.ContactSaturdayPM, Checked = false };
            ContactTime = new List<DayTimeModel>() { d, d1, d1p, d2, d2p, d3, d3p, d4, d4p, d5, d5p, d6, d6p };
            MessageHeader = WebSiteResources.ContactMessageHeader;
            Title = WebSiteResources.ContactTitle;
            TitleList = new SelectList(new string[] { WebSiteResources.ContactTitle1, WebSiteResources.ContactTitle2, WebSiteResources.ContactTitle3 });
            PhoneNumber = WebSiteResources.ContactPhoneNumber;
        }
    }
}