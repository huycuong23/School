using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WS_CSDL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IICSDLService" in both code and config file together.
    [ServiceContract]
    public interface IICSDLService
    {
        [OperationContract]
        string Insert_Lop(BangLop lop);
        [OperationContract]
        List<BangLop> GetAll();
        [OperationContract]
        void Update_Lop(BangLop lop);
        [OperationContract]
        void Delete_Lop(BangLop lop);


        [OperationContract]
        string Insert_Mon(Bangmon mon);
        [OperationContract]
        List<Bangmon> Get_Mon();
        [OperationContract]
        void Update_Mon(Bangmon mon);
        [OperationContract]
        void Delete_Mon(Bangmon mon);


    }
}
