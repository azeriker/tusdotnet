﻿using System;
using System.Threading.Tasks;

namespace tusdotnet.Models.Configuration
{
    /// <summary>
    /// Events supported by tusdotnet
    /// </summary>
    public class Events
    {
        /// <summary>
        /// Callback ran when a file is completely uploaded. 
        /// This callback is called only once after the last bytes have been written to the store or 
        /// after a "final" file has been created using the concatenation extension.
        /// It will not be called for any subsequent requests for already completed files.
        /// </summary>
        public Func<FileCompleteContext, Task> OnFileCompleteAsync { get; set; }

        /// <summary>
        /// Callback ran right before a file is created. This callback can be used to validate
        /// files before they are created. Calling the <code>FailRequest</code> method on the context 
        /// will return a 400 Bad Request to the client.
        /// </summary>
        public Func<BeforeCreateContext, Task> OnBeforeCreateAsync { get; set; }

        /// <summary>
        /// Callback ran right before a file is deleted. This callback can be used to validate
        /// that a file can be deleted. Calling the <code>FailRequest</code> method on the context 
        /// will return a 400 Bad Request to the client.
        /// </summary>
        public Func<BeforeDeleteContext, Task> OnBeforeDeleteAsync { get; set; }
    }
}
