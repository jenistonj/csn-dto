﻿using System;
using System.Collections.Generic;

namespace Csn.Public.Dto
{
    public class Lead
    {
        public Lead()
        {
            Prospect = new Customer();
            Environment = new Environment();
        }

        /* required */
        public Guid Identifier { get; set; }
        /* ISO Short two char country codes, e.g. AU, NZ, US etc. */
        public string CountryCode { get; set; }
        public Customer Seller { get; set; }

        /* name provided for the system sending the lead */
        public string Source { get; set; }

        /* Type = [USED, NEW, DEMO, GENERAL, GENERIC, SHOWROOM, SERVICE, FINANCE, INSURANCE]*/
        public string Type { get; set; }

        /* Status = [New, Contact, Commitment, Sold, Lost, Duplicate, Unworkable] */
        public string Status { get; set; }  
        
        public Environment Environment { get; set; }
        public Customer Prospect { get; set; }

        public string Comments { get; set; }
        public DateTime CreatedUtc { get; set; }
        public DateTime? ModifiedUtc { get; set; }

        /*
            Labels is replacing Tags, and provides a means to add labels of various types
            Type = [Private, System, Device, User]
            Value is used to denote the actual label itself.
        */
        public List<TypeValue> Labels { get; set; }

        /* ServiceRequest.Type = [Finance, Insurance etc] */
        public List<TypeValue> ServiceRequests { get; set; }

        public TelephoneCall PhoneCall { get; set; }

        public Vehicle Item { get; set; }
        public Vehicle TradeIn { get; set; }

        public List<HistoryItem> History { get; set; }
        public Assignment Assignment { get; set; }
        public List<NameValue> ExtendedProperties { get; set; }
    }

    public class Assignment
    {
        public Guid? Identifier { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime AssignedUtc { get; set; }
    }

    public class HistoryItem
    {
        public Guid? Identifier { get; set; }
        public string Type { get; set; }
        public DateTime CreatedUtc { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Environment
    {
        public string Source { get; set; }
        public string Url { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }
    }
}
