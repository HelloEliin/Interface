using static Interface.Program;

namespace Interface
{

    public interface IWorkFlow
    {


        public void Add(IActivity activity);

        public void Remove(IActivity activity);


        List<IActivity> GetAllActivities();


    }
}


