﻿using System;
using DAL.Vulcan.Mongo.DocClass.CRM;
using MongoDB.Bson.Serialization.Attributes;

namespace DAL.Vulcan.Mongo.DocClass.Quotes
{
    public class Revision
    {
        public int Id { get; set; } 
        public CrmUserRef SalesPerson { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RevisionDate { get; set; }
        public string RevisionNotesForPdf { get; set; }
    }
}