﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Customer
{
    public class CustomerNotesModel : BaseModel
    {
        public List<CustomerNote> CustomerNoteList { get; set; } = new();
        public string CustomerId { get; set; }
    }

    public class CustomerNote
    {
        public string NoteId { get; set; }
        public string DownloadId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOn { get; set; }
        
    }
}