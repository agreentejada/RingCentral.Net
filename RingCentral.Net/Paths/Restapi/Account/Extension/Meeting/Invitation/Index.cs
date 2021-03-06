using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting.Invitation
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Meeting.Index parent;

        public Index(Restapi.Account.Extension.Meeting.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/invitation";
        }

        /// <summary>
        /// Operation: Get Meeting Invitation
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/invitation
        /// Rate Limit Group: Light
        /// App Permission: Meetings
        /// User Permission: Meetings
        /// </summary>
        public async Task<RingCentral.PublicMeetingInvitationResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.PublicMeetingInvitationResponse>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Meeting
{
    public partial class Index
    {
        public Restapi.Account.Extension.Meeting.Invitation.Index Invitation()
        {
            return new Restapi.Account.Extension.Meeting.Invitation.Index(this);
        }
    }
}