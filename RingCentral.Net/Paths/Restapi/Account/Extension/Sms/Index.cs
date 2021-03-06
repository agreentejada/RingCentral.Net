using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Sms
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/sms";
        }

        /// <summary>
        /// Operation: Send SMS
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/sms
        /// Rate Limit Group: Medium
        /// App Permission: SMS
        /// User Permission: OutboundSMS
        /// </summary>
        public async Task<RingCentral.GetSMSMessageInfoResponse> Post(RingCentral.CreateSMSMessage createSMSMessage,
            RestRequestConfig restRequestConfig = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createSMSMessage);
            return await rc.Post<RingCentral.GetSMSMessageInfoResponse>(this.Path(), multipartFormDataContent, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Sms.Index Sms()
        {
            return new Restapi.Account.Extension.Sms.Index(this);
        }
    }
}