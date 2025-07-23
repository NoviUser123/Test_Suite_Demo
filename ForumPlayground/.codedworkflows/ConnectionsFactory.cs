using UiPath.CodedWorkflows;
using System;

namespace ForumPlayground
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_sanjaybhat1000_gmail_com__2 { get; set; }

        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_sanjaybhat1000_gmail_com__3 { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_sanjaybhat1000_gmail_com__2 = new UiPath.GSuite.Activities.Api.GmailConnection("273a800b-2292-465c-84e2-3f34c3d817fe", resolver);
            My_Workspace_sanjaybhat1000_gmail_com__3 = new UiPath.GSuite.Activities.Api.GmailConnection("5e1525b1-4911-46fc-a3b9-43a182c6add4", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}