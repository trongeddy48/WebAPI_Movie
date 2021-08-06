using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Movie.Models.ViewModel
{
    public class CommentView
    {
        public string CommentId { get; set; }

        public string GuestName { get; set; }

        public string GuestAvatar { get; set; }

        public string Comment1 { get; set; }

        public string Created { get; set; }
    }
}