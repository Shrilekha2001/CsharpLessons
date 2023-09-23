namespace FirstMVCApp.Models
{
  
 

    
        public class Management
        {
            [Key]
            public decimal Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public string Language { get; set; } = string.Empty;
            public string Hero { get; set; } = string.Empty;
            public string Director { get; set; } = string.Empty;
            public string MusicDirector { get; set; } = string.Empty;
            public DateTime ReleasedDate { get; set; }
            public decimal Cost { get; set; }
            public decimal Collection { get; set; }
            public string Review { get; set; }

        }
    }


}
}
