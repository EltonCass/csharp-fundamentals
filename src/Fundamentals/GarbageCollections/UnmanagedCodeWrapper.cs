// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt
using System.Runtime.InteropServices;

namespace Fundamentals.GarbageCollections
{
    /// <summary>
    /// The purpose of implementing the IDisposable pattern in this context
    /// is to allow for the cleanup of any additional managed resources associated 
    /// with the MessageBoxWrapper class. In this case, there are no additional 
    /// managed resources to clean up, but the Dispose method is still included 
    /// to follow the recommended pattern and provide consistency in resource 
    /// management across different classes.
    /// </summary>
    internal class UnmanagedCodeWrapper : IDisposable
    {
        private bool disposed = false;

        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int options);

        public UnmanagedCodeWrapper(string message, string caption)
        {
            MessageBox(IntPtr.Zero, message, caption, 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources (if any)
                }

                // Dispose unmanaged resources
                // No explicit cleanup needed for MessageBox
            }

            disposed = true;
        }

        ~UnmanagedCodeWrapper()
        {
            Dispose(false);
        }
    }
}
