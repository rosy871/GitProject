using System;

namespace GitProject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

		public string Name { get; set; }	// fixed int to string in hotfix branch
	}
}
