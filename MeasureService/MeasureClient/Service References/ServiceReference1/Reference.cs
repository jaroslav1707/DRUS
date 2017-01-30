﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeasureClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMeasureService", CallbackContract=typeof(MeasureClient.ServiceReference1.IMeasureServiceCallback))]
    public interface IMeasureService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMeasureService/Pretplati")]
        void Pretplati(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMeasureService/Odjavi")]
        void Odjavi(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeasureService/DodajMerenje", ReplyAction="http://tempuri.org/IMeasureService/DodajMerenjeResponse")]
        void DodajMerenje(int id, int value, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeasureService/VratiSvaMerenjaMeraca", ReplyAction="http://tempuri.org/IMeasureService/VratiSvaMerenjaMeracaResponse")]
        string VratiSvaMerenjaMeraca(int measurerId, System.DateTime from, System.DateTime until, int type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeasureService/VratiSveTrenutkeGdeJeMerenje", ReplyAction="http://tempuri.org/IMeasureService/VratiSveTrenutkeGdeJeMerenjeResponse")]
        string VratiSveTrenutkeGdeJeMerenje(int measurerId, int type, int limitType, double limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeasureService/VratiSveTrenutkeGdeJeMerenjeNaLokaciji", ReplyAction="http://tempuri.org/IMeasureService/VratiSveTrenutkeGdeJeMerenjeNaLokacijiResponse" +
            "")]
        string VratiSveTrenutkeGdeJeMerenjeNaLokaciji(string locationName, int type, int limitType, double limit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeasureService/ProsekNaLokaciji", ReplyAction="http://tempuri.org/IMeasureService/ProsekNaLokacijiResponse")]
        string ProsekNaLokaciji(string locationName, int type, System.DateTime dateFrom, System.DateTime dateUntil);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeasureServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeasureService/NotifikacijaMerenja", ReplyAction="http://tempuri.org/IMeasureService/NotifikacijaMerenjaResponse")]
        void NotifikacijaMerenja(int id, double value, string type);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeasureServiceChannel : MeasureClient.ServiceReference1.IMeasureService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MeasureServiceClient : System.ServiceModel.DuplexClientBase<MeasureClient.ServiceReference1.IMeasureService>, MeasureClient.ServiceReference1.IMeasureService {
        
        public MeasureServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MeasureServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MeasureServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MeasureServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MeasureServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Pretplati(int id) {
            base.Channel.Pretplati(id);
        }
        
        public void Odjavi(int id) {
            base.Channel.Odjavi(id);
        }
        
        public void DodajMerenje(int id, int value, string type) {
            base.Channel.DodajMerenje(id, value, type);
        }
        
        public string VratiSvaMerenjaMeraca(int measurerId, System.DateTime from, System.DateTime until, int type) {
            return base.Channel.VratiSvaMerenjaMeraca(measurerId, from, until, type);
        }
        
        public string VratiSveTrenutkeGdeJeMerenje(int measurerId, int type, int limitType, double limit) {
            return base.Channel.VratiSveTrenutkeGdeJeMerenje(measurerId, type, limitType, limit);
        }
        
        public string VratiSveTrenutkeGdeJeMerenjeNaLokaciji(string locationName, int type, int limitType, double limit) {
            return base.Channel.VratiSveTrenutkeGdeJeMerenjeNaLokaciji(locationName, type, limitType, limit);
        }
        
        public string ProsekNaLokaciji(string locationName, int type, System.DateTime dateFrom, System.DateTime dateUntil) {
            return base.Channel.ProsekNaLokaciji(locationName, type, dateFrom, dateUntil);
        }
    }
}
