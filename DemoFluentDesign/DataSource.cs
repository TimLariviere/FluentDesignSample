namespace DemoFluentDesign
{
    public static class DataSource
    {
        public static Picture[] Pictures = new[]
        {
            new Picture { Title = "Landscape 1", Description = "Description for Landscape 1", Source = "ms-appx:///Images/Landscape-1[1].jpg"  },
            new Picture { Title = "Landscape 2", Description = "Description for Landscape 2", Source = "ms-appx:///Images/Landscape-2[1].jpg"  },
            new Picture { Title = "Landscape 3", Description = "Description for Landscape 3", Source = "ms-appx:///Images/Landscape-3[1].jpg"  },
            new Picture { Title = "Landscape 4", Description = "Description for Landscape 4", Source = "ms-appx:///Images/Landscape-4[1].jpg"  },
            new Picture { Title = "Landscape 5", Description = "Description for Landscape 5", Source = "ms-appx:///Images/Landscape-5[1].jpg"  },
            new Picture { Title = "Landscape 6", Description = "Description for Landscape 6", Source = "ms-appx:///Images/Landscape-6[1].jpg"  },
            new Picture { Title = "Landscape 7", Description = "Description for Landscape 7", Source = "ms-appx:///Images/Landscape-7[1].jpg"  },
            new Picture { Title = "Landscape 8", Description = "Description for Landscape 8", Source = "ms-appx:///Images/Landscape-8[1].jpg"  },
            new Picture { Title = "Landscape 9", Description = "Description for Landscape 9", Source = "ms-appx:///Images/Landscape-9[1].jpg"  },
            new Picture { Title = "Landscape 10", Description = "Description for Landscape 10", Source = "ms-appx:///Images/Landscape-10[1].jpg"  },
            new Picture { Title = "Landscape 11", Description = "Description for Landscape 11", Source = "ms-appx:///Images/Landscape-11[1].jpg"  },
            new Picture { Title = "Landscape 12", Description = "Description for Landscape 12", Source = "ms-appx:///Images/Landscape-12[1].jpg"  }
        };
    }

    public class Picture
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
    }
}
