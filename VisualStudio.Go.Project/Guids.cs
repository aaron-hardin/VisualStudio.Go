// Guids.cs
// MUST match guids.h
using System;

namespace AaronApp.VisualStudio_Go_Project
{
    static class GuidList
    {
        public const string guidVisualStudio_Go_ProjectPkgString = "140ae009-a1f3-4f0d-b1a7-a83c40ac34c8";
        public const string guidVisualStudio_Go_ProjectCmdSetString = "fcf98f93-91e1-4db8-87ef-33ec2d90e702";
	    public const string guidGoProjectFactoryString = "743e1734-bc13-4165-8b0d-4f107c77dec7";

        public static readonly Guid guidVisualStudio_Go_ProjectCmdSet = new Guid(guidVisualStudio_Go_ProjectCmdSetString);
		public static readonly Guid guidGoProjectFactory = new Guid(guidGoProjectFactoryString);
    };
}