﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTS_2019.BLL.PublicFunction {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL.PublicFunction.PublicFunction")]
    public interface PublicFunction {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PublicFunction/PublicPagingSelect", ReplyAction="http://tempuri.org/PublicFunction/PublicPagingSelectResponse")]
        System.Data.DataSet PublicPagingSelect(string strTblName, string strGetFields, string strFldName, int intPageSize, int intPageIndex, bool blDoCount, bool blOrderType, string strWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PublicFunction/PublicPagingSelect", ReplyAction="http://tempuri.org/PublicFunction/PublicPagingSelectResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> PublicPagingSelectAsync(string strTblName, string strGetFields, string strFldName, int intPageSize, int intPageIndex, bool blDoCount, bool blOrderType, string strWhere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PublicFunction/InsertSystem_operation_log", ReplyAction="http://tempuri.org/PublicFunction/InsertSystem_operation_logResponse")]
        System.Data.DataSet InsertSystem_operation_log(int operator_id, int as_operation_type_id, string operational_context, System.DateTime operation_time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PublicFunction/InsertSystem_operation_log", ReplyAction="http://tempuri.org/PublicFunction/InsertSystem_operation_logResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> InsertSystem_operation_logAsync(int operator_id, int as_operation_type_id, string operational_context, System.DateTime operation_time);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PublicFunctionChannel : TTS_2019.BLL.PublicFunction.PublicFunction, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublicFunctionClient : System.ServiceModel.ClientBase<TTS_2019.BLL.PublicFunction.PublicFunction>, TTS_2019.BLL.PublicFunction.PublicFunction {
        
        public PublicFunctionClient() {
        }
        
        public PublicFunctionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PublicFunctionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicFunctionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PublicFunctionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet PublicPagingSelect(string strTblName, string strGetFields, string strFldName, int intPageSize, int intPageIndex, bool blDoCount, bool blOrderType, string strWhere) {
            return base.Channel.PublicPagingSelect(strTblName, strGetFields, strFldName, intPageSize, intPageIndex, blDoCount, blOrderType, strWhere);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PublicPagingSelectAsync(string strTblName, string strGetFields, string strFldName, int intPageSize, int intPageIndex, bool blDoCount, bool blOrderType, string strWhere) {
            return base.Channel.PublicPagingSelectAsync(strTblName, strGetFields, strFldName, intPageSize, intPageIndex, blDoCount, blOrderType, strWhere);
        }
        
        public System.Data.DataSet InsertSystem_operation_log(int operator_id, int as_operation_type_id, string operational_context, System.DateTime operation_time) {
            return base.Channel.InsertSystem_operation_log(operator_id, as_operation_type_id, operational_context, operation_time);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> InsertSystem_operation_logAsync(int operator_id, int as_operation_type_id, string operational_context, System.DateTime operation_time) {
            return base.Channel.InsertSystem_operation_logAsync(operator_id, as_operation_type_id, operational_context, operation_time);
        }
    }
}
