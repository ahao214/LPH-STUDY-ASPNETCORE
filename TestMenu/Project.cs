using System.Collections.ObjectModel;

namespace TestMenu
{
    public class Project
    {
        public string Name { get; set; }

        public string ImgPath { get; set; }

        public ObservableCollection<Member> SubItems { get; set; }


        public Project()
        {
            SubItems = new ObservableCollection<Member>()
               {
                    new Member()
                    {
                        Name="成员1",ImgPath="Images/OS2.pgn",
                    },
                    new Member()
                    {
                        Name="成员2",ImgPath="Images/OS3.pgn",
                    },
                    new Member()
                    {
                        Name="成员3",ImgPath="Images/OS4.pgn",
                    },
                    new Member()
                    {
                        Name="成员4",ImgPath="Images/OS5.pgn",
                    },
                    new Member()
                    {
                        Name="成员5",ImgPath="Images/OS6.pgn",
                    },
               };
        }


    }
}
