using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fun
{

    class ActionStartedArgs : EventArgs
    {

        private string message;

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

    }

    class ActionFinishedArgs : EventArgs
    {
        private string message;

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }
    }

    class EventPublisher
    {

        public event EventHandler<ActionFinishedArgs> ActionFinished;
        public event EventHandler<ActionStartedArgs> ActionStarted;

        public async Task PerformAction() {
            OnActionStarted();
            await Task.Delay(5000);
            OnActionFinished();
        }

        protected virtual void OnActionStarted()
        {
            ActionStarted?.Invoke(this, new ActionStartedArgs() { Message = "Hi" });
        }
        protected virtual void OnActionFinished()
        {
            ActionFinished?.Invoke(this, new ActionFinishedArgs() { Message = "Bye" });
        }

    }
}
