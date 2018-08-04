using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreSemseterProject.Models
{
    
    public class Volunter
    {   //Volunter personal info
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Paswword { get; set; }
        public string Address { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneCell { get; set; }
        public string Email { get; set; }


        //Volunter's Emergency Contact info == EmerCont
        public string EmerContAddress { get; set; }
        public string EmerContPhoneHome { get; set; }
        public string EmerContPhoneWork { get; set; }
        public string EmerContPhoneCell { get; set; }
        public string EmerContEmail { get; set; }


        //Volunter's preferences,qualifications, certfication status
        public string Centers { get; set; } //Will likely need to be made into an array, intend to use checkable boxes for selection if possible
        public string Aptitudes { get; set; }//skills and interests
        //Availabilty, I'm thihking day + time slot ,store as an array?
        public string Education { get; set; }//thinking another dropdown with level of education I.E. A.A., B.S., etc...
        public string Licenses { get; set; }//dropdown + detail? I.E. medical, drivers, etc + typed detail
        public bool DL_OnFile { get; set; } //Driver License on file
        public bool SSN_OnFile { get; set; } //Social Seccurity card on file
        public bool Approval { get; set; } //Volunter approval status
 
       

        


    }
}

