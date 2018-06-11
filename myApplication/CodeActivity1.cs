using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace myApplication
{

    public sealed class CodeActivity1 : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> defaultName { get; set; }
        // Define an activity output argument of type string
        public OutArgument<string> enteredName { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument
            String yourName = Console.ReadLine();
            if (yourName == "")
            {
                string dName = context.GetValue(this.defaultName);
                yourName = dName;
            }
            string name = yourName;
            context.SetValue(this.enteredName, name);
        }
    }
}
