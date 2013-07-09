using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ordy
{
    /// <summary>
    /// Interaction logic for NoteWindow.xaml
    /// </summary>
    public partial class NoteWindow : Window
    {
        #region Constructors / Destructors
        public NoteWindow()
        {
            // Init attributes
            InitializeComponent(); 
            this.Notes = new List<Note>() { };

            // Call standard methods
            this.Show();

            // Enable draggin windows
            this.MouseLeftButtonDown += delegate { this.DragMove(); };

            // tests
            string a = "aa";
            this.Tasks.Items.Add(a);
            this.Tasks.Items.Add(a);
            this.Tasks.Items.Add(a);
        }
        #endregion

        #region Methods
        public void AddNote(string notestr)
        {
            this.Notes.Add(new Ordy.Note(notestr));
         
        }

        public void AddNote(Note note)
        {
            this.Notes.Add(note);
        }
        #endregion

        #region Attributes
        public List<Ordy.Note> Notes { get; set; }
        #endregion
    }
}
