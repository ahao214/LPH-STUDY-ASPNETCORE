using System.Collections.ObjectModel;
using System.Reflection.Metadata;

namespace TestMenu
{
    public class Department
    {
        public string Name { get; set; }

        public string ImgPath { get; set; }

        public ObservableCollection<Project> SubItems { get; set; }

        public Department()
        {
            SubItems = new ObservableCollection<Project>()
                {
                    new Project()
                    {
                        Name="项目01",
                        ImgPath="Images/OS2.pgn",
                    },
                    new Project()
                    {
                        Name="项目02",
                        ImgPath="Images/OS5.pgn",
                    },
                    new Project()
                    {
                        Name="项目03",
                        ImgPath="Images/OS3.pgn",
                    },
                    new Project()
                    {
                        Name="项目04",
                        ImgPath="Images/OS4.pgn",
                    },
                };
        }





    }
}
