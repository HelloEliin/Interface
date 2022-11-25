namespace Interface;



partial class Program
{

static void Main(string[] args)
    {



        var workflow = new WorkFlow();
        var workflowengine = new WorkflowEngine();
        var processing = new Processing();
        var email = new Email();
        var webservice = new WebService();


        workflow.Add(webservice);

        workflowengine.Run(workflow);
 

    }
}

