﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/", ConfigurationName="ServiceReference1.ServicioEjemploSoap")]
    public interface ServicioEjemploSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://localhost/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/HelloWorld", ReplyAction="*")]
        WebApplication2.ServiceReference1.HelloWorldResponse HelloWorld(WebApplication2.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebApplication2.ServiceReference1.HelloWorldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://localhost/", Order=0)]
        public WebApplication2.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplication2.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://localhost/", Order=0)]
        public WebApplication2.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplication2.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioEjemploSoapChannel : WebApplication2.ServiceReference1.ServicioEjemploSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioEjemploSoapClient : System.ServiceModel.ClientBase<WebApplication2.ServiceReference1.ServicioEjemploSoap>, WebApplication2.ServiceReference1.ServicioEjemploSoap {
        
        public ServicioEjemploSoapClient() {
        }
        
        public ServicioEjemploSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioEjemploSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEjemploSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEjemploSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.ServiceReference1.HelloWorldResponse WebApplication2.ServiceReference1.ServicioEjemploSoap.HelloWorld(WebApplication2.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplication2.ServiceReference1.HelloWorldRequest inValue = new WebApplication2.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication2.ServiceReference1.HelloWorldRequestBody();
            WebApplication2.ServiceReference1.HelloWorldResponse retVal = ((WebApplication2.ServiceReference1.ServicioEjemploSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.ServiceReference1.HelloWorldResponse> WebApplication2.ServiceReference1.ServicioEjemploSoap.HelloWorldAsync(WebApplication2.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebApplication2.ServiceReference1.HelloWorldRequest inValue = new WebApplication2.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebApplication2.ServiceReference1.HelloWorldRequestBody();
            return ((WebApplication2.ServiceReference1.ServicioEjemploSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}
