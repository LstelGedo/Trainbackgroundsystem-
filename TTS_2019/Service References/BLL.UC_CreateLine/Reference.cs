﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTS_2019.BLL.UC_CreateLine {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BLL.UC_CreateLine.UC_CreateLine")]
    public interface UC_CreateLine {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStationManage", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStationManageResponse")]
        System.Data.DataSet UserControl_Loaded_SelectStationManage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStationManage", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStationManageResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectStationManageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSite_FromSiteId", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSite_FromSiteIdResponse" +
            "")]
        System.Data.DataSet UserControl_Loaded_SelectSite_FromSiteId(int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSite_FromSiteId", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSite_FromSiteIdResponse" +
            "")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectSite_FromSiteIdAsync(int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectProvince", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectProvinceResponse")]
        System.Data.DataSet UserControl_Loaded_SelectProvince();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectProvince", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectProvinceResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectProvinceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertStationResponse")]
        System.Data.DataSet UserControl_Loaded_InsertStation(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertStationResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_InsertStationAsync(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertNeighborSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertNeighborSiteResponse")]
        int UserControl_Loaded_InsertNeighborSite(int intsite_id, int intneighbor_site_id, decimal decdistance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertNeighborSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertNeighborSiteResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_InsertNeighborSiteAsync(int intsite_id, int intneighbor_site_id, decimal decdistance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteStationResponse")]
        int UserControl_Loaded_DeleteStation(int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteStationResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteStationAsync(int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteNeighborSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteNeighborSiteResponse")]
        int UserControl_Loaded_DeleteNeighborSite(int intsite_neighbor_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteNeighborSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteNeighborSiteResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteNeighborSiteAsync(int intsite_neighbor_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_StopSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_StopSiteResponse")]
        int UserControl_Loaded_StopSite(int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_StopSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_StopSiteResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_StopSiteAsync(int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateStationResponse")]
        int UserControl_Loaded_UpdateStation(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no, int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateStationResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_UpdateStationAsync(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no, int intsite_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStationResponse")]
        System.Data.DataSet UserControl_Loaded_SelectStation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStation", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectStationResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectStationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectLineResponse")]
        System.Data.DataSet UserControl_Loaded_SelectLine();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectLineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectLineAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectDetailLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectDetailLineResponse")]
        System.Data.DataSet UserControl_Loaded_SelectDetailLine(int intline_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectDetailLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectDetailLineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectDetailLineAsync(int intline_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSiteResponse")]
        System.Data.DataSet UserControl_Loaded_SelectSite();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSite", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_SelectSiteResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectSiteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertLineResponse")]
        System.Data.DataSet UserControl_Loaded_InsertLine(string strline_name, string strsimple_code, string strmileage, bool blstop_no, string strnote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertLineResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_InsertLineAsync(string strline_name, string strsimple_code, string strmileage, bool blstop_no, string strnote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertDetailLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertDetailLineResponse")]
        int UserControl_Loaded_InsertDetailLine(int intline_id, int intsite_id, int intranking_sitea_id, decimal dedistance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertDetailLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_InsertDetailLineResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_InsertDetailLineAsync(int intline_id, int intsite_id, int intranking_sitea_id, decimal dedistance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteLineResponse")]
        int UserControl_Loaded_DeleteLine(int intline_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteLineResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteLineAsync(int intline_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteDetailLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteDetailLineResponse")]
        int UserControl_Loaded_DeleteDetailLine(int intdetailed_line_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteDetailLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_DeleteDetailLineResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteDetailLineAsync(int intdetailed_line_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateLineResponse")]
        int UserControl_Loaded_UpdateLine(bool blstop_no, int intline_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateLine", ReplyAction="http://tempuri.org/UC_CreateLine/UserControl_Loaded_UpdateLineResponse")]
        System.Threading.Tasks.Task<int> UserControl_Loaded_UpdateLineAsync(bool blstop_no, int intline_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UC_CreateLineChannel : TTS_2019.BLL.UC_CreateLine.UC_CreateLine, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UC_CreateLineClient : System.ServiceModel.ClientBase<TTS_2019.BLL.UC_CreateLine.UC_CreateLine>, TTS_2019.BLL.UC_CreateLine.UC_CreateLine {
        
        public UC_CreateLineClient() {
        }
        
        public UC_CreateLineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UC_CreateLineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UC_CreateLineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UC_CreateLineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectStationManage() {
            return base.Channel.UserControl_Loaded_SelectStationManage();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectStationManageAsync() {
            return base.Channel.UserControl_Loaded_SelectStationManageAsync();
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectSite_FromSiteId(int intsite_id) {
            return base.Channel.UserControl_Loaded_SelectSite_FromSiteId(intsite_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectSite_FromSiteIdAsync(int intsite_id) {
            return base.Channel.UserControl_Loaded_SelectSite_FromSiteIdAsync(intsite_id);
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectProvince() {
            return base.Channel.UserControl_Loaded_SelectProvince();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectProvinceAsync() {
            return base.Channel.UserControl_Loaded_SelectProvinceAsync();
        }
        
        public System.Data.DataSet UserControl_Loaded_InsertStation(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no) {
            return base.Channel.UserControl_Loaded_InsertStation(strsite_name, strshort_code, strfull_code, intpro_id, blstop_no);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_InsertStationAsync(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no) {
            return base.Channel.UserControl_Loaded_InsertStationAsync(strsite_name, strshort_code, strfull_code, intpro_id, blstop_no);
        }
        
        public int UserControl_Loaded_InsertNeighborSite(int intsite_id, int intneighbor_site_id, decimal decdistance) {
            return base.Channel.UserControl_Loaded_InsertNeighborSite(intsite_id, intneighbor_site_id, decdistance);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_InsertNeighborSiteAsync(int intsite_id, int intneighbor_site_id, decimal decdistance) {
            return base.Channel.UserControl_Loaded_InsertNeighborSiteAsync(intsite_id, intneighbor_site_id, decdistance);
        }
        
        public int UserControl_Loaded_DeleteStation(int intsite_id) {
            return base.Channel.UserControl_Loaded_DeleteStation(intsite_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteStationAsync(int intsite_id) {
            return base.Channel.UserControl_Loaded_DeleteStationAsync(intsite_id);
        }
        
        public int UserControl_Loaded_DeleteNeighborSite(int intsite_neighbor_id) {
            return base.Channel.UserControl_Loaded_DeleteNeighborSite(intsite_neighbor_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteNeighborSiteAsync(int intsite_neighbor_id) {
            return base.Channel.UserControl_Loaded_DeleteNeighborSiteAsync(intsite_neighbor_id);
        }
        
        public int UserControl_Loaded_StopSite(int intsite_id) {
            return base.Channel.UserControl_Loaded_StopSite(intsite_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_StopSiteAsync(int intsite_id) {
            return base.Channel.UserControl_Loaded_StopSiteAsync(intsite_id);
        }
        
        public int UserControl_Loaded_UpdateStation(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no, int intsite_id) {
            return base.Channel.UserControl_Loaded_UpdateStation(strsite_name, strshort_code, strfull_code, intpro_id, blstop_no, intsite_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_UpdateStationAsync(string strsite_name, string strshort_code, string strfull_code, int intpro_id, bool blstop_no, int intsite_id) {
            return base.Channel.UserControl_Loaded_UpdateStationAsync(strsite_name, strshort_code, strfull_code, intpro_id, blstop_no, intsite_id);
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectStation() {
            return base.Channel.UserControl_Loaded_SelectStation();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectStationAsync() {
            return base.Channel.UserControl_Loaded_SelectStationAsync();
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectLine() {
            return base.Channel.UserControl_Loaded_SelectLine();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectLineAsync() {
            return base.Channel.UserControl_Loaded_SelectLineAsync();
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectDetailLine(int intline_id) {
            return base.Channel.UserControl_Loaded_SelectDetailLine(intline_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectDetailLineAsync(int intline_id) {
            return base.Channel.UserControl_Loaded_SelectDetailLineAsync(intline_id);
        }
        
        public System.Data.DataSet UserControl_Loaded_SelectSite() {
            return base.Channel.UserControl_Loaded_SelectSite();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_SelectSiteAsync() {
            return base.Channel.UserControl_Loaded_SelectSiteAsync();
        }
        
        public System.Data.DataSet UserControl_Loaded_InsertLine(string strline_name, string strsimple_code, string strmileage, bool blstop_no, string strnote) {
            return base.Channel.UserControl_Loaded_InsertLine(strline_name, strsimple_code, strmileage, blstop_no, strnote);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> UserControl_Loaded_InsertLineAsync(string strline_name, string strsimple_code, string strmileage, bool blstop_no, string strnote) {
            return base.Channel.UserControl_Loaded_InsertLineAsync(strline_name, strsimple_code, strmileage, blstop_no, strnote);
        }
        
        public int UserControl_Loaded_InsertDetailLine(int intline_id, int intsite_id, int intranking_sitea_id, decimal dedistance) {
            return base.Channel.UserControl_Loaded_InsertDetailLine(intline_id, intsite_id, intranking_sitea_id, dedistance);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_InsertDetailLineAsync(int intline_id, int intsite_id, int intranking_sitea_id, decimal dedistance) {
            return base.Channel.UserControl_Loaded_InsertDetailLineAsync(intline_id, intsite_id, intranking_sitea_id, dedistance);
        }
        
        public int UserControl_Loaded_DeleteLine(int intline_id) {
            return base.Channel.UserControl_Loaded_DeleteLine(intline_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteLineAsync(int intline_id) {
            return base.Channel.UserControl_Loaded_DeleteLineAsync(intline_id);
        }
        
        public int UserControl_Loaded_DeleteDetailLine(int intdetailed_line_id) {
            return base.Channel.UserControl_Loaded_DeleteDetailLine(intdetailed_line_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_DeleteDetailLineAsync(int intdetailed_line_id) {
            return base.Channel.UserControl_Loaded_DeleteDetailLineAsync(intdetailed_line_id);
        }
        
        public int UserControl_Loaded_UpdateLine(bool blstop_no, int intline_id) {
            return base.Channel.UserControl_Loaded_UpdateLine(blstop_no, intline_id);
        }
        
        public System.Threading.Tasks.Task<int> UserControl_Loaded_UpdateLineAsync(bool blstop_no, int intline_id) {
            return base.Channel.UserControl_Loaded_UpdateLineAsync(blstop_no, intline_id);
        }
    }
}