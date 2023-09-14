using System;

namespace AdapterSamples1
{
    // The Target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }

    // The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }

    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class AdapterA : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterA(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }

    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class AdapterB : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterB(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is not '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}