namespace Interface

{
    public class WorkflowEngine
    {






        public void Run(IWorkFlow workflow)
        {
            foreach (var activity in workflow.GetAllActivities())
            {
                activity.Execute();
            }


        }



    }
}

