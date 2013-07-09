using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Ordy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class Core : Application
    {

        #region All begin here
        private void CoreStartup(object sender, StartupEventArgs e)
        {
            // Init attributes
            this.NotesWindows = new List<NoteWindow>();

            // Create and default NoteWindo
            this.NotesWindows.Add(new NoteWindow());

            // Call init methods
            this.InitEvents();
        }
        #endregion

        #region Events methods
        public void InitEvents()
        {

        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            var but = sender as System.Windows.Controls.Button;
            var gri = but.Parent as System.Windows.Controls.Grid;
            var win = gri.Parent as Ordy.NoteWindow;

            NoteWindow NewWindowNote = new NoteWindow();

            NewWindowNote.Left = win.Left + win.Width + 10;
            NewWindowNote.Top = win.Top;

           // NewWindowNote.text.Text = win.text.Text;

            this.NotesWindows.Add(NewWindowNote);
        }
        #endregion

        #region Attributes
        private List<NoteWindow> NotesWindows;
        #endregion
    }
}
