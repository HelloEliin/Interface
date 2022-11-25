using System.Diagnostics;

namespace Interface
{

    public class WorkFlow : IWorkFlow
    {

        private List<IActivity> _activities = new List<IActivity>();






        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public List<IActivity> GetAllActivities()
        {
            return _activities;
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }






    }
}

