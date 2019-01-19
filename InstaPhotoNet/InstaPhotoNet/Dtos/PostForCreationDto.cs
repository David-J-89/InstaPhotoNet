using Microsoft.AspNetCore.Http;
using System;

namespace InstaPhotoNet.Dtos
{
    public class PostForCreationDto
    {
        public string Url { get; set; }

        public IFormFile File { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public string PublicId { get; set; }


        public PostForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}
