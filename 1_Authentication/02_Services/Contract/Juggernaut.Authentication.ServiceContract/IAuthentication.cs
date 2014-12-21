using System;
using System.ServiceModel;
using Juggernaut.Authentication.Common;
using Juggernaut.Authentication.DataContract;
using Juggernaut.Authentication.DataContract.Data;

namespace Juggernaut.Authentication.ServiceContract
{
    [ServiceContract(Namespace = Constants.ServiceNamespace, Name = "Authentication", SessionMode = SessionMode.Allowed)]
    public interface IAuthentication : IDisposable
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "Login")]
        [ServiceKnownTypeAttribute(typeof(WindowsCredentials))]
        [ServiceKnownTypeAttribute(typeof(UserCredentials))]
        [ServiceKnownTypeAttribute(typeof(SubscriberCredentials))]
        [ServiceKnownTypeAttribute(typeof(Credentials))]
        [FaultContract(typeof(JuggernautAuthenticationServiceFault))]
        ResponseLogin Login(RequestLogin request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "Logout")]
        [FaultContract(typeof(JuggernautAuthenticationServiceSecurityFault))]
        ResponseLogout Logout(RequestLogout request);
    }
}
