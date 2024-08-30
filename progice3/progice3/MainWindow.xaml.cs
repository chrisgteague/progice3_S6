using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace progice3
{
    
    public partial class MainWindow : Window
    {
        private ScriptDLinkedList scriptDLinkedList;
        private Node currentNode;


        public MainWindow()
        {
            InitializeComponent();

            scriptDLinkedList = new ScriptDLinkedList();
            scriptDLinkedList = new ScriptDLinkedList();
            scriptDLinkedList.Add(new GameScript(3, "With every line of code mastered, Alex gains experience points, leveling up and unlocking new abilities like Debugging Dash and Algorithmic Aura."));
            scriptDLinkedList.Add(new GameScript(12, "The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams."));
            scriptDLinkedList.Add(new GameScript(4, "The Firewall Fortress looms ahead, its defenses formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks."));
            scriptDLinkedList.Add(new GameScript(2, "Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom."));
            scriptDLinkedList.Add(new GameScript(1, "In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge."));
            scriptDLinkedList.Add(new GameScript(7, "Along the journey, Alex forges alliances with NPC coders, forming a guild known as 'Syntax Sentinels,' united by their dedication to digital mastery."));
            scriptDLinkedList.Add(new GameScript(10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere."));
            scriptDLinkedList.Add(new GameScript(11, "Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology."));
            scriptDLinkedList.Add(new GameScript(9, "In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes."));
            scriptDLinkedList.Add(new GameScript(5, "Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions."));
            scriptDLinkedList.Add(new GameScript(6, "Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumored to contain the ultimate programming language."));
            scriptDLinkedList.Add(new GameScript(8, "The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm."));

            DisplaySortedGameScript();
            currentNode = scriptDLinkedList.GetHead();
            if (currentNode != null)
            {
                tbxOneLine.Text = $"{currentNode.Data.storyNumber}: {currentNode.Data.storyLine}";
            }
        }

        private void DisplaySortedGameScript()
        {
        
            scriptDLinkedList.SortGameScript();


            List<string> sortedStorylines = scriptDLinkedList.GetSortedGameScript();

            
            lbxFullScript.Items.Clear();
            foreach (var story in sortedStorylines)
            {
                lbxFullScript.Items.Add(story);
            }
        }

       
       

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentNode != null && currentNode.next != null)
            {
                currentNode = currentNode.next;
               
                    tbxOneLine.Text = $"{currentNode.Data.storyNumber}: {currentNode.Data.storyLine}";
                
            }

        }
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (currentNode != null && currentNode.previous != null)
            {
                currentNode = currentNode.previous;
                
                    tbxOneLine.Text = $"{currentNode.Data.storyNumber}: {currentNode.Data.storyLine}";
               
                
            }


        }

    }
}