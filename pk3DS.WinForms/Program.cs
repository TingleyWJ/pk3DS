﻿using System;
using System.Windows.Forms;

#if !DEBUG
using System.Threading;
#endif

namespace pk3DS.WinForms;

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
#if !DEBUG
            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += UIThreadException;

            // Set the unhandled exception mode to force all Windows Forms errors to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
#endif

        // Run the application
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Main());
    }

#if !DEBUG
        // Handle the UI exceptions by showing a dialog box, and asking the user whether or not they wish to abort execution.
        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                // Todo: make this translatable
                ErrorWindow.ShowErrorDialog("An unhandled exception has occurred." + Environment.NewLine + "You can continue running the program (albeit with potential side-effects), but please report this error.", t.Exception, true);
            }
            catch
            {
                try
                {
                    // Todo: make this translatable
                    MessageBox.Show("A fatal error has occurred in pk3DS, and the details could not be displayed.  Please report this to the author.", "pk3DS Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether
        // or not they wish to abort execution.
        // NOTE: This exception cannot be kept from terminating the application - it can only 
        // log the event, and inform the user about it. 
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var ex = (Exception)e.ExceptionObject;
                // Todo: make this translatable
                ErrorWindow.ShowErrorDialog("An unhandled exception has occurred." + Environment.NewLine + "The program must now close.", ex, false);
            }
            catch
            {
                try
                {
                    // Todo: make this translatable
                    MessageBox.Show("A fatal non-UI error has occurred in PKHeX, and the details could not be displayed.  Please report this to the author.", "PKHeX Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
#endif
}